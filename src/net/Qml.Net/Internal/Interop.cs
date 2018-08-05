using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Qml.Net.Internal.Qml;
using Qml.Net.Internal.Types;

namespace Qml.Net.Internal
{
    internal static class Interop
    {
        static readonly CallbacksImpl DefaultCallbacks = new CallbacksImpl(new DefaultCallbacks());
        
        static Interop()
        {
            Callbacks = PInvoke.CallbacksIterop.Get();
            NetTypeInfo = PInvoke.NetTypeInfoInterop.Get();
            NetMethodInfo = PInvoke.NetMethodInfoInterop.Get();
            NetPropertyInfo = PInvoke.NetPropertyInfoInterop.Get();
            NetTypeManager = PInvoke.NetTypeManagerInterop.Get();
            QGuiApplication = PInvoke.QGuiApplicationInterop.Get();
            QQmlApplicationEngine = PInvoke.QQmlApplicationEngine.Get();
            NetVariant = PInvoke.NetVariantInterop.Get();
            NetReference = PInvoke.NetReferenceInterop.Get();
            NetVariantList = PInvoke.NetVariantListInterop.Get();
            NetTestHelper = PInvoke.NetTestHelperInterop.Get();
            NetSignalInfo = PInvoke.NetSignalInfoInterop.Get();
            QResource = PInvoke.QResourceInterop.Get();
            NetDelegate = PInvoke.NetDelegateInterop.Get();
            NetJsValue = PInvoke.NetJsValueInterop.Get();
            QQuickStyle = PInvoke.QQuickStyleInterop.Get();
            QtInterop = PInvoke.QtInterop.Get();
            Utilities = PInvoke.Utilities.Get();
            
            string pluginsDirectory = null;
            string qmlDirectory = null;

            string libPath = null;
            
            // If we couldn't manually load the library, let's try to let the .NET
            // runtime find it.
            if (string.IsNullOrEmpty(libPath))
            {
                try
                {
                    Utilities.GetVersion();
                    using (var process = Process.GetCurrentProcess())
                    {
                        foreach (ProcessModule module in process.Modules)
                        {
                            Console.WriteLine(module.FileName);
                        }
                    }
                }
                // ReSharper disable EmptyGeneralCatchClause
                catch (Exception) {}
                // ReSharper restore EmptyGeneralCatchClause
            }
            
            if(!string.IsNullOrEmpty(pluginsDirectory))
            {
                Qt.PutEnv("QT_PLUGIN_PATH", pluginsDirectory);
            }
            if(!string.IsNullOrEmpty(qmlDirectory))
            {
                Qt.PutEnv("QML2_IMPORT_PATH", qmlDirectory);
            }

            var cb = DefaultCallbacks.Callbacks();
            Callbacks.RegisterCallbacks(ref cb);
        }

        public static ICallbacksIterop Callbacks { get; }

        public static INetTypeInfoInterop NetTypeInfo { get; }
        
        public static INetMethodInfoInterop NetMethodInfo { get; }
        
        public static INetPropertyInfoInterop NetPropertyInfo { get; }
        
        public static INetTypeManagerInterop NetTypeManager { get; }
        
        public static IQGuiApplicationInterop QGuiApplication { get; }
        
        public static IQQmlApplicationEngine QQmlApplicationEngine { get; }
        
        public static INetVariantInterop NetVariant { get; }
        
        public static INetReferenceInterop NetReference { get; }
        
        public static INetVariantListInterop NetVariantList { get; }
        
        public static INetTestHelperInterop NetTestHelper { get; }
        
        public static INetSignalInfoInterop NetSignalInfo { get; }
        
        public static IQResourceInterop QResource { get; }
        
        public static INetDelegateInterop NetDelegate { get; }
        
        public static INetJsValueInterop NetJsValue { get; }
        
        public static IQQuickStyleInterop QQuickStyle { get; }

        public static IQtInterop QtInterop { get; }
        
        public static IUtilities Utilities { get; }
    }
}