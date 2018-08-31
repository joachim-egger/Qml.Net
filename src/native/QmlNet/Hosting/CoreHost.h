#ifndef COREHOST_H
#define COREHOST_H

#include <QSharedPointer>
#include <QMutex>
#include <Hosting/coreclrhost.h>

class CoreHost
{
public:
    enum LoadClrResult
    {
        Loaded,
        AlreadyLoaded,
        Failed
    };
    CoreHost();
    static QSharedPointer<CoreHost> buildHost();
    static LoadClrResult loadClr(QString clrPath);
    static bool isClrLoaded();
    static QString findClrPath();
    static QString findHostFxrPath();
private:
    // Function pointers to the exported C functions.
    static coreclr_initialize_ptr init;
    static coreclr_shutdown_ptr shutdown;
    static coreclr_shutdown_2_ptr shutdown2;
    static coreclr_create_delegate_ptr createDelegate;
    static coreclr_execute_assembly_ptr executeAssembly;
    static hostfxr_get_native_search_directories_ptr getNativeSearchPaths;
    static LoadClrResult loadResult;
    static QMutex loadMutex;
};

#endif // COREHOST_H
