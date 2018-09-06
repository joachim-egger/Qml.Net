#include <Hosting/CoreHost.h>
#include <Hosting/coreclrhost.h>
#include <QFileInfo>
#include <QDir>
#include <dlfcn.h>
#include <QThread>
#include <QDebug>
#include <iostream>
#include "deps_resolver.h"
#include "args.h"


CoreHost::CoreHost()
{

}

void CoreHost::test()
{
    std::vector<const char*> argv;
    argv.push_back("/usr/local/share/dotnet/dotnet");
    argv.push_back("exec");
    argv.push_back("/Users/pknopf/temp/TestWeb/bin/Debug/netcoreapp2.1/TestWeb.dll");
    int argc = argv.size();

    hostpolicy_init_t g_init;
    g_init.host_info.parse(argc, &argv[0]);
    //parse_arguments()
//    qputenv("DOTNET_ROOT", "/usr/local/share/dotnet");

//    QString fxrPath = "/usr/local/share/dotnet/host/fxr/2.1.3/libhostfxr.dylib";
//    void* dll = dlopen(fxrPath.toLocal8Bit().constData(), RTLD_NOW | RTLD_LOCAL);
//    hostfxr_get_native_search_directories_ptr getSearchDirs = reinterpret_cast<hostfxr_get_native_search_directories_ptr>(dlsym(dll, "hostfxr_get_clr_properties"));

//    std::vector<const char*> argv;
//    argv.push_back("/usr/local/share/dotnet/dotnet");
//    argv.push_back("exec");
//    argv.push_back("/Users/pknopf/temp/TestWeb/bin/Debug/netcoreapp2.1/TestWeb.dll");
//    int argc = argv.size();
//    int requiredBufferSize = 0;
//    char buffer[2343434];
//    int result = getSearchDirs(argc, &argv[0], &buffer[0], 2343434, &requiredBufferSize);

//    QString t(&buffer[0]);
//    std::cout << &buffer[0] << std::endl;
//    qCritical("Got: %s", &buffer[0]);

        #ifdef TEST

    qputenv("DOTNET_ROOT", "/usr/local/share/dotnet");

    QString fxrPath = "/usr/local/share/dotnet/host/fxr/2.1.3/libhostfxr.dylib";
    void* dll = dlopen(fxrPath.toLocal8Bit().constData(), RTLD_NOW | RTLD_LOCAL);
    hostfxr_main_ptr main = reinterpret_cast<hostfxr_main_ptr>(dlsym(dll, "hostfxr_main"));

    std::vector<const char*> argv;
    argv.push_back("/usr/local/share/dotnet/dotnet");
    //argv.push_back("--depsfile");
    //argv.push_back("/Users/pknopf/git/net-core-qml/src/net/Qml.Net.Sandbox/bin/Debug/netcoreapp2.1/Qml.Net.Sandbox.deps.json");
    //argv.push_back("--runtimeconfig");
    //argv.push_back("/Users/pknopf/git/net-core-qml/src/net/Qml.Net.Sandbox/bin/Debug/netcoreapp2.1/Qml.Net.Sandbox.runtimeconfig.json");
    //--depsfile <path>                   Path to <application>.deps.json file
    //  --runtimeconfig <path>
    argv.push_back("exec");
    //argv.push_back("--depsfile");
    //argv.push_back("/Users/pknopf/git/net-core-qml/src/net/Qml.Net.Sandbox/bin/Debug/netcoreapp2.1/Qml.Net.Sandbox.deps.json");
    //argv.push_back("--runtimeconfig");
    //argv.push_back("/Users/pknopf/git/net-core-qml/src/net/Qml.Net.Sandbox/bin/Debug/netcoreapp2.1/Qml.Net.Sandbox.runtimeconfig.json");
    argv.push_back("/Users/pknopf/git/net-core-qml/src/net/Qml.Net.Sandbox/bin/Debug/netcoreapp2.1/Qml.Net.Sandbox.dll");
    int argc = argv.size();
    int result = main(argc, &argv[0]);

#endif
}
