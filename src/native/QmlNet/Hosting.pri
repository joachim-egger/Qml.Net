INCLUDEPATH += $$PWD

INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost
INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost/common
INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost/cli
INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost/cli/json/casablanca/include
INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost/cli/fxr

SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/host_startup_info.cpp

HEADERS += $$PWD/Hosting/coreclrhost.h \
    $$PWD/Hosting/coreruncommon.h \
    $$PWD/Hosting/CoreHost.h

SOURCES += \
    $$PWD/Hosting/coreruncommon.cpp \
    $$PWD/Hosting/CoreHost.cpp
