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
    static void test();
private:
};

#endif // COREHOST_H
