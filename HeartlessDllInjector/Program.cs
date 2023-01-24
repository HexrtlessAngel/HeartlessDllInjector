// Only in ohio? Why only in ohio?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartlessDllInjector
{
    internal static class Program
    {
        // Shut up MSVCE We know what "Main()" means lul
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InjectorFormWindow());
        }
    }
}
