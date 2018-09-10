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
#include "libhost.h"
#include "fx_muxer.h"

CoreHost::CoreHost()
{

}

void CoreHost::test()
{
    std::vector<const char*> arg2v;
    arg2v.push_back("/usr/local/share/dotnet/dotnet");
    arg2v.push_back("exec");
    arg2v.push_back("/Users/pknopf/temp/TestWeb/bin/Debug/netcoreapp2.1/TestWeb.dll");
    int arg2c = arg2v.size();

    //host_startup_info_t startup_info;
    //startup_info.parse(arg2c, &arg2v[0]);

    //host_mode_t mode = detect_operating_mode(&startup_info);


    int new_argoff;
        pal::string_t app_candidate;
        opt_map_t opts;
        int result;
    hostpolicy_init_t g_init;
    g_init.host_info.parse(arg2c, &arg2v[0]);
    //g_init.host_mode = apphost;
    arguments_t args;
    parse_arguments(g_init, arg2c - 1, &arg2v[1], &args);
    //parse_arguments()


    qputenv("DOTNET_ROOT", "/usr/local/share/dotnet");



        #if 1

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
    //int result = main(argc, &argv[0]);

#endif
}

void CoreHost::test2(int argc, const char* argv[])
{
    trace::setup();

    host_startup_info_t startup_info;
    startup_info.parse(argc, argv);

    fx_muxer_t muxer;
    muxer.execute(pal::string_t(), argc, argv, startup_info, nullptr, 0, nullptr);
}
