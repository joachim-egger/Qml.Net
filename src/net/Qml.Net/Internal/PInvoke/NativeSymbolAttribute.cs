using System;

namespace Qml.Net.Internal.PInvoke
{
    public class NativeSymbolAttribute : Attribute
    {
        public NativeSymbolAttribute()
        {
            
        }
        
        public string Entrypoint { get; set; }
    }
}