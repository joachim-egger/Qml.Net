#include <QGuiApplication>
#include <QQmlApplicationEngine>
#include <Hosting/CoreHost.h>
#include <Hosting/coreruncommon.h>

int main(int argc, char *argv[])
{
//    ExecuteManagedAssembly(
//                argv[0],
//                "/usr/local/share/dotnet/shared/Microsoft.NETCore.App/2.1.1/",
//                "/Users/pknopf/temp/test-net/bin/Debug/netcoreapp2.1/test-net.dll",
//                //"/Users/pknopf/git/Qml.Net.Examples/src/Features/bin/Debug/netcoreapp2.1/Features.dll",
//                0,
//                nullptr
//            );

    //QSharedPointer<CoreHost> host = CoreHost::buildHost("/Users/pknopf/temp/test-net/bin/Debug/netcoreapp2.1/test-net.dll");
    CoreHost::test();

    QCoreApplication::setAttribute(Qt::AA_EnableHighDpiScaling);
    QGuiApplication app(argc, argv);

    QQmlApplicationEngine engine;
    engine.load(QUrl(QStringLiteral("qrc:/main.qml")));
    if (engine.rootObjects().isEmpty())
        return -1;

    return app.exec();
}
