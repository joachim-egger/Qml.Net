#ifndef COREHOST_H
#define COREHOST_H

#include <QSharedPointer>
#include <QMutex>
#include <Hosting/coreclrhost.h>
#include <Hosting/RuntimeConfig.h>

class CoreHost
{
public:
    enum LoadClrResult
    {
        Loaded,
        AlreadyLoaded,
        Failed
    };
    CoreHost(QSharedPointer<RuntimeConfig> runtimeConfig);
    LoadClrResult loadClr();
    bool isClrLoaded();
    static QString findClrPath();
    static QString findDotNetRoot();
    static QSharedPointer<CoreHost> buildHost(QString managedEntryAssembly);
private:
    QSharedPointer<RuntimeConfig> runtimeConfig;
    // Function pointers to the exported C functions.
    coreclr_initialize_ptr init;
    coreclr_shutdown_ptr shutdown;
    coreclr_shutdown_2_ptr shutdown2;
    coreclr_create_delegate_ptr createDelegate;
    coreclr_execute_assembly_ptr executeAssembly;
    LoadClrResult loadResult;
};

#endif // COREHOST_H
