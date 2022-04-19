using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEnigma
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
            CredentialsForm creds = new CredentialsForm();
            Application.Run(creds);
            if (creds.exitValue)
                Application.Run(new ImageEnigmaForm());
        }
    }
}
