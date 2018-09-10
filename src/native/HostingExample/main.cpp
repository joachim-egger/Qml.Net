#include <QGuiApplication>
#include <QQmlApplicationEngine>
#include <Hosting/CoreHost.h>
#include <Hosting/coreruncommon.h>

int main(int argc, char *argv[])
{
    QCoreApplication::setAttribute(Qt::AA_EnableHighDpiScaling);
    QGuiApplication app(argc, argv);

    CoreHost::loadHostFxr();

    QList<QByteArray> hostArgs;
    hostArgs.append("exec");
    hostArgs.append("/Users/pknopf/git/net-core-qml/src/net/Qml.Net.Hosting/bin/Debug/netcoreapp2.1/Qml.Net.Hosting.dll");
    QSharedPointer<CoreHost> host = CoreHost::buildHost(hostArgs);

    host->run();

    QQmlApplicationEngine engine;
    engine.load(QUrl(QStringLiteral("qrc:/main.qml")));
    if (engine.rootObjects().isEmpty())
        return -1;

    int result = app.exec();

    host.clear();

    return result;
}
