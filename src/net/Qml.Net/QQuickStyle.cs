using System.Runtime.InteropServices;
using Qml.Net.Internal;
using Qml.Net.Internal.PInvoke;

namespace Qml.Net
{
    public class QQuickStyle
    {
        public static void SetStyle(string style)
        {
            Interop.QQuickStyle.SetStyle(style);
        }
    }
    
    internal interface IQQuickStyleInterop : IPinvoke
    {
        [NativeSymbol(Entrypoint = "qquickstyle_setStyle")]
        void SetStyle([MarshalAs(UnmanagedType.LPWStr)]string style);
    }
}