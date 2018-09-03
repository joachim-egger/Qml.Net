#include <Hosting/RuntimeConfig.h>
#include <QFile>
#include <QTextStream>
#include <QJsonDocument>
#include <QJsonObject>

RuntimeConfig::RuntimeConfig(QJsonObject jsonObject) :
    jsonObject(jsonObject)
{

}

QSharedPointer<QPair<QString, QVersionNumber>> RuntimeConfig::getFrameworkAndVersion()
{

}

QSharedPointer<RuntimeConfig> RuntimeConfig::merge(QSharedPointer<RuntimeConfig> runtimeConfig)
{
    // TODO
    Q_UNUSED(runtimeConfig);
    return QSharedPointer<RuntimeConfig>(new RuntimeConfig(this->jsonObject));
}

QSharedPointer<RuntimeConfig> RuntimeConfig::fromFile(QString file)
{
    QFile fileObj(file);

    if(!fileObj.open(QIODevice::ReadOnly)) {
        qCritical("failed to open %s", qPrintable(file));
        return nullptr;
    }

    QTextStream fileText(&fileObj);
    QString jsonString = fileText.readAll();
    fileObj.close();
    QByteArray json_bytes = jsonString.toLocal8Bit();

    auto jsonDoc = QJsonDocument::fromJson(json_bytes);

    if (jsonDoc.isNull()) {
        qCritical("failed to create json documented from file %s", qPrintable(file));
        return nullptr;
    }

    if (!jsonDoc.isObject()) {
        qCritical("not a json object in file %s", qPrintable(file));
        return nullptr;
    }

    QJsonObject jsonObj = jsonDoc.object();

    if (jsonObj.isEmpty()) {
        qCritical("json object is empty for %s", qPrintable(file));
        return nullptr;
    }

    return QSharedPointer<RuntimeConfig>(new RuntimeConfig(jsonObj));
}
