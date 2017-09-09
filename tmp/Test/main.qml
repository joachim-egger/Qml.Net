import QtQuick 2.7
import QtQuick.Controls 2.0
import QtQuick.Layouts 1.0
import test 1.0

ApplicationWindow {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    TestType {
        id: test
    }

    ListModel {
        id: fruitModel

        ListElement {
            name: "Apple"
            cost: 2.45
        }
        ListElement {
            name: "Orange"
            cost: 3.25
        }
        ListElement {
            name: "Banana"
            cost: 1.95
        }
    }

    Item {
        Component.onCompleted: function() {
            console.log(test.getList())
            console.log(Array.isArray(test.getList()))
            var rr = test.testMethod();
            console.log(Array.isArray(rr))
            rr.push("TEST")
            console.log(rr)
            console.log(test.testMethod())
        }
    }
}
