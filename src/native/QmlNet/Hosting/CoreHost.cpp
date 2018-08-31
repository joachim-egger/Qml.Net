#include <Hosting/CoreHost.h>
#include <Hosting/coreclrhost.h>
#include <dlfcn.h>
#include <iostream>

QMutex CoreHost::loadMutex;
CoreHost::LoadClrResult CoreHost::loadResult = CoreHost::Failed;
coreclr_initialize_ptr CoreHost::init = nullptr;
coreclr_shutdown_ptr CoreHost::shutdown = nullptr;
coreclr_shutdown_2_ptr CoreHost::shutdown2 = nullptr;
coreclr_create_delegate_ptr CoreHost::createDelegate = nullptr;
coreclr_execute_assembly_ptr CoreHost::executeAssembly = nullptr;

CoreHost::CoreHost()
{

}

QSharedPointer<CoreHost> CoreHost::buildHost()
{
    if(!isClrLoaded()) {
        qCritical("The coreclr must be loaded before building.");
        return nullptr;
    }

    return nullptr;
}

bool CoreHost::isClrLoaded()
{
    QMutexLocker lock(&loadMutex);
    return loadResult == LoadClrResult::Loaded;
}

CoreHost::LoadClrResult CoreHost::loadClr(QString clrPath)
{
    QMutexLocker lock(&loadMutex);
    if(loadResult == CoreHost::LoadClrResult::Loaded) {
        return LoadClrResult::AlreadyLoaded;
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

QString CoreHost::findHostFxrPath()
{
    return "/usr/local/share/dotnet/host/fxr/2.1.1/libhostfxr.dylib";
}

void CoreHost::test()
{
    qputenv("DOTNET_ROOT", "/usr/local/share/dotnet");

    QString fxrPath = findHostFxrPath();
    void* dll = dlopen(fxrPath.toLocal8Bit().constData(), RTLD_NOW | RTLD_LOCAL);
    hostfxr_get_native_search_directories_ptr getSearchDirs = reinterpret_cast<hostfxr_get_native_search_directories_ptr>(dlsym(dll, "hostfxr_get_native_search_directories"));

    std::vector<const char*> argv;
    argv.push_back("/usr/local/share/dotnet/dotnet");
    argv.push_back("exec");
    argv.push_back("/Users/pknopf/temp/test-net/bin/Debug/netcoreapp2.1/test-net.dll");
    int argc = argv.size();
    int requiredBufferSize = 0;
    char buffer[2343434];
    int result = getSearchDirs(argc, &argv[0], &buffer[0], 2343434, &requiredBufferSize);

}

static void test(){
    qCritical("test");
}

void CoreHost::test2()
{
    qputenv("DOTNET_ROOT", "/usr/local/share/dotnet");

    QString fxrPath = findHostFxrPath();
    void* dll = dlopen(fxrPath.toLocal8Bit().constData(), RTLD_NOW | RTLD_LOCAL);
    hostfxr_main_ptr main = reinterpret_cast<hostfxr_main_ptr>(dlsym(dll, "hostfxr_main"));

    std::vector<const char*> argv;
    argv.push_back("/usr/local/share/dotnet/dotnet");
    argv.push_back("exec");
    argv.push_back("/Users/pknopf/temp/test-net/bin/Debug/netcoreapp2.1/test-net.dll");
    int argc = argv.size();
    int result = main(argc, &argv[0]);

}
