using System.Runtime.InteropServices;
using Qml.Net.Internal.Qml;
using Qml.Net.Internal.Types;
// ReSharper disable RedundantNameQualifier
// ReSharper disable UnusedMember.Global
namespace Qml.Net.Internal.PInvoke {
internal class QGuiApplicationInteropDefault : global::Qml.Net.IQGuiApplicationInterop {
[DllImport("QmlNet", EntryPoint = "qguiapplication_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr args);
public global::System.IntPtr Create(global::System.IntPtr args) { return Create_extern(args); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_destroy")]
static extern void Destroy_extern(global::System.IntPtr app);
public void Destroy(global::System.IntPtr app) { Destroy_extern(app); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_exec")]
static extern global::System.Int32 Exec_extern(global::System.IntPtr app);
public global::System.Int32 Exec(global::System.IntPtr app) { return Exec_extern(app); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_addTriggerCallback")]
static extern void AddTriggerCallback_extern(global::System.IntPtr app, global::System.IntPtr callback);
public void AddTriggerCallback(global::System.IntPtr app, global::System.IntPtr callback) { AddTriggerCallback_extern(app, callback); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_requestTrigger")]
static extern void RequestTrigger_extern(global::System.IntPtr app);
public void RequestTrigger(global::System.IntPtr app) { RequestTrigger_extern(app); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_exit")]
static extern void Exit_extern(global::System.IntPtr app, global::System.Int32 returnCode);
public void Exit(global::System.IntPtr app, global::System.Int32 returnCode) { Exit_extern(app, returnCode); }
}
internal class QGuiApplicationInteropOSX : global::Qml.Net.IQGuiApplicationInterop {
[DllImport("QmlNet", EntryPoint = "qguiapplication_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr args);
public global::System.IntPtr Create(global::System.IntPtr args) { return Create_extern(args); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_destroy")]
static extern void Destroy_extern(global::System.IntPtr app);
public void Destroy(global::System.IntPtr app) { Destroy_extern(app); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_exec")]
static extern global::System.Int32 Exec_extern(global::System.IntPtr app);
public global::System.Int32 Exec(global::System.IntPtr app) { return Exec_extern(app); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_addTriggerCallback")]
static extern void AddTriggerCallback_extern(global::System.IntPtr app, global::System.IntPtr callback);
public void AddTriggerCallback(global::System.IntPtr app, global::System.IntPtr callback) { AddTriggerCallback_extern(app, callback); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_requestTrigger")]
static extern void RequestTrigger_extern(global::System.IntPtr app);
public void RequestTrigger(global::System.IntPtr app) { RequestTrigger_extern(app); }
[DllImport("QmlNet", EntryPoint = "qguiapplication_exit")]
static extern void Exit_extern(global::System.IntPtr app, global::System.Int32 returnCode);
public void Exit(global::System.IntPtr app, global::System.Int32 returnCode) { Exit_extern(app, returnCode); }
}

                    internal class QGuiApplicationInterop
                    {
                        public static IQGuiApplicationInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new QGuiApplicationInteropOSX();
                            }
                            return new QGuiApplicationInteropDefault();
                        }
                    }
                    
internal class QQmlApplicationEngineDefault : global::Qml.Net.IQQmlApplicationEngine {
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_create")]
static extern global::System.IntPtr Create_extern();
public global::System.IntPtr Create() { return Create_extern(); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_destroy")]
static extern void Destroy_extern(global::System.IntPtr engine);
public void Destroy(global::System.IntPtr engine) { Destroy_extern(engine); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_load")]
static extern global::System.Int32 Load_extern(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path);
public global::System.Int32 Load(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path) { return Load_extern(engine, path); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_loadData")]
static extern global::System.Int32 LoadData_extern(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path);
public global::System.Int32 LoadData(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path) { return LoadData_extern(engine, path); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_registerType")]
static extern global::System.Int32 RegisterType_extern(global::System.IntPtr type, [MarshalAs(UnmanagedType.LPWStr)]global::System.String uri, global::System.Int32 versionMajor, global::System.Int32 versionMinor, [MarshalAs(UnmanagedType.LPWStr)]global::System.String qmlName);
public global::System.Int32 RegisterType(global::System.IntPtr type, [MarshalAs(UnmanagedType.LPWStr)]global::System.String uri, global::System.Int32 versionMajor, global::System.Int32 versionMinor, [MarshalAs(UnmanagedType.LPWStr)]global::System.String qmlName) { return RegisterType_extern(type, uri, versionMajor, versionMinor, qmlName); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_addImportPath")]
static extern void AddImportPath_extern(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path);
public void AddImportPath(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path) { AddImportPath_extern(engine, path); }
}
internal class QQmlApplicationEngineOSX : global::Qml.Net.IQQmlApplicationEngine {
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_create")]
static extern global::System.IntPtr Create_extern();
public global::System.IntPtr Create() { return Create_extern(); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_destroy")]
static extern void Destroy_extern(global::System.IntPtr engine);
public void Destroy(global::System.IntPtr engine) { Destroy_extern(engine); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_load")]
static extern global::System.Int32 Load_extern(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path);
public global::System.Int32 Load(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path) { return Load_extern(engine, path); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_loadData")]
static extern global::System.Int32 LoadData_extern(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path);
public global::System.Int32 LoadData(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path) { return LoadData_extern(engine, path); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_registerType")]
static extern global::System.Int32 RegisterType_extern(global::System.IntPtr type, [MarshalAs(UnmanagedType.LPWStr)]global::System.String uri, global::System.Int32 versionMajor, global::System.Int32 versionMinor, [MarshalAs(UnmanagedType.LPWStr)]global::System.String qmlName);
public global::System.Int32 RegisterType(global::System.IntPtr type, [MarshalAs(UnmanagedType.LPWStr)]global::System.String uri, global::System.Int32 versionMajor, global::System.Int32 versionMinor, [MarshalAs(UnmanagedType.LPWStr)]global::System.String qmlName) { return RegisterType_extern(type, uri, versionMajor, versionMinor, qmlName); }
[DllImport("QmlNet", EntryPoint = "qqmlapplicationengine_addImportPath")]
static extern void AddImportPath_extern(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path);
public void AddImportPath(global::System.IntPtr engine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String path) { AddImportPath_extern(engine, path); }
}

                    internal class QQmlApplicationEngine
                    {
                        public static IQQmlApplicationEngine Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new QQmlApplicationEngineOSX();
                            }
                            return new QQmlApplicationEngineDefault();
                        }
                    }
                    
internal class QQuickStyleInteropDefault : global::Qml.Net.IQQuickStyleInterop {
[DllImport("QmlNet", EntryPoint = "qquickstyle_setStyle")]
static extern void SetStyle_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String style);
public void SetStyle([MarshalAs(UnmanagedType.LPWStr)]global::System.String style) { SetStyle_extern(style); }
}
internal class QQuickStyleInteropOSX : global::Qml.Net.IQQuickStyleInterop {
[DllImport("QmlNet", EntryPoint = "qquickstyle_setStyle")]
static extern void SetStyle_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String style);
public void SetStyle([MarshalAs(UnmanagedType.LPWStr)]global::System.String style) { SetStyle_extern(style); }
}

                    internal class QQuickStyleInterop
                    {
                        public static IQQuickStyleInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new QQuickStyleInteropOSX();
                            }
                            return new QQuickStyleInteropDefault();
                        }
                    }
                    
internal class QResourceInteropDefault : global::Qml.Net.IQResourceInterop {
[DllImport("QmlNet", EntryPoint = "qresource_registerResource")]
static extern global::System.Boolean RegisterResource_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String rccFileName, [MarshalAs(UnmanagedType.LPWStr)]global::System.String resourceRoot);
public global::System.Boolean RegisterResource([MarshalAs(UnmanagedType.LPWStr)]global::System.String rccFileName, [MarshalAs(UnmanagedType.LPWStr)]global::System.String resourceRoot) { return RegisterResource_extern(rccFileName, resourceRoot); }
}
internal class QResourceInteropOSX : global::Qml.Net.IQResourceInterop {
[DllImport("QmlNet", EntryPoint = "qresource_registerResource")]
static extern global::System.Boolean RegisterResource_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String rccFileName, [MarshalAs(UnmanagedType.LPWStr)]global::System.String resourceRoot);
public global::System.Boolean RegisterResource([MarshalAs(UnmanagedType.LPWStr)]global::System.String rccFileName, [MarshalAs(UnmanagedType.LPWStr)]global::System.String resourceRoot) { return RegisterResource_extern(rccFileName, resourceRoot); }
}

                    internal class QResourceInterop
                    {
                        public static IQResourceInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new QResourceInteropOSX();
                            }
                            return new QResourceInteropDefault();
                        }
                    }
                    
internal class QtInteropDefault : global::Qml.Net.IQtInterop {
[DllImport("QmlNet", EntryPoint = "qt_putenv")]
static extern global::System.Boolean PutEnv_extern([MarshalAs(UnmanagedType.LPStr)]global::System.String name, [MarshalAs(UnmanagedType.LPStr)]global::System.String value);
public global::System.Boolean PutEnv([MarshalAs(UnmanagedType.LPStr)]global::System.String name, [MarshalAs(UnmanagedType.LPStr)]global::System.String value) { return PutEnv_extern(name, value); }
[DllImport("QmlNet", EntryPoint = "qt_getenv")]
static extern global::System.IntPtr GetEnv_extern(global::System.String name);
public global::System.IntPtr GetEnv(global::System.String name) { return GetEnv_extern(name); }
}
internal class QtInteropOSX : global::Qml.Net.IQtInterop {
[DllImport("QmlNet", EntryPoint = "qt_putenv")]
static extern global::System.Boolean PutEnv_extern([MarshalAs(UnmanagedType.LPStr)]global::System.String name, [MarshalAs(UnmanagedType.LPStr)]global::System.String value);
public global::System.Boolean PutEnv([MarshalAs(UnmanagedType.LPStr)]global::System.String name, [MarshalAs(UnmanagedType.LPStr)]global::System.String value) { return PutEnv_extern(name, value); }
[DllImport("QmlNet", EntryPoint = "qt_getenv")]
static extern global::System.IntPtr GetEnv_extern(global::System.String name);
public global::System.IntPtr GetEnv(global::System.String name) { return GetEnv_extern(name); }
}

                    internal class QtInterop
                    {
                        public static IQtInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new QtInteropOSX();
                            }
                            return new QtInteropDefault();
                        }
                    }
                    
internal class UtilitiesDefault : global::Qml.Net.IUtilities {
[DllImport("QmlNet", EntryPoint = "freeString")]
static extern void FreeString_extern(global::System.IntPtr container);
public void FreeString(global::System.IntPtr container) { FreeString_extern(container); }
[DllImport("QmlNet", EntryPoint = "qml_net_getVersion")]
static extern global::System.Int64 GetVersion_extern();
public global::System.Int64 GetVersion() { return GetVersion_extern(); }
}
internal class UtilitiesOSX : global::Qml.Net.IUtilities {
[DllImport("QmlNet", EntryPoint = "freeString")]
static extern void FreeString_extern(global::System.IntPtr container);
public void FreeString(global::System.IntPtr container) { FreeString_extern(container); }
[DllImport("QmlNet", EntryPoint = "qml_net_getVersion")]
static extern global::System.Int64 GetVersion_extern();
public global::System.Int64 GetVersion() { return GetVersion_extern(); }
}

                    internal class Utilities
                    {
                        public static IUtilities Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new UtilitiesOSX();
                            }
                            return new UtilitiesDefault();
                        }
                    }
                    
internal class CallbacksIteropDefault : global::Qml.Net.Internal.Types.ICallbacksIterop {
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_registerCallbacks")]
static extern void RegisterCallbacks_extern(ref global::Qml.Net.Internal.Types.Callbacks callbacks);
public void RegisterCallbacks(ref global::Qml.Net.Internal.Types.Callbacks callbacks) { RegisterCallbacks_extern(ref callbacks); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_isTypeValid")]
static extern global::System.Boolean IsTypeValid_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String typeName);
public global::System.Boolean IsTypeValid([MarshalAs(UnmanagedType.LPWStr)]global::System.String typeName) { return IsTypeValid_extern(typeName); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_releaseNetReferenceGCHandle")]
static extern void ReleaseNetReference_extern(global::System.UInt64 objectId);
public void ReleaseNetReference(global::System.UInt64 objectId) { ReleaseNetReference_extern(objectId); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_releaseNetDelegateGCHandle")]
static extern void ReleaseNetDelegateGCHandle_extern(global::System.IntPtr handle);
public void ReleaseNetDelegateGCHandle(global::System.IntPtr handle) { ReleaseNetDelegateGCHandle_extern(handle); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_instantiateType")]
static extern global::System.IntPtr InstantiateType_extern(global::System.IntPtr type);
public global::System.IntPtr InstantiateType(global::System.IntPtr type) { return InstantiateType_extern(type); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_readProperty")]
static extern void ReadProperty_extern(global::System.IntPtr property, global::System.IntPtr target, global::System.IntPtr result);
public void ReadProperty(global::System.IntPtr property, global::System.IntPtr target, global::System.IntPtr result) { ReadProperty_extern(property, target, result); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_writeProperty")]
static extern void WriteProperty_extern(global::System.IntPtr property, global::System.IntPtr target, global::System.IntPtr value);
public void WriteProperty(global::System.IntPtr property, global::System.IntPtr target, global::System.IntPtr value) { WriteProperty_extern(property, target, value); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_invokeMethod")]
static extern void InvokeMethod_extern(global::System.IntPtr method, global::System.IntPtr target, global::System.IntPtr variants, global::System.IntPtr result);
public void InvokeMethod(global::System.IntPtr method, global::System.IntPtr target, global::System.IntPtr variants, global::System.IntPtr result) { InvokeMethod_extern(method, target, variants, result); }
}
internal class CallbacksIteropOSX : global::Qml.Net.Internal.Types.ICallbacksIterop {
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_registerCallbacks")]
static extern void RegisterCallbacks_extern(ref global::Qml.Net.Internal.Types.Callbacks callbacks);
public void RegisterCallbacks(ref global::Qml.Net.Internal.Types.Callbacks callbacks) { RegisterCallbacks_extern(ref callbacks); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_isTypeValid")]
static extern global::System.Boolean IsTypeValid_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String typeName);
public global::System.Boolean IsTypeValid([MarshalAs(UnmanagedType.LPWStr)]global::System.String typeName) { return IsTypeValid_extern(typeName); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_releaseNetReferenceGCHandle")]
static extern void ReleaseNetReference_extern(global::System.UInt64 objectId);
public void ReleaseNetReference(global::System.UInt64 objectId) { ReleaseNetReference_extern(objectId); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_releaseNetDelegateGCHandle")]
static extern void ReleaseNetDelegateGCHandle_extern(global::System.IntPtr handle);
public void ReleaseNetDelegateGCHandle(global::System.IntPtr handle) { ReleaseNetDelegateGCHandle_extern(handle); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_instantiateType")]
static extern global::System.IntPtr InstantiateType_extern(global::System.IntPtr type);
public global::System.IntPtr InstantiateType(global::System.IntPtr type) { return InstantiateType_extern(type); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_readProperty")]
static extern void ReadProperty_extern(global::System.IntPtr property, global::System.IntPtr target, global::System.IntPtr result);
public void ReadProperty(global::System.IntPtr property, global::System.IntPtr target, global::System.IntPtr result) { ReadProperty_extern(property, target, result); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_writeProperty")]
static extern void WriteProperty_extern(global::System.IntPtr property, global::System.IntPtr target, global::System.IntPtr value);
public void WriteProperty(global::System.IntPtr property, global::System.IntPtr target, global::System.IntPtr value) { WriteProperty_extern(property, target, value); }
[DllImport("QmlNet", EntryPoint = "type_info_callbacks_invokeMethod")]
static extern void InvokeMethod_extern(global::System.IntPtr method, global::System.IntPtr target, global::System.IntPtr variants, global::System.IntPtr result);
public void InvokeMethod(global::System.IntPtr method, global::System.IntPtr target, global::System.IntPtr variants, global::System.IntPtr result) { InvokeMethod_extern(method, target, variants, result); }
}

                    internal class CallbacksIterop
                    {
                        public static ICallbacksIterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new CallbacksIteropOSX();
                            }
                            return new CallbacksIteropDefault();
                        }
                    }
                    
internal class NetDelegateInteropDefault : global::Qml.Net.Internal.Types.INetDelegateInterop {
[DllImport("QmlNet", EntryPoint = "delegate_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr handle);
public global::System.IntPtr Create(global::System.IntPtr handle) { return Create_extern(handle); }
[DllImport("QmlNet", EntryPoint = "delegate_destroy")]
static extern void Destroy_extern(global::System.IntPtr del);
public void Destroy(global::System.IntPtr del) { Destroy_extern(del); }
[DllImport("QmlNet", EntryPoint = "delegate_getHandle")]
static extern global::System.IntPtr GetHandle_extern(global::System.IntPtr del);
public global::System.IntPtr GetHandle(global::System.IntPtr del) { return GetHandle_extern(del); }
}
internal class NetDelegateInteropOSX : global::Qml.Net.Internal.Types.INetDelegateInterop {
[DllImport("QmlNet", EntryPoint = "delegate_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr handle);
public global::System.IntPtr Create(global::System.IntPtr handle) { return Create_extern(handle); }
[DllImport("QmlNet", EntryPoint = "delegate_destroy")]
static extern void Destroy_extern(global::System.IntPtr del);
public void Destroy(global::System.IntPtr del) { Destroy_extern(del); }
[DllImport("QmlNet", EntryPoint = "delegate_getHandle")]
static extern global::System.IntPtr GetHandle_extern(global::System.IntPtr del);
public global::System.IntPtr GetHandle(global::System.IntPtr del) { return GetHandle_extern(del); }
}

                    internal class NetDelegateInterop
                    {
                        public static INetDelegateInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetDelegateInteropOSX();
                            }
                            return new NetDelegateInteropDefault();
                        }
                    }
                    
internal class NetMethodInfoInteropDefault : global::Qml.Net.Internal.Types.INetMethodInfoInterop {
[DllImport("QmlNet", EntryPoint = "method_info_parameter_destroy")]
static extern void DestroyParameter_extern(global::System.IntPtr parameter);
public void DestroyParameter(global::System.IntPtr parameter) { DestroyParameter_extern(parameter); }
[DllImport("QmlNet", EntryPoint = "method_info_parameter_getName")]
static extern global::System.IntPtr GetParameterName_extern(global::System.IntPtr methodParameter);
public global::System.IntPtr GetParameterName(global::System.IntPtr methodParameter) { return GetParameterName_extern(methodParameter); }
[DllImport("QmlNet", EntryPoint = "method_info_parameter_getType")]
static extern global::System.IntPtr GetParameterType_extern(global::System.IntPtr methodParameter);
public global::System.IntPtr GetParameterType(global::System.IntPtr methodParameter) { return GetParameterType_extern(methodParameter); }
[DllImport("QmlNet", EntryPoint = "method_info_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr parentTypeInfo, [MarshalAs(UnmanagedType.LPWStr)]global::System.String methodName, global::System.IntPtr returnTypeInfo);
public global::System.IntPtr Create(global::System.IntPtr parentTypeInfo, [MarshalAs(UnmanagedType.LPWStr)]global::System.String methodName, global::System.IntPtr returnTypeInfo) { return Create_extern(parentTypeInfo, methodName, returnTypeInfo); }
[DllImport("QmlNet", EntryPoint = "method_info_destroy")]
static extern void Destroy_extern(global::System.IntPtr methodInfo);
public void Destroy(global::System.IntPtr methodInfo) { Destroy_extern(methodInfo); }
[DllImport("QmlNet", EntryPoint = "method_info_getMethodName")]
static extern global::System.IntPtr GetMethodName_extern(global::System.IntPtr method);
public global::System.IntPtr GetMethodName(global::System.IntPtr method) { return GetMethodName_extern(method); }
[DllImport("QmlNet", EntryPoint = "method_info_getReturnType")]
static extern global::System.IntPtr GetReturnType_extern(global::System.IntPtr method);
public global::System.IntPtr GetReturnType(global::System.IntPtr method) { return GetReturnType_extern(method); }
[DllImport("QmlNet", EntryPoint = "method_info_addParameter")]
static extern void AddParameter_extern(global::System.IntPtr method, [MarshalAs(UnmanagedType.LPWStr)]global::System.String name, global::System.IntPtr type);
public void AddParameter(global::System.IntPtr method, [MarshalAs(UnmanagedType.LPWStr)]global::System.String name, global::System.IntPtr type) { AddParameter_extern(method, name, type); }
[DllImport("QmlNet", EntryPoint = "method_info_getParameterCount")]
static extern global::System.Int32 GetParameterCount_extern(global::System.IntPtr method);
public global::System.Int32 GetParameterCount(global::System.IntPtr method) { return GetParameterCount_extern(method); }
[DllImport("QmlNet", EntryPoint = "method_info_getParameter")]
static extern global::System.IntPtr GetParameter_extern(global::System.IntPtr method, global::System.Int32 index);
public global::System.IntPtr GetParameter(global::System.IntPtr method, global::System.Int32 index) { return GetParameter_extern(method, index); }
}
internal class NetMethodInfoInteropOSX : global::Qml.Net.Internal.Types.INetMethodInfoInterop {
[DllImport("QmlNet", EntryPoint = "method_info_parameter_destroy")]
static extern void DestroyParameter_extern(global::System.IntPtr parameter);
public void DestroyParameter(global::System.IntPtr parameter) { DestroyParameter_extern(parameter); }
[DllImport("QmlNet", EntryPoint = "method_info_parameter_getName")]
static extern global::System.IntPtr GetParameterName_extern(global::System.IntPtr methodParameter);
public global::System.IntPtr GetParameterName(global::System.IntPtr methodParameter) { return GetParameterName_extern(methodParameter); }
[DllImport("QmlNet", EntryPoint = "method_info_parameter_getType")]
static extern global::System.IntPtr GetParameterType_extern(global::System.IntPtr methodParameter);
public global::System.IntPtr GetParameterType(global::System.IntPtr methodParameter) { return GetParameterType_extern(methodParameter); }
[DllImport("QmlNet", EntryPoint = "method_info_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr parentTypeInfo, [MarshalAs(UnmanagedType.LPWStr)]global::System.String methodName, global::System.IntPtr returnTypeInfo);
public global::System.IntPtr Create(global::System.IntPtr parentTypeInfo, [MarshalAs(UnmanagedType.LPWStr)]global::System.String methodName, global::System.IntPtr returnTypeInfo) { return Create_extern(parentTypeInfo, methodName, returnTypeInfo); }
[DllImport("QmlNet", EntryPoint = "method_info_destroy")]
static extern void Destroy_extern(global::System.IntPtr methodInfo);
public void Destroy(global::System.IntPtr methodInfo) { Destroy_extern(methodInfo); }
[DllImport("QmlNet", EntryPoint = "method_info_getMethodName")]
static extern global::System.IntPtr GetMethodName_extern(global::System.IntPtr method);
public global::System.IntPtr GetMethodName(global::System.IntPtr method) { return GetMethodName_extern(method); }
[DllImport("QmlNet", EntryPoint = "method_info_getReturnType")]
static extern global::System.IntPtr GetReturnType_extern(global::System.IntPtr method);
public global::System.IntPtr GetReturnType(global::System.IntPtr method) { return GetReturnType_extern(method); }
[DllImport("QmlNet", EntryPoint = "method_info_addParameter")]
static extern void AddParameter_extern(global::System.IntPtr method, [MarshalAs(UnmanagedType.LPWStr)]global::System.String name, global::System.IntPtr type);
public void AddParameter(global::System.IntPtr method, [MarshalAs(UnmanagedType.LPWStr)]global::System.String name, global::System.IntPtr type) { AddParameter_extern(method, name, type); }
[DllImport("QmlNet", EntryPoint = "method_info_getParameterCount")]
static extern global::System.Int32 GetParameterCount_extern(global::System.IntPtr method);
public global::System.Int32 GetParameterCount(global::System.IntPtr method) { return GetParameterCount_extern(method); }
[DllImport("QmlNet", EntryPoint = "method_info_getParameter")]
static extern global::System.IntPtr GetParameter_extern(global::System.IntPtr method, global::System.Int32 index);
public global::System.IntPtr GetParameter(global::System.IntPtr method, global::System.Int32 index) { return GetParameter_extern(method, index); }
}

                    internal class NetMethodInfoInterop
                    {
                        public static INetMethodInfoInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetMethodInfoInteropOSX();
                            }
                            return new NetMethodInfoInteropDefault();
                        }
                    }
                    
internal class NetPropertyInfoInteropDefault : global::Qml.Net.Internal.Types.INetPropertyInfoInterop {
[DllImport("QmlNet", EntryPoint = "property_info_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr parentType, [MarshalAs(UnmanagedType.LPWStr)]global::System.String methodName, global::System.IntPtr returnType, global::System.Boolean canRead, global::System.Boolean canWrite, global::System.IntPtr notifySignal);
public global::System.IntPtr Create(global::System.IntPtr parentType, [MarshalAs(UnmanagedType.LPWStr)]global::System.String methodName, global::System.IntPtr returnType, global::System.Boolean canRead, global::System.Boolean canWrite, global::System.IntPtr notifySignal) { return Create_extern(parentType, methodName, returnType, canRead, canWrite, notifySignal); }
[DllImport("QmlNet", EntryPoint = "property_info_destroy")]
static extern void Destroy_extern(global::System.IntPtr property);
public void Destroy(global::System.IntPtr property) { Destroy_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_getParentType")]
static extern global::System.IntPtr GetParentType_extern(global::System.IntPtr property);
public global::System.IntPtr GetParentType(global::System.IntPtr property) { return GetParentType_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_getPropertyName")]
static extern global::System.IntPtr GetPropertyName_extern(global::System.IntPtr property);
public global::System.IntPtr GetPropertyName(global::System.IntPtr property) { return GetPropertyName_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_getReturnType")]
static extern global::System.IntPtr GetReturnType_extern(global::System.IntPtr property);
public global::System.IntPtr GetReturnType(global::System.IntPtr property) { return GetReturnType_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_canRead")]
static extern global::System.Boolean GetCanRead_extern(global::System.IntPtr property);
public global::System.Boolean GetCanRead(global::System.IntPtr property) { return GetCanRead_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_canWrite")]
static extern global::System.Boolean GetCanWrite_extern(global::System.IntPtr property);
public global::System.Boolean GetCanWrite(global::System.IntPtr property) { return GetCanWrite_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_getNotifySignal")]
static extern global::System.IntPtr GetNotifySignal_extern(global::System.IntPtr property);
public global::System.IntPtr GetNotifySignal(global::System.IntPtr property) { return GetNotifySignal_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_setNotifySignal")]
static extern void SetNotifySignal_extern(global::System.IntPtr property, global::System.IntPtr signal);
public void SetNotifySignal(global::System.IntPtr property, global::System.IntPtr signal) { SetNotifySignal_extern(property, signal); }
}
internal class NetPropertyInfoInteropOSX : global::Qml.Net.Internal.Types.INetPropertyInfoInterop {
[DllImport("QmlNet", EntryPoint = "property_info_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr parentType, [MarshalAs(UnmanagedType.LPWStr)]global::System.String methodName, global::System.IntPtr returnType, global::System.Boolean canRead, global::System.Boolean canWrite, global::System.IntPtr notifySignal);
public global::System.IntPtr Create(global::System.IntPtr parentType, [MarshalAs(UnmanagedType.LPWStr)]global::System.String methodName, global::System.IntPtr returnType, global::System.Boolean canRead, global::System.Boolean canWrite, global::System.IntPtr notifySignal) { return Create_extern(parentType, methodName, returnType, canRead, canWrite, notifySignal); }
[DllImport("QmlNet", EntryPoint = "property_info_destroy")]
static extern void Destroy_extern(global::System.IntPtr property);
public void Destroy(global::System.IntPtr property) { Destroy_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_getParentType")]
static extern global::System.IntPtr GetParentType_extern(global::System.IntPtr property);
public global::System.IntPtr GetParentType(global::System.IntPtr property) { return GetParentType_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_getPropertyName")]
static extern global::System.IntPtr GetPropertyName_extern(global::System.IntPtr property);
public global::System.IntPtr GetPropertyName(global::System.IntPtr property) { return GetPropertyName_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_getReturnType")]
static extern global::System.IntPtr GetReturnType_extern(global::System.IntPtr property);
public global::System.IntPtr GetReturnType(global::System.IntPtr property) { return GetReturnType_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_canRead")]
static extern global::System.Boolean GetCanRead_extern(global::System.IntPtr property);
public global::System.Boolean GetCanRead(global::System.IntPtr property) { return GetCanRead_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_canWrite")]
static extern global::System.Boolean GetCanWrite_extern(global::System.IntPtr property);
public global::System.Boolean GetCanWrite(global::System.IntPtr property) { return GetCanWrite_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_getNotifySignal")]
static extern global::System.IntPtr GetNotifySignal_extern(global::System.IntPtr property);
public global::System.IntPtr GetNotifySignal(global::System.IntPtr property) { return GetNotifySignal_extern(property); }
[DllImport("QmlNet", EntryPoint = "property_info_setNotifySignal")]
static extern void SetNotifySignal_extern(global::System.IntPtr property, global::System.IntPtr signal);
public void SetNotifySignal(global::System.IntPtr property, global::System.IntPtr signal) { SetNotifySignal_extern(property, signal); }
}

                    internal class NetPropertyInfoInterop
                    {
                        public static INetPropertyInfoInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetPropertyInfoInteropOSX();
                            }
                            return new NetPropertyInfoInteropDefault();
                        }
                    }
                    
internal class NetReferenceInteropDefault : global::Qml.Net.Internal.Types.INetReferenceInterop {
[DllImport("QmlNet", EntryPoint = "net_instance_create")]
static extern global::System.IntPtr Create_extern(global::System.UInt64 objectId, global::System.IntPtr type);
public global::System.IntPtr Create(global::System.UInt64 objectId, global::System.IntPtr type) { return Create_extern(objectId, type); }
[DllImport("QmlNet", EntryPoint = "net_instance_destroy")]
static extern void Destroy_extern(global::System.IntPtr instance);
public void Destroy(global::System.IntPtr instance) { Destroy_extern(instance); }
[DllImport("QmlNet", EntryPoint = "net_instance_clone")]
static extern global::System.IntPtr Clone_extern(global::System.IntPtr instance);
public global::System.IntPtr Clone(global::System.IntPtr instance) { return Clone_extern(instance); }
[DllImport("QmlNet", EntryPoint = "net_instance_getObjectId")]
static extern global::System.UInt64 GetObjectId_extern(global::System.IntPtr instance);
public global::System.UInt64 GetObjectId(global::System.IntPtr instance) { return GetObjectId_extern(instance); }
[DllImport("QmlNet", EntryPoint = "net_instance_activateSignal")]
static extern global::System.Boolean ActivateSignal_extern(global::System.IntPtr instance, [MarshalAs(UnmanagedType.LPWStr)]global::System.String signalName, global::System.IntPtr variants);
public global::System.Boolean ActivateSignal(global::System.IntPtr instance, [MarshalAs(UnmanagedType.LPWStr)]global::System.String signalName, global::System.IntPtr variants) { return ActivateSignal_extern(instance, signalName, variants); }
}
internal class NetReferenceInteropOSX : global::Qml.Net.Internal.Types.INetReferenceInterop {
[DllImport("QmlNet", EntryPoint = "net_instance_create")]
static extern global::System.IntPtr Create_extern(global::System.UInt64 objectId, global::System.IntPtr type);
public global::System.IntPtr Create(global::System.UInt64 objectId, global::System.IntPtr type) { return Create_extern(objectId, type); }
[DllImport("QmlNet", EntryPoint = "net_instance_destroy")]
static extern void Destroy_extern(global::System.IntPtr instance);
public void Destroy(global::System.IntPtr instance) { Destroy_extern(instance); }
[DllImport("QmlNet", EntryPoint = "net_instance_clone")]
static extern global::System.IntPtr Clone_extern(global::System.IntPtr instance);
public global::System.IntPtr Clone(global::System.IntPtr instance) { return Clone_extern(instance); }
[DllImport("QmlNet", EntryPoint = "net_instance_getObjectId")]
static extern global::System.UInt64 GetObjectId_extern(global::System.IntPtr instance);
public global::System.UInt64 GetObjectId(global::System.IntPtr instance) { return GetObjectId_extern(instance); }
[DllImport("QmlNet", EntryPoint = "net_instance_activateSignal")]
static extern global::System.Boolean ActivateSignal_extern(global::System.IntPtr instance, [MarshalAs(UnmanagedType.LPWStr)]global::System.String signalName, global::System.IntPtr variants);
public global::System.Boolean ActivateSignal(global::System.IntPtr instance, [MarshalAs(UnmanagedType.LPWStr)]global::System.String signalName, global::System.IntPtr variants) { return ActivateSignal_extern(instance, signalName, variants); }
}

                    internal class NetReferenceInterop
                    {
                        public static INetReferenceInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetReferenceInteropOSX();
                            }
                            return new NetReferenceInteropDefault();
                        }
                    }
                    
internal class NetSignalInfoInteropDefault : global::Qml.Net.Internal.Types.INetSignalInfoInterop {
[DllImport("QmlNet", EntryPoint = "signal_info_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr parentType, [MarshalAs(UnmanagedType.LPWStr)]global::System.String name);
public global::System.IntPtr Create(global::System.IntPtr parentType, [MarshalAs(UnmanagedType.LPWStr)]global::System.String name) { return Create_extern(parentType, name); }
[DllImport("QmlNet", EntryPoint = "signal_info_destroy")]
static extern void Destroy_extern(global::System.IntPtr signal);
public void Destroy(global::System.IntPtr signal) { Destroy_extern(signal); }
[DllImport("QmlNet", EntryPoint = "signal_info_getParentType")]
static extern global::System.IntPtr GetParentType_extern(global::System.IntPtr signal);
public global::System.IntPtr GetParentType(global::System.IntPtr signal) { return GetParentType_extern(signal); }
[DllImport("QmlNet", EntryPoint = "signal_info_getName")]
static extern global::System.IntPtr GetName_extern(global::System.IntPtr signal);
public global::System.IntPtr GetName(global::System.IntPtr signal) { return GetName_extern(signal); }
[DllImport("QmlNet", EntryPoint = "signal_info_addParameter")]
static extern void AddParameter_extern(global::System.IntPtr signal, global::Qml.Net.NetVariantType type);
public void AddParameter(global::System.IntPtr signal, global::Qml.Net.NetVariantType type) { AddParameter_extern(signal, type); }
[DllImport("QmlNet", EntryPoint = "signal_info_getParameterCount")]
static extern global::System.Int32 GetParameterCount_extern(global::System.IntPtr signal);
public global::System.Int32 GetParameterCount(global::System.IntPtr signal) { return GetParameterCount_extern(signal); }
[DllImport("QmlNet", EntryPoint = "signal_info_getParameter")]
static extern global::Qml.Net.NetVariantType GetParameter_extern(global::System.IntPtr signal, global::System.Int32 index);
public global::Qml.Net.NetVariantType GetParameter(global::System.IntPtr signal, global::System.Int32 index) { return GetParameter_extern(signal, index); }
}
internal class NetSignalInfoInteropOSX : global::Qml.Net.Internal.Types.INetSignalInfoInterop {
[DllImport("QmlNet", EntryPoint = "signal_info_create")]
static extern global::System.IntPtr Create_extern(global::System.IntPtr parentType, [MarshalAs(UnmanagedType.LPWStr)]global::System.String name);
public global::System.IntPtr Create(global::System.IntPtr parentType, [MarshalAs(UnmanagedType.LPWStr)]global::System.String name) { return Create_extern(parentType, name); }
[DllImport("QmlNet", EntryPoint = "signal_info_destroy")]
static extern void Destroy_extern(global::System.IntPtr signal);
public void Destroy(global::System.IntPtr signal) { Destroy_extern(signal); }
[DllImport("QmlNet", EntryPoint = "signal_info_getParentType")]
static extern global::System.IntPtr GetParentType_extern(global::System.IntPtr signal);
public global::System.IntPtr GetParentType(global::System.IntPtr signal) { return GetParentType_extern(signal); }
[DllImport("QmlNet", EntryPoint = "signal_info_getName")]
static extern global::System.IntPtr GetName_extern(global::System.IntPtr signal);
public global::System.IntPtr GetName(global::System.IntPtr signal) { return GetName_extern(signal); }
[DllImport("QmlNet", EntryPoint = "signal_info_addParameter")]
static extern void AddParameter_extern(global::System.IntPtr signal, global::Qml.Net.NetVariantType type);
public void AddParameter(global::System.IntPtr signal, global::Qml.Net.NetVariantType type) { AddParameter_extern(signal, type); }
[DllImport("QmlNet", EntryPoint = "signal_info_getParameterCount")]
static extern global::System.Int32 GetParameterCount_extern(global::System.IntPtr signal);
public global::System.Int32 GetParameterCount(global::System.IntPtr signal) { return GetParameterCount_extern(signal); }
[DllImport("QmlNet", EntryPoint = "signal_info_getParameter")]
static extern global::Qml.Net.NetVariantType GetParameter_extern(global::System.IntPtr signal, global::System.Int32 index);
public global::Qml.Net.NetVariantType GetParameter(global::System.IntPtr signal, global::System.Int32 index) { return GetParameter_extern(signal, index); }
}

                    internal class NetSignalInfoInterop
                    {
                        public static INetSignalInfoInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetSignalInfoInteropOSX();
                            }
                            return new NetSignalInfoInteropDefault();
                        }
                    }
                    
internal class NetTypeInfoInteropDefault : global::Qml.Net.Internal.Types.INetTypeInfoInterop {
[DllImport("QmlNet", EntryPoint = "type_info_create")]
static extern global::System.IntPtr Create_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String fullTypeName);
public global::System.IntPtr Create([MarshalAs(UnmanagedType.LPWStr)]global::System.String fullTypeName) { return Create_extern(fullTypeName); }
[DllImport("QmlNet", EntryPoint = "type_info_destroy")]
static extern void Destroy_extern(global::System.IntPtr netTypeInfo);
public void Destroy(global::System.IntPtr netTypeInfo) { Destroy_extern(netTypeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getFullTypeName")]
static extern global::System.IntPtr GetFullTypeName_extern(global::System.IntPtr netTypeInfo);
public global::System.IntPtr GetFullTypeName(global::System.IntPtr netTypeInfo) { return GetFullTypeName_extern(netTypeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_setClassName")]
static extern void SetClassName_extern(global::System.IntPtr netTypeInfo, [MarshalAs(UnmanagedType.LPWStr)]global::System.String className);
public void SetClassName(global::System.IntPtr netTypeInfo, [MarshalAs(UnmanagedType.LPWStr)]global::System.String className) { SetClassName_extern(netTypeInfo, className); }
[DllImport("QmlNet", EntryPoint = "type_info_getClassName")]
static extern global::System.IntPtr GetClassName_extern(global::System.IntPtr netTypeInfo);
public global::System.IntPtr GetClassName(global::System.IntPtr netTypeInfo) { return GetClassName_extern(netTypeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_setPrefVariantType")]
static extern void SetPrefVariantType_extern(global::System.IntPtr netTypeInfo, global::Qml.Net.NetVariantType variantType);
public void SetPrefVariantType(global::System.IntPtr netTypeInfo, global::Qml.Net.NetVariantType variantType) { SetPrefVariantType_extern(netTypeInfo, variantType); }
[DllImport("QmlNet", EntryPoint = "type_info_getPrefVariantType")]
static extern global::Qml.Net.NetVariantType GetPrefVariantType_extern(global::System.IntPtr netTypeInfo);
public global::Qml.Net.NetVariantType GetPrefVariantType(global::System.IntPtr netTypeInfo) { return GetPrefVariantType_extern(netTypeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_addMethod")]
static extern void AddMethod_extern(global::System.IntPtr typeInfo, global::System.IntPtr methodInfo);
public void AddMethod(global::System.IntPtr typeInfo, global::System.IntPtr methodInfo) { AddMethod_extern(typeInfo, methodInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getMethodCount")]
static extern global::System.Int32 GetMethodCount_extern(global::System.IntPtr typeInfo);
public global::System.Int32 GetMethodCount(global::System.IntPtr typeInfo) { return GetMethodCount_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getMethodInfo")]
static extern global::System.IntPtr GetMethodInfo_extern(global::System.IntPtr typeInfo, global::System.Int32 index);
public global::System.IntPtr GetMethodInfo(global::System.IntPtr typeInfo, global::System.Int32 index) { return GetMethodInfo_extern(typeInfo, index); }
[DllImport("QmlNet", EntryPoint = "type_info_addProperty")]
static extern void AddProperty_extern(global::System.IntPtr typeInfo, global::System.IntPtr property);
public void AddProperty(global::System.IntPtr typeInfo, global::System.IntPtr property) { AddProperty_extern(typeInfo, property); }
[DllImport("QmlNet", EntryPoint = "type_info_getPropertyCount")]
static extern global::System.Int32 GetPropertyCount_extern(global::System.IntPtr typeInfo);
public global::System.Int32 GetPropertyCount(global::System.IntPtr typeInfo) { return GetPropertyCount_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getProperty")]
static extern global::System.IntPtr GetProperty_extern(global::System.IntPtr typeInfo, global::System.Int32 index);
public global::System.IntPtr GetProperty(global::System.IntPtr typeInfo, global::System.Int32 index) { return GetProperty_extern(typeInfo, index); }
[DllImport("QmlNet", EntryPoint = "type_info_addSignal")]
static extern void AddSignal_extern(global::System.IntPtr typeInfo, global::System.IntPtr signal);
public void AddSignal(global::System.IntPtr typeInfo, global::System.IntPtr signal) { AddSignal_extern(typeInfo, signal); }
[DllImport("QmlNet", EntryPoint = "type_info_getSignalCount")]
static extern global::System.Int32 GetSignalCount_extern(global::System.IntPtr typeInfo);
public global::System.Int32 GetSignalCount(global::System.IntPtr typeInfo) { return GetSignalCount_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getSignal")]
static extern global::System.IntPtr GetSignal_extern(global::System.IntPtr typeInfo, global::System.Int32 index);
public global::System.IntPtr GetSignal(global::System.IntPtr typeInfo, global::System.Int32 index) { return GetSignal_extern(typeInfo, index); }
[DllImport("QmlNet", EntryPoint = "type_info_isLoaded")]
static extern global::System.Boolean IsLoaded_extern(global::System.IntPtr typeInfo);
public global::System.Boolean IsLoaded(global::System.IntPtr typeInfo) { return IsLoaded_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_isLoading")]
static extern global::System.Boolean IsLoading_extern(global::System.IntPtr typeInfo);
public global::System.Boolean IsLoading(global::System.IntPtr typeInfo) { return IsLoading_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_ensureLoaded")]
static extern void EnsureLoaded_extern(global::System.IntPtr typeInfo);
public void EnsureLoaded(global::System.IntPtr typeInfo) { EnsureLoaded_extern(typeInfo); }
}
internal class NetTypeInfoInteropOSX : global::Qml.Net.Internal.Types.INetTypeInfoInterop {
[DllImport("QmlNet", EntryPoint = "type_info_create")]
static extern global::System.IntPtr Create_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String fullTypeName);
public global::System.IntPtr Create([MarshalAs(UnmanagedType.LPWStr)]global::System.String fullTypeName) { return Create_extern(fullTypeName); }
[DllImport("QmlNet", EntryPoint = "type_info_destroy")]
static extern void Destroy_extern(global::System.IntPtr netTypeInfo);
public void Destroy(global::System.IntPtr netTypeInfo) { Destroy_extern(netTypeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getFullTypeName")]
static extern global::System.IntPtr GetFullTypeName_extern(global::System.IntPtr netTypeInfo);
public global::System.IntPtr GetFullTypeName(global::System.IntPtr netTypeInfo) { return GetFullTypeName_extern(netTypeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_setClassName")]
static extern void SetClassName_extern(global::System.IntPtr netTypeInfo, [MarshalAs(UnmanagedType.LPWStr)]global::System.String className);
public void SetClassName(global::System.IntPtr netTypeInfo, [MarshalAs(UnmanagedType.LPWStr)]global::System.String className) { SetClassName_extern(netTypeInfo, className); }
[DllImport("QmlNet", EntryPoint = "type_info_getClassName")]
static extern global::System.IntPtr GetClassName_extern(global::System.IntPtr netTypeInfo);
public global::System.IntPtr GetClassName(global::System.IntPtr netTypeInfo) { return GetClassName_extern(netTypeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_setPrefVariantType")]
static extern void SetPrefVariantType_extern(global::System.IntPtr netTypeInfo, global::Qml.Net.NetVariantType variantType);
public void SetPrefVariantType(global::System.IntPtr netTypeInfo, global::Qml.Net.NetVariantType variantType) { SetPrefVariantType_extern(netTypeInfo, variantType); }
[DllImport("QmlNet", EntryPoint = "type_info_getPrefVariantType")]
static extern global::Qml.Net.NetVariantType GetPrefVariantType_extern(global::System.IntPtr netTypeInfo);
public global::Qml.Net.NetVariantType GetPrefVariantType(global::System.IntPtr netTypeInfo) { return GetPrefVariantType_extern(netTypeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_addMethod")]
static extern void AddMethod_extern(global::System.IntPtr typeInfo, global::System.IntPtr methodInfo);
public void AddMethod(global::System.IntPtr typeInfo, global::System.IntPtr methodInfo) { AddMethod_extern(typeInfo, methodInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getMethodCount")]
static extern global::System.Int32 GetMethodCount_extern(global::System.IntPtr typeInfo);
public global::System.Int32 GetMethodCount(global::System.IntPtr typeInfo) { return GetMethodCount_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getMethodInfo")]
static extern global::System.IntPtr GetMethodInfo_extern(global::System.IntPtr typeInfo, global::System.Int32 index);
public global::System.IntPtr GetMethodInfo(global::System.IntPtr typeInfo, global::System.Int32 index) { return GetMethodInfo_extern(typeInfo, index); }
[DllImport("QmlNet", EntryPoint = "type_info_addProperty")]
static extern void AddProperty_extern(global::System.IntPtr typeInfo, global::System.IntPtr property);
public void AddProperty(global::System.IntPtr typeInfo, global::System.IntPtr property) { AddProperty_extern(typeInfo, property); }
[DllImport("QmlNet", EntryPoint = "type_info_getPropertyCount")]
static extern global::System.Int32 GetPropertyCount_extern(global::System.IntPtr typeInfo);
public global::System.Int32 GetPropertyCount(global::System.IntPtr typeInfo) { return GetPropertyCount_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getProperty")]
static extern global::System.IntPtr GetProperty_extern(global::System.IntPtr typeInfo, global::System.Int32 index);
public global::System.IntPtr GetProperty(global::System.IntPtr typeInfo, global::System.Int32 index) { return GetProperty_extern(typeInfo, index); }
[DllImport("QmlNet", EntryPoint = "type_info_addSignal")]
static extern void AddSignal_extern(global::System.IntPtr typeInfo, global::System.IntPtr signal);
public void AddSignal(global::System.IntPtr typeInfo, global::System.IntPtr signal) { AddSignal_extern(typeInfo, signal); }
[DllImport("QmlNet", EntryPoint = "type_info_getSignalCount")]
static extern global::System.Int32 GetSignalCount_extern(global::System.IntPtr typeInfo);
public global::System.Int32 GetSignalCount(global::System.IntPtr typeInfo) { return GetSignalCount_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_getSignal")]
static extern global::System.IntPtr GetSignal_extern(global::System.IntPtr typeInfo, global::System.Int32 index);
public global::System.IntPtr GetSignal(global::System.IntPtr typeInfo, global::System.Int32 index) { return GetSignal_extern(typeInfo, index); }
[DllImport("QmlNet", EntryPoint = "type_info_isLoaded")]
static extern global::System.Boolean IsLoaded_extern(global::System.IntPtr typeInfo);
public global::System.Boolean IsLoaded(global::System.IntPtr typeInfo) { return IsLoaded_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_isLoading")]
static extern global::System.Boolean IsLoading_extern(global::System.IntPtr typeInfo);
public global::System.Boolean IsLoading(global::System.IntPtr typeInfo) { return IsLoading_extern(typeInfo); }
[DllImport("QmlNet", EntryPoint = "type_info_ensureLoaded")]
static extern void EnsureLoaded_extern(global::System.IntPtr typeInfo);
public void EnsureLoaded(global::System.IntPtr typeInfo) { EnsureLoaded_extern(typeInfo); }
}

                    internal class NetTypeInfoInterop
                    {
                        public static INetTypeInfoInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetTypeInfoInteropOSX();
                            }
                            return new NetTypeInfoInteropDefault();
                        }
                    }
                    
internal class NetTypeManagerInteropDefault : global::Qml.Net.Internal.Types.INetTypeManagerInterop {
[DllImport("QmlNet", EntryPoint = "type_manager_getTypeInfo")]
static extern global::System.IntPtr GetTypeInfo_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String fullTypeName);
public global::System.IntPtr GetTypeInfo([MarshalAs(UnmanagedType.LPWStr)]global::System.String fullTypeName) { return GetTypeInfo_extern(fullTypeName); }
}
internal class NetTypeManagerInteropOSX : global::Qml.Net.Internal.Types.INetTypeManagerInterop {
[DllImport("QmlNet", EntryPoint = "type_manager_getTypeInfo")]
static extern global::System.IntPtr GetTypeInfo_extern([MarshalAs(UnmanagedType.LPWStr)]global::System.String fullTypeName);
public global::System.IntPtr GetTypeInfo([MarshalAs(UnmanagedType.LPWStr)]global::System.String fullTypeName) { return GetTypeInfo_extern(fullTypeName); }
}

                    internal class NetTypeManagerInterop
                    {
                        public static INetTypeManagerInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetTypeManagerInteropOSX();
                            }
                            return new NetTypeManagerInteropDefault();
                        }
                    }
                    
internal class NetJsValueInteropDefault : global::Qml.Net.Internal.Qml.INetJsValueInterop {
[DllImport("QmlNet", EntryPoint = "net_js_value_destroy")]
static extern void Destroy_extern(global::System.IntPtr jsValue);
public void Destroy(global::System.IntPtr jsValue) { Destroy_extern(jsValue); }
[DllImport("QmlNet", EntryPoint = "net_js_value_isCallable")]
static extern global::System.Boolean IsCallable_extern(global::System.IntPtr jsValue);
public global::System.Boolean IsCallable(global::System.IntPtr jsValue) { return IsCallable_extern(jsValue); }
[DllImport("QmlNet", EntryPoint = "net_js_value_call")]
static extern global::System.IntPtr Call_extern(global::System.IntPtr jsValue, global::System.IntPtr parameters);
public global::System.IntPtr Call(global::System.IntPtr jsValue, global::System.IntPtr parameters) { return Call_extern(jsValue, parameters); }
[DllImport("QmlNet", EntryPoint = "net_js_value_getProperty")]
static extern global::System.IntPtr GetProperty_extern(global::System.IntPtr jsValue, [MarshalAs(UnmanagedType.LPWStr)]global::System.String propertyName);
public global::System.IntPtr GetProperty(global::System.IntPtr jsValue, [MarshalAs(UnmanagedType.LPWStr)]global::System.String propertyName) { return GetProperty_extern(jsValue, propertyName); }
[DllImport("QmlNet", EntryPoint = "net_js_value_setProperty")]
static extern void SetProperty_extern(global::System.IntPtr jsValue, [MarshalAs(UnmanagedType.LPWStr)]global::System.String propertyName, global::System.IntPtr value);
public void SetProperty(global::System.IntPtr jsValue, [MarshalAs(UnmanagedType.LPWStr)]global::System.String propertyName, global::System.IntPtr value) { SetProperty_extern(jsValue, propertyName, value); }
}
internal class NetJsValueInteropOSX : global::Qml.Net.Internal.Qml.INetJsValueInterop {
[DllImport("QmlNet", EntryPoint = "net_js_value_destroy")]
static extern void Destroy_extern(global::System.IntPtr jsValue);
public void Destroy(global::System.IntPtr jsValue) { Destroy_extern(jsValue); }
[DllImport("QmlNet", EntryPoint = "net_js_value_isCallable")]
static extern global::System.Boolean IsCallable_extern(global::System.IntPtr jsValue);
public global::System.Boolean IsCallable(global::System.IntPtr jsValue) { return IsCallable_extern(jsValue); }
[DllImport("QmlNet", EntryPoint = "net_js_value_call")]
static extern global::System.IntPtr Call_extern(global::System.IntPtr jsValue, global::System.IntPtr parameters);
public global::System.IntPtr Call(global::System.IntPtr jsValue, global::System.IntPtr parameters) { return Call_extern(jsValue, parameters); }
[DllImport("QmlNet", EntryPoint = "net_js_value_getProperty")]
static extern global::System.IntPtr GetProperty_extern(global::System.IntPtr jsValue, [MarshalAs(UnmanagedType.LPWStr)]global::System.String propertyName);
public global::System.IntPtr GetProperty(global::System.IntPtr jsValue, [MarshalAs(UnmanagedType.LPWStr)]global::System.String propertyName) { return GetProperty_extern(jsValue, propertyName); }
[DllImport("QmlNet", EntryPoint = "net_js_value_setProperty")]
static extern void SetProperty_extern(global::System.IntPtr jsValue, [MarshalAs(UnmanagedType.LPWStr)]global::System.String propertyName, global::System.IntPtr value);
public void SetProperty(global::System.IntPtr jsValue, [MarshalAs(UnmanagedType.LPWStr)]global::System.String propertyName, global::System.IntPtr value) { SetProperty_extern(jsValue, propertyName, value); }
}

                    internal class NetJsValueInterop
                    {
                        public static INetJsValueInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetJsValueInteropOSX();
                            }
                            return new NetJsValueInteropDefault();
                        }
                    }
                    
internal class NetTestHelperInteropDefault : global::Qml.Net.Internal.Qml.INetTestHelperInterop {
[DllImport("QmlNet", EntryPoint = "net_test_helper_runQml")]
static extern void RunQml_extern(global::System.IntPtr qmlEngine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String qml);
public void RunQml(global::System.IntPtr qmlEngine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String qml) { RunQml_extern(qmlEngine, qml); }
}
internal class NetTestHelperInteropOSX : global::Qml.Net.Internal.Qml.INetTestHelperInterop {
[DllImport("QmlNet", EntryPoint = "net_test_helper_runQml")]
static extern void RunQml_extern(global::System.IntPtr qmlEngine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String qml);
public void RunQml(global::System.IntPtr qmlEngine, [MarshalAs(UnmanagedType.LPWStr)]global::System.String qml) { RunQml_extern(qmlEngine, qml); }
}

                    internal class NetTestHelperInterop
                    {
                        public static INetTestHelperInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetTestHelperInteropOSX();
                            }
                            return new NetTestHelperInteropDefault();
                        }
                    }
                    
internal class NetVariantInteropDefault : global::Qml.Net.Internal.Qml.INetVariantInterop {
[DllImport("QmlNet", EntryPoint = "net_variant_create")]
static extern global::System.IntPtr Create_extern();
public global::System.IntPtr Create() { return Create_extern(); }
[DllImport("QmlNet", EntryPoint = "net_variant_destroy")]
static extern void Destroy_extern(global::System.IntPtr variant);
public void Destroy(global::System.IntPtr variant) { Destroy_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_getVariantType")]
static extern global::Qml.Net.NetVariantType GetVariantType_extern(global::System.IntPtr variant);
public global::Qml.Net.NetVariantType GetVariantType(global::System.IntPtr variant) { return GetVariantType_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setNetReference")]
static extern void SetNetReference_extern(global::System.IntPtr variant, global::System.IntPtr instance);
public void SetNetReference(global::System.IntPtr variant, global::System.IntPtr instance) { SetNetReference_extern(variant, instance); }
[DllImport("QmlNet", EntryPoint = "net_variant_getNetReference")]
static extern global::System.IntPtr GetNetReference_extern(global::System.IntPtr variant);
public global::System.IntPtr GetNetReference(global::System.IntPtr variant) { return GetNetReference_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setBool")]
static extern void SetBool_extern(global::System.IntPtr variant, global::System.Boolean value);
public void SetBool(global::System.IntPtr variant, global::System.Boolean value) { SetBool_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getBool")]
static extern global::System.Boolean GetBool_extern(global::System.IntPtr variant);
public global::System.Boolean GetBool(global::System.IntPtr variant) { return GetBool_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setChar")]
static extern void SetChar_extern(global::System.IntPtr variant, global::System.UInt16 value);
public void SetChar(global::System.IntPtr variant, global::System.UInt16 value) { SetChar_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getChar")]
static extern global::System.UInt16 GetChar_extern(global::System.IntPtr variant);
public global::System.UInt16 GetChar(global::System.IntPtr variant) { return GetChar_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setInt")]
static extern void SetInt_extern(global::System.IntPtr variant, global::System.Int32 value);
public void SetInt(global::System.IntPtr variant, global::System.Int32 value) { SetInt_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getInt")]
static extern global::System.Int32 GetInt_extern(global::System.IntPtr variant);
public global::System.Int32 GetInt(global::System.IntPtr variant) { return GetInt_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setUInt")]
static extern void SetUInt_extern(global::System.IntPtr variant, global::System.UInt32 value);
public void SetUInt(global::System.IntPtr variant, global::System.UInt32 value) { SetUInt_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getUInt")]
static extern global::System.UInt32 GetUInt_extern(global::System.IntPtr variant);
public global::System.UInt32 GetUInt(global::System.IntPtr variant) { return GetUInt_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setDouble")]
static extern void SetDouble_extern(global::System.IntPtr variant, global::System.Double value);
public void SetDouble(global::System.IntPtr variant, global::System.Double value) { SetDouble_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getDouble")]
static extern global::System.Double GetDouble_extern(global::System.IntPtr variant);
public global::System.Double GetDouble(global::System.IntPtr variant) { return GetDouble_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setString")]
static extern void SetString_extern(global::System.IntPtr variant, [MarshalAs(UnmanagedType.LPWStr)]global::System.String value);
public void SetString(global::System.IntPtr variant, [MarshalAs(UnmanagedType.LPWStr)]global::System.String value) { SetString_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getString")]
static extern global::System.IntPtr GetString_extern(global::System.IntPtr variant);
public global::System.IntPtr GetString(global::System.IntPtr variant) { return GetString_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setDateTime")]
static extern void SetDateTime_extern(global::System.IntPtr variant, ref global::Qml.Net.Internal.Qml.DateTimeContainer dateTime);
public void SetDateTime(global::System.IntPtr variant, ref global::Qml.Net.Internal.Qml.DateTimeContainer dateTime) { SetDateTime_extern(variant, ref dateTime); }
[DllImport("QmlNet", EntryPoint = "net_variant_getDateTime")]
static extern void GetDateTime_extern(global::System.IntPtr variant, ref global::Qml.Net.Internal.Qml.DateTimeContainer dateTime);
public void GetDateTime(global::System.IntPtr variant, ref global::Qml.Net.Internal.Qml.DateTimeContainer dateTime) { GetDateTime_extern(variant, ref dateTime); }
[DllImport("QmlNet", EntryPoint = "net_variant_setJsValue")]
static extern void SetJsValue_extern(global::System.IntPtr variant, global::System.IntPtr jsValue);
public void SetJsValue(global::System.IntPtr variant, global::System.IntPtr jsValue) { SetJsValue_extern(variant, jsValue); }
[DllImport("QmlNet", EntryPoint = "net_variant_getJsValue")]
static extern global::System.IntPtr GetJsValue_extern(global::System.IntPtr variant);
public global::System.IntPtr GetJsValue(global::System.IntPtr variant) { return GetJsValue_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_clear")]
static extern void Clear_extern(global::System.IntPtr variant);
public void Clear(global::System.IntPtr variant) { Clear_extern(variant); }
}
internal class NetVariantInteropOSX : global::Qml.Net.Internal.Qml.INetVariantInterop {
[DllImport("QmlNet", EntryPoint = "net_variant_create")]
static extern global::System.IntPtr Create_extern();
public global::System.IntPtr Create() { return Create_extern(); }
[DllImport("QmlNet", EntryPoint = "net_variant_destroy")]
static extern void Destroy_extern(global::System.IntPtr variant);
public void Destroy(global::System.IntPtr variant) { Destroy_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_getVariantType")]
static extern global::Qml.Net.NetVariantType GetVariantType_extern(global::System.IntPtr variant);
public global::Qml.Net.NetVariantType GetVariantType(global::System.IntPtr variant) { return GetVariantType_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setNetReference")]
static extern void SetNetReference_extern(global::System.IntPtr variant, global::System.IntPtr instance);
public void SetNetReference(global::System.IntPtr variant, global::System.IntPtr instance) { SetNetReference_extern(variant, instance); }
[DllImport("QmlNet", EntryPoint = "net_variant_getNetReference")]
static extern global::System.IntPtr GetNetReference_extern(global::System.IntPtr variant);
public global::System.IntPtr GetNetReference(global::System.IntPtr variant) { return GetNetReference_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setBool")]
static extern void SetBool_extern(global::System.IntPtr variant, global::System.Boolean value);
public void SetBool(global::System.IntPtr variant, global::System.Boolean value) { SetBool_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getBool")]
static extern global::System.Boolean GetBool_extern(global::System.IntPtr variant);
public global::System.Boolean GetBool(global::System.IntPtr variant) { return GetBool_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setChar")]
static extern void SetChar_extern(global::System.IntPtr variant, global::System.UInt16 value);
public void SetChar(global::System.IntPtr variant, global::System.UInt16 value) { SetChar_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getChar")]
static extern global::System.UInt16 GetChar_extern(global::System.IntPtr variant);
public global::System.UInt16 GetChar(global::System.IntPtr variant) { return GetChar_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setInt")]
static extern void SetInt_extern(global::System.IntPtr variant, global::System.Int32 value);
public void SetInt(global::System.IntPtr variant, global::System.Int32 value) { SetInt_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getInt")]
static extern global::System.Int32 GetInt_extern(global::System.IntPtr variant);
public global::System.Int32 GetInt(global::System.IntPtr variant) { return GetInt_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setUInt")]
static extern void SetUInt_extern(global::System.IntPtr variant, global::System.UInt32 value);
public void SetUInt(global::System.IntPtr variant, global::System.UInt32 value) { SetUInt_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getUInt")]
static extern global::System.UInt32 GetUInt_extern(global::System.IntPtr variant);
public global::System.UInt32 GetUInt(global::System.IntPtr variant) { return GetUInt_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setDouble")]
static extern void SetDouble_extern(global::System.IntPtr variant, global::System.Double value);
public void SetDouble(global::System.IntPtr variant, global::System.Double value) { SetDouble_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getDouble")]
static extern global::System.Double GetDouble_extern(global::System.IntPtr variant);
public global::System.Double GetDouble(global::System.IntPtr variant) { return GetDouble_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setString")]
static extern void SetString_extern(global::System.IntPtr variant, [MarshalAs(UnmanagedType.LPWStr)]global::System.String value);
public void SetString(global::System.IntPtr variant, [MarshalAs(UnmanagedType.LPWStr)]global::System.String value) { SetString_extern(variant, value); }
[DllImport("QmlNet", EntryPoint = "net_variant_getString")]
static extern global::System.IntPtr GetString_extern(global::System.IntPtr variant);
public global::System.IntPtr GetString(global::System.IntPtr variant) { return GetString_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_setDateTime")]
static extern void SetDateTime_extern(global::System.IntPtr variant, ref global::Qml.Net.Internal.Qml.DateTimeContainer dateTime);
public void SetDateTime(global::System.IntPtr variant, ref global::Qml.Net.Internal.Qml.DateTimeContainer dateTime) { SetDateTime_extern(variant, ref dateTime); }
[DllImport("QmlNet", EntryPoint = "net_variant_getDateTime")]
static extern void GetDateTime_extern(global::System.IntPtr variant, ref global::Qml.Net.Internal.Qml.DateTimeContainer dateTime);
public void GetDateTime(global::System.IntPtr variant, ref global::Qml.Net.Internal.Qml.DateTimeContainer dateTime) { GetDateTime_extern(variant, ref dateTime); }
[DllImport("QmlNet", EntryPoint = "net_variant_setJsValue")]
static extern void SetJsValue_extern(global::System.IntPtr variant, global::System.IntPtr jsValue);
public void SetJsValue(global::System.IntPtr variant, global::System.IntPtr jsValue) { SetJsValue_extern(variant, jsValue); }
[DllImport("QmlNet", EntryPoint = "net_variant_getJsValue")]
static extern global::System.IntPtr GetJsValue_extern(global::System.IntPtr variant);
public global::System.IntPtr GetJsValue(global::System.IntPtr variant) { return GetJsValue_extern(variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_clear")]
static extern void Clear_extern(global::System.IntPtr variant);
public void Clear(global::System.IntPtr variant) { Clear_extern(variant); }
}

                    internal class NetVariantInterop
                    {
                        public static INetVariantInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetVariantInteropOSX();
                            }
                            return new NetVariantInteropDefault();
                        }
                    }
                    
internal class NetVariantListInteropDefault : global::Qml.Net.Internal.Qml.INetVariantListInterop {
[DllImport("QmlNet", EntryPoint = "net_variant_list_create")]
static extern global::System.IntPtr Create_extern();
public global::System.IntPtr Create() { return Create_extern(); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_destroy")]
static extern void Destroy_extern(global::System.IntPtr list);
public void Destroy(global::System.IntPtr list) { Destroy_extern(list); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_count")]
static extern global::System.Int32 Count_extern(global::System.IntPtr list);
public global::System.Int32 Count(global::System.IntPtr list) { return Count_extern(list); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_add")]
static extern void Add_extern(global::System.IntPtr list, global::System.IntPtr variant);
public void Add(global::System.IntPtr list, global::System.IntPtr variant) { Add_extern(list, variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_get")]
static extern global::System.IntPtr Get_extern(global::System.IntPtr list, global::System.Int32 index);
public global::System.IntPtr Get(global::System.IntPtr list, global::System.Int32 index) { return Get_extern(list, index); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_remove")]
static extern void Remove_extern(global::System.IntPtr list, global::System.Int32 index);
public void Remove(global::System.IntPtr list, global::System.Int32 index) { Remove_extern(list, index); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_clear")]
static extern void Clear_extern(global::System.IntPtr list);
public void Clear(global::System.IntPtr list) { Clear_extern(list); }
}
internal class NetVariantListInteropOSX : global::Qml.Net.Internal.Qml.INetVariantListInterop {
[DllImport("QmlNet", EntryPoint = "net_variant_list_create")]
static extern global::System.IntPtr Create_extern();
public global::System.IntPtr Create() { return Create_extern(); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_destroy")]
static extern void Destroy_extern(global::System.IntPtr list);
public void Destroy(global::System.IntPtr list) { Destroy_extern(list); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_count")]
static extern global::System.Int32 Count_extern(global::System.IntPtr list);
public global::System.Int32 Count(global::System.IntPtr list) { return Count_extern(list); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_add")]
static extern void Add_extern(global::System.IntPtr list, global::System.IntPtr variant);
public void Add(global::System.IntPtr list, global::System.IntPtr variant) { Add_extern(list, variant); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_get")]
static extern global::System.IntPtr Get_extern(global::System.IntPtr list, global::System.Int32 index);
public global::System.IntPtr Get(global::System.IntPtr list, global::System.Int32 index) { return Get_extern(list, index); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_remove")]
static extern void Remove_extern(global::System.IntPtr list, global::System.Int32 index);
public void Remove(global::System.IntPtr list, global::System.Int32 index) { Remove_extern(list, index); }
[DllImport("QmlNet", EntryPoint = "net_variant_list_clear")]
static extern void Clear_extern(global::System.IntPtr list);
public void Clear(global::System.IntPtr list) { Clear_extern(list); }
}

                    internal class NetVariantListInterop
                    {
                        public static INetVariantListInterop Get()
                        {
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {
                                return new NetVariantListInteropOSX();
                            }
                            return new NetVariantListInteropDefault();
                        }
                    }
                    
}
