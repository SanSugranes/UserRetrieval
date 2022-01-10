using System;
using System.Windows.Forms;
using UserRetrieval.Controllers;
/// ETML
/// Author      : Santiago Sugrañes
/// Date        : 10.01.2022
/// Description : Main program entry

namespace UserRetrieval
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // MVC : Controller instance
            Controller ctrler = new Controller();

            // MVC : App run main view
            ctrler.RunMainView();
        }
    }
}
