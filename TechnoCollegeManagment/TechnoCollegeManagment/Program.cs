using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoCollegeManagment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the mainApp.
        /// </summary>
        [STAThread]
        static void Main(Application mainApp)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
