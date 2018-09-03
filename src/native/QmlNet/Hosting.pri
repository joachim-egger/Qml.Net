INCLUDEPATH += $$PWD

HEADERS += $$PWD/Hosting/coreclrhost.h \
    $$PWD/Hosting/coreruncommon.h \
    $$PWD/Hosting/CoreHost.h \
    $$PWD/Hosting/RuntimeConfig.h

SOURCES += \
    $$PWD/Hosting/coreruncommon.cpp \
    $$PWD/Hosting/CoreHost.cpp \
    $$PWD/Hosting/RuntimeConfig.cpp
