using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Build.Buildary;
using Qml.Net.Internal.PInvoke;

namespace Build
{
    public class Interop
    {
        public static void Generate(string destination)
        {
            var sb = new StringBuilder();

            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("using Qml.Net.Internal.Qml;");
            sb.AppendLine("using Qml.Net.Internal.Types;");
            sb.AppendLine("// ReSharper disable RedundantNameQualifier");
            sb.AppendLine("// ReSharper disable UnusedMember.Global");
            sb.AppendLine("namespace Qml.Net.Internal.PInvoke {");
            
            foreach (var type in typeof(IPinvoke).Assembly.GetTypes())
            {
                if (type.IsInterface 
                    && typeof(IPinvoke).IsAssignableFrom(type) 
                    && type != typeof(IPinvoke)
                    && type.Name != "ICombined")
                {
                    GenerateForType(sb, type, "QmlNet", $"{type.Name.Substring(1)}Default");
                    GenerateForType(sb, type, "QmlNet", $"{type.Name.Substring(1)}OSX");
                    sb.AppendLine($@"
                    internal class {type.Name.Substring(1)}
                    {{
                        public static {type.Name} Get()
                        {{
                            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            {{
                                return new {type.Name.Substring(1)}OSX();
                            }}
                            return new {type.Name.Substring(1)}Default();
                        }}
                    }}
                    ");
                    
                }
            }

            sb.AppendLine("}");

            if (File.FileExists(destination))
            {
                File.DeleteFile(destination);
            }

            File.WriteFile(destination, sb.ToString());
        }

        private static void GenerateForType(StringBuilder sb, Type type, string dllName, string className)
        {
            sb.AppendLine($"internal class {className} : global::{type.FullName} {{");
            foreach (var method in type.GetMethods())
            {
                var symbolAttribute = (NativeSymbolAttribute)method.GetCustomAttributes(typeof(NativeSymbolAttribute), false).Single();
                
                sb.AppendLine($"[DllImport(\"{dllName}\", EntryPoint = \"{symbolAttribute.Entrypoint}\")]");
                
                sb.Append("static extern ");
                
                if (method.ReturnType == null || method.ReturnType.Name == "Void")
                {
                    sb.Append("void ");
                }
                else
                {
                    sb.Append($"global::{method.ReturnType.FullName} ");
                }

                sb.Append($"{method.Name}_extern(");

                var parameters = method.GetParameters().ToList();
                foreach (var parameter in parameters)
                {
                    WriteParameter(sb, parameter, true);
                    if (parameters.IndexOf(parameter) != parameters.Count - 1)
                    {
                        sb.Append(", ");
                    }
                }

                sb.AppendLine(");");
                
                sb.Append("public ");
                
                if (method.ReturnType == null || method.ReturnType.Name == "Void")
                {
                    sb.Append("void ");
                }
                else
                {
                    sb.Append($"global::{method.ReturnType.FullName} ");
                }
                
                sb.Append($"{method.Name}(");
                
                foreach (var parameter in parameters)
                {
                    WriteParameter(sb, parameter, true);
                    if (parameters.IndexOf(parameter) != parameters.Count - 1)
                    {
                        sb.Append(", ");
                    }
                }
                
                sb.Append(") { ");

                if (method.ReturnType == null || method.ReturnType.Name == "Void")
                {
                    sb.Append($"{method.Name}_extern(");
                }
                else
                {
                    sb.Append($"return {method.Name}_extern(");
                }

                foreach (var parameter in parameters)
                {
                    if (parameter.ParameterType.IsByRef && parameter.IsOut == false)
                    {
                        sb.Append("ref ");
                    } else if (parameter.ParameterType.IsByRef && parameter.IsOut)
                    {
                        sb.Append("out ");
                    }
                    
                    sb.Append($"{parameter.Name}");
                    if (parameters.IndexOf(parameter) != parameters.Count - 1)
                    {
                        sb.Append(", ");
                    }
                }
                sb.AppendLine("); }");
            }
            
            sb.AppendLine("}");
        }

        private static void WriteParameter(StringBuilder sb, ParameterInfo parameterInfo, bool includeMarshal = false)
        {
            if (includeMarshal)
            {
                var marshalAttribute = (MarshalAsAttribute) parameterInfo.GetCustomAttributes(typeof(MarshalAsAttribute), false).SingleOrDefault();
                if (marshalAttribute != null)
                {
                    sb.Append($"[MarshalAs(UnmanagedType.{marshalAttribute.Value})]");
                }
            }

            if (parameterInfo.ParameterType.IsByRef && parameterInfo.IsOut == false)
            {
                sb.Append("ref ");
            } else if (parameterInfo.ParameterType.IsByRef && parameterInfo.IsOut)
            {
                sb.Append("out ");
            }

            var typeName = parameterInfo.ParameterType.FullName;
            if (parameterInfo.ParameterType.IsByRef)
            {
                typeName = typeName.Substring(0, typeName.Length - 1);
            }
            
            sb.Append($"global::{typeName} {parameterInfo.Name}");
        }
        
    }
}