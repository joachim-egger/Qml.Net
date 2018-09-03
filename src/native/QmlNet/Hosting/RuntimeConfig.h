#ifndef RUNTIMECONFIG_H
#define RUNTIMECONFIG_H

#include <QSharedPointer>
#include <QVersionNumber>
#include <QJsonObject>

class RuntimeConfig
{
public:
    RuntimeConfig(QJsonObject jsonObject);
    QSharedPointer<QPair<QString, QVersionNumber>> getFrameworkAndVersion();
    QSharedPointer<RuntimeConfig> merge(QSharedPointer<RuntimeConfig> runtimeConfig);
    static QSharedPointer<RuntimeConfig> fromFile(QString file);
private:
    QJsonObject jsonObject;
};

#endif // RUNTIMECONFIG_H
