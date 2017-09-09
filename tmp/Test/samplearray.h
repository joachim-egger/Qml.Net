#ifndef SAMPLEARRAY_H
#define SAMPLEARRAY_H

#include <private/qv4object_p.h>

namespace QV4 {

namespace Heap {

struct SampleArrayObject : Object {
    enum {
        LengthPropertyIndex = 0
    };

    void init() {
        Object::init();
        commonInit();
    }

    void init(const QStringList &list);

private:
    void commonInit()
    { *propertyData(LengthPropertyIndex) = Primitive::fromInt32(0); }
};

} // Heap

struct SampleArrayObject: Object {
    V4_OBJECT2(SampleArrayObject, Object)
    Q_MANAGED_TYPE(ArrayObject)
    V4_INTERNALCLASS(ArrayObject)
    //V4_PROTOTYPE(arrayPrototype)
    //static QV4::Object *defaultPrototype(QV4::ExecutionEngine *e) {
    //    return e->arrayPrototype();
    //}
};

} // QV4

#endif // SAMPLEARRAY_H
