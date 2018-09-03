#include <Hosting/CoreHost.h>
#include <Hosting/coreclrhost.h>
#include <QFileInfo>
#include <QDir>
#include <dlfcn.h>

CoreHost::CoreHost(QSharedPointer<RuntimeConfig> runtimeConfig) :
    runtimeConfig(runtimeConfig),
    init(nullptr),
    shutdown(nullptr),
    shutdown2(nullptr),
    createDelegate(nullptr),
    executeAssembly(nullptr)
{

}

bool CoreHost::isClrLoaded()
{
    return loadResult == LoadClrResult::Loaded;
}

CoreHost::LoadClrResult CoreHost::loadClr()
{
    if(loadResult == CoreHost::LoadClrResult::Loaded) {
        return LoadClrResult::AlreadyLoaded;
    }

    QList<QString> dotnetRoots;
    dotnetRoots.append("/usr/local/share/dotnet");
    dotnetRoots.append("/usr/share/dotnet");
    dotnetRoots.append("/opt/dotnet");
    // TODO: find path on windows
    {
        QString dotnetRoot = QString(getenv("DOTNET_ROOT"));
        if(!dotnetRoot.isNull() && !dotnetRoot.isEmpty()) {
            dotnetRoot.insert(0, dotnetRoot);
        }
    }



    void* dll = dlopen(clrPath.toLocal8Bit().constData(), RTLD_NOW | RTLD_LOCAL);
    if(dll == nullptr) {
        qCritical("Couldn't load lib at %s", qPrintable(clrPath));
        return LoadClrResult::Failed;
    }

    init = reinterpret_cast<coreclr_initialize_ptr>(dlsym(dll, "coreclr_initialize"));
    shutdown = reinterpret_cast<coreclr_shutdown_ptr>(dlsym(dll, "coreclr_shutdown"));
    shutdown2 = reinterpret_cast<coreclr_shutdown_2_ptr>(dlsym(dll, "coreclr_shutdown_2"));
    createDelegate = reinterpret_cast<coreclr_create_delegate_ptr>(dlsym(dll, "coreclr_create_delegate"));
    executeAssembly = reinterpret_cast<coreclr_execute_assembly_ptr>(dlsym(dll, "coreclr_execute_assembly"));

    if(init == nullptr) {
        qCritical("Couldn't load 'coreclr_initialize' from %s", qPrintable(clrPath));
        return LoadClrResult::Failed;
    }

    if(shutdown == nullptr) {
        qCritical("Couldn't load 'coreclr_shutdown' from %s", qPrintable(clrPath));
        return LoadClrResult::Failed;
    }

    if(shutdown2 == nullptr) {
        qCritical("Couldn't load 'coreclr_shutdown_2' from %s", qPrintable(clrPath));
        return LoadClrResult::Failed;
    }

    if(createDelegate == nullptr) {
        qCritical("Couldn't load 'coreclr_create_delegate' from %s", qPrintable(clrPath));
        return LoadClrResult::Failed;
    }

    if(executeAssembly == nullptr) {
        qCritical("Couldn't load 'coreclr_execute_assembly' from %s", qPrintable(clrPath));
        return LoadClrResult::Failed;
    }

    loadResult = LoadClrResult::Loaded;
    return loadResult;
}

QString CoreHost::findClrPath()
{
    return "/usr/local/share/dotnet/shared/Microsoft.NETCore.App/2.1.1/libcoreclr.dylib";
}

QString CoreHost::findDotNetRoot()
{
    return "/usr/local/share/dotnet";
}

QSharedPointer<CoreHost> CoreHost::buildHost(QString managedEntryAssembly)
{
    QFileInfo file(managedEntryAssembly);
    if(!file.exists()) {
        qCritical("The file %s doesn't exist.", qPrintable(managedEntryAssembly));
        return nullptr;
    }

    QString depsFile;
    depsFile.append(file.path());
    depsFile.append(QDir::separator());
    depsFile.append(file.baseName());
    depsFile.append(".deps.json");

    QString runtimeFile;
    runtimeFile.append(file.path());
    runtimeFile.append(QDir::separator());
    runtimeFile.append(file.baseName());
    runtimeFile.append(".runtimeconfig.json");

    QString runtimeDevFile;
    runtimeDevFile.append(file.path());
    runtimeDevFile.append(QDir::separator());
    runtimeDevFile.append(file.baseName());
    runtimeDevFile.append(".runtimeconfig.dev.json");

    QFileInfo depsFileInfo(depsFile);
    QFileInfo runtimeFileInfo(runtimeFile);
    QFileInfo runtimeDevFileInfo(runtimeFile);

    if(!depsFileInfo.exists()) {
        qCritical("The file %s doesn't exist.", qPrintable(depsFile));
    }

    if(!runtimeFileInfo.exists()) {
        qCritical("The file %s doesn't exist.", qPrintable(runtimeFile));
    }

    QSharedPointer<RuntimeConfig> runtimeConfig = RuntimeConfig::fromFile(runtimeFileInfo.path());

    if(runtimeConfig.isNull()) {
        qCritical("failed to load runtime config at %s", qPrintable(runtimeFileInfo.path()));
        return nullptr;
    }

    QSharedPointer<RuntimeConfig> runtimeDevConfig;
    if(runtimeDevFileInfo.exists()) {
        runtimeDevConfig = RuntimeConfig::fromFile(runtimeDevFileInfo.path());
        if(runtimeDevConfig == nullptr) {
            qCritical("failed to load runtime config at %s", qPrintable(runtimeDevFileInfo.path()));
            return nullptr;
        }
        runtimeConfig = runtimeConfig->merge(runtimeDevConfig);
    }

    return QSharedPointer<CoreHost>(new CoreHost(runtimeConfig));
}
