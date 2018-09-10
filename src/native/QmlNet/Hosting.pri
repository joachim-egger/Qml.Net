INCLUDEPATH += $$PWD

DEFINES += _TARGET_AMD64_
DEFINES += HOST_FXR_PKG_VER=1

DEFINES += "REPO_COMMIT_HASH=\"\\\"Qt 5.10\\\"\""
DEFINES += "HOST_POLICY_PKG_NAME=\"\\\"Qt 5.10\\\"\""
DEFINES += "HOST_POLICY_PKG_REL_DIR=\"\\\"Qt 5.10\\\"\""
#    add_definitions(-DHOST_POLICY_PKG_NAME="runtime.${CLI_CMAKE_PKG_RID}.Microsoft.NETCore.DotNetHostPolicy")
#    add_definitions(-DHOST_POLICY_PKG_REL_DIR="runtimes/${CLI_CMAKE_PKG_RID}/native")

SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/json/casablanca/src/json/json.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/json/casablanca/src/json/json_parsing.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/json/casablanca/src/json/json_serialization.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/json/casablanca/src/utilities/asyncrt_utils.cpp

INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost
INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost/common
INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost/cli
INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost/cli/json/casablanca/include
INCLUDEPATH += $$PWD/../../../submodules/core-setup/src/corehost/cli/fxr

SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/common/utils.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/common/palunix.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/common/trace.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/host_startup_info.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/args.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/deps_format.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/runtime_config.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/libhost.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/version.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/fx_definition.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/fxr/hostfxr.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/fxr/fx_muxer.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/fxr/framework_info.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/fxr/fx_ver.cpp
SOURCES += $$PWD/../../../submodules/core-setup/src/corehost/cli/fxr/sdk_info.cpp

HEADERS += $$PWD/Hosting/coreclrhost.h \
    $$PWD/Hosting/coreruncommon.h \
    $$PWD/Hosting/CoreHost.h

SOURCES += \
    $$PWD/Hosting/coreruncommon.cpp \
    $$PWD/Hosting/CoreHost.cpp
