using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RubikResolverWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            parent mainForm = new parent();
            Application.Run(mainForm);
            //Application.Run(new Form1());
        }
    }
}
