#ifndef COREHOST_H
#define COREHOST_H

#include <QSharedPointer>
#include <QMutex>
#include <Hosting/coreclrhost.h>

class CoreHost
{
public:
    enum LoadHostFxrResult
    {
        Loaded,
        AlreadyLoaded,
        Failed
    };

    CoreHost(QList<QByteArray> args);
    CoreHost();

    static LoadHostFxrResult loadHostFxr();
    static bool isHostFxrLoaded();

    void run();

    static QString findClrPath();
    static QString findHostFxrPath();
    static QString findDotNetRoot();
    static QSharedPointer<CoreHost> buildHost(QList<QByteArray> args);
private:
    // Function pointers to the exported C functions.
    static hostfxr_main_ptr hostfxr_main;
    static LoadHostFxrResult loadResult;
    QList<QByteArray> args;
};

#endif
