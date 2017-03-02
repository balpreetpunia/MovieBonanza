using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Movies movies = new Movies();
        public static SplashForm MySplashForm;

        [STAThread]
        static void Main()
        {


            string exeDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Directory.SetCurrentDirectory(exeDir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.MySplashForm = new SplashForm();

            Application.Run(Program.MySplashForm);
        }
    }
}
