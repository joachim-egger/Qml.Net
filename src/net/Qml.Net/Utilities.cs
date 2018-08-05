using System;
using System.Runtime.InteropServices;
using Qml.Net.Internal;
using Qml.Net.Internal.PInvoke;

namespace Qml.Net
{
    internal class Utilities
    {
        public static string ContainerToString(IntPtr container)
        {
            if (container == IntPtr.Zero)
            {
                return null;
            }

            var containerStruct = Marshal.PtrToStructure<StringContainer>(container);
            var result = Marshal.PtrToStringUni(containerStruct.Data);
            Interop.Utilities.FreeString(container);
            return result;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct StringContainer
        {
            private readonly IntPtr _ignore;
            public readonly IntPtr Data;
        }
    }
    
    internal interface IUtilities : IPinvoke
    {
        [NativeSymbol(Entrypoint = "freeString")]
        void FreeString(IntPtr container);
        
        [NativeSymbol(Entrypoint = "qml_net_getVersion")]
        long GetVersion(); 
    }
}