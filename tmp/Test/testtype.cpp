#include "testtype.h"
#include "private/qv4object_p.h"
#include "private/qv8engine_p.h"
#include "private/qv4scopedvalue_p.h"
#include "private/qv4mm_p.h"
#include "samplearray.h"

TestType::TestType(QObject *parent) : QObject(parent) {

}

QVariantList TestType::getList() {
    list.append(QVariant::fromValue(QString("TEST")));
    return list;
}

void TestType::testMethod(QQmlV4Function* function) {

    QV4::Scope scope(function->v4engine());

    QV4::Scoped<QV4::SampleArrayObject> object(scope, function->v4engine()->memoryManager->allocObject<QV4::SampleArrayObject>());
    function->setReturnValue(object.asReturnedValue());
    //if (count) {
    //    if (count < 0x1000)
    //        object->arrayReserve(count);
    //    object->setArrayLengthUnchecked(count);
    //}
    //return object->d();

    //QV4::SampleArrayObject::static_vtbl

    //QV4::Scoped<QV4::SampleArrayObject> array(scope, function->v4engine()->newArrayObject());
    //function->setReturnValue(array.asReturnedValue());
    //function->setReturnValue(array.asReturnedValue());
    //if (length < 0x1000)
    //    array->arrayReserve(length);
    //array->setArrayLengthUnchecked(length);
    //return QJSValue(d->m_v4Engine, array.asReturnedValue());
    //function->setReturnValue(QV4::Encode(4));
}
