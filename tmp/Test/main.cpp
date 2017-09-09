#include <QGuiApplication>
#include <QQmlApplicationEngine>
#include "testtype.h"

int main(int argc, char *argv[])
{
    QCoreApplication::setAttribute(Qt::AA_EnableHighDpiScaling);
    QGuiApplication app(argc, argv);

    QQmlApplicationEngine engine;

    qmlRegisterType<TestType>("test", 1, 0, "TestType");

    engine.load(QUrl(QLatin1String("qrc:/main.qml")));

    return app.exec();
}
