using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLib;
using System.IO;


namespace NodeListForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Loging.FileName= @"\NodeListForm\Logs.txt";
            
            Loging.CreateFile(Loging.FileName);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Loging.SetLog("Application was started", LogType.MESSAGE);
        }
    }
}
