using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateRandomNumber
{
    static class Program
    {
        // Use the assembly GUID to create a unique mutex name so only a single
        // instance of the application can run at a time.
        private static readonly string appGuid = ((GuidAttribute)Assembly
                .GetExecutingAssembly()
                .GetCustomAttributes(typeof(GuidAttribute), false)[0])
            .Value;
        private static Mutex appMutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            appMutex = new Mutex(true, "Global\\" + appGuid, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("Application is already running\n\nOnly instance open at a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
