#ifndef TESTTYPE_H
#define TESTTYPE_H

#include <QObject>
#include <QVariantList>
#include <qqmllist.h>

class QQmlV4Function;

class TestType : public QObject
{
    Q_OBJECT
public:
    explicit TestType(QObject *parent = nullptr);
    Q_INVOKABLE QVariantList getList();
    Q_INVOKABLE void testMethod(QQmlV4Function* function);
signals:

public slots:
private:
    QVariantList list;
};

#endif // TESTTYPE_H
