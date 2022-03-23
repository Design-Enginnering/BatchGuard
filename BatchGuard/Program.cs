using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BatchGuard
{
    internal static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main() 
        {
            Console.Title = "BatchGuard Debug Console";
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Debug.Log("Attempted to make process DPI aware.", LogType.Info);

            Debug.Log("Attempting to open form...", LogType.Normal);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
