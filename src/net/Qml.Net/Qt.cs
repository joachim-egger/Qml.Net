using Qml.Net.Internal;
using System;
using System.Runtime.InteropServices;
using Qml.Net.Internal.PInvoke;

namespace Qml.Net
{
    public class Qt
    {
        public static bool PutEnv(string name, string value)
        {
            return Interop.QtInterop.PutEnv(name, value);
        }

        public static string GetEnv(string name)
        {
            return Utilities.ContainerToString(Interop.QtInterop.GetEnv(name));
        } 
    }

    internal interface IQtInterop : IPinvoke
    {
        [NativeSymbol(Entrypoint = "qt_putenv")]
        bool PutEnv([MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);
        [NativeSymbol(Entrypoint = "qt_getenv")]
        IntPtr GetEnv(string name);
    }
}
