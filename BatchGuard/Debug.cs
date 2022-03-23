using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuard
{
    public enum LogType
    {
        Normal,
        Info,
        Success,
        Error,
        Warning,
    }

    public class Debug
    { 
        public static void Log(string message, LogType t)
        {
            switch (t)
            {
                case LogType.Normal:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[-] ");
                        break;
                    }
                case LogType.Info:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("[@] ");
                        break;
                    }
                case LogType.Success:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[+] ");
                        break;
                    }
                case LogType.Error:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[!] ");
                        break;
                    }
                case LogType.Warning:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("[!] ");
                        break;
                    }
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(message + "\n");
        }
    }
}
