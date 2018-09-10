using System;

namespace Qml.Net.Hosting
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"arg count: {args.Length}");
            var appPtr = new IntPtr((long)ulong.Parse(args[0]));
            var enginePtr = new IntPtr((long)ulong.Parse(args[1]));

            Console.WriteLine(appPtr);
            Console.WriteLine(enginePtr);
            
            using (var app = new QGuiApplication(appPtr))
            {
                using (var engine = new QQmlApplicationEngine(enginePtr))
                {
                    app.Exec();
                    return 3;
                }
            }
        }
    }
}
