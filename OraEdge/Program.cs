using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace OraEdge
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new System.Threading.Mutex(false, "OraEdge");
            try
            {
                if (mutex.WaitOne(0, false))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new OraEdge_Parent());
                }
                else { MessageBox.Show("Another instance of the OraEdge is already running.", "Oracle Edge", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            finally { mutex.ReleaseMutex(); if(mutex != null) { mutex.Close(); mutex = null; } }
        }
    }
}
