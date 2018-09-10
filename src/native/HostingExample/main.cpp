#include <QGuiApplication>
#include <QQmlApplicationEngine>
#include <Hosting/CoreHost.h>
#include <Hosting/coreruncommon.h>

int main(int argc, char *argv[])
{   
    //CoreHost::test();

    std::vector<const char*> arg2v;
    arg2v.push_back("/usr/local/share/dotnet/dotnet");
    arg2v.push_back("exec");
    arg2v.push_back("/Users/pknopf/temp/TestWeb/bin/Debug/netcoreapp2.1/TestWeb.dll");
    int arg2c = arg2v.size();

    CoreHost::test2(arg2c, &arg2v[0]);

    //host_startup_info_t startup_info;
    //startup_info.parse(arg2c, &arg2v[0]);

    QCoreApplication::setAttribute(Qt::AA_EnableHighDpiScaling);
    QGuiApplication app(argc, argv);

    QQmlApplicationEngine engine;
    engine.load(QUrl(QStringLiteral("qrc:/main.qml")));
    if (engine.rootObjects().isEmpty())
        return -1;

    return app.exec();
}
