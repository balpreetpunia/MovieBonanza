using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
/// <summary>
/// App Name - Movie Bonanza
/// Author - Balpreet Punia
/// Student Id - 200335082
/// Creation Date - 2017-03-05
/// Description - This app lets user select a movie to stream and also lets them order a DVD for the same.
/// </summary>
 

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

            //Stores information about the movie
        public static Movies movies = new Movies();

        //New splash form
        public static SplashForm MySplashForm;

        [STAThread]
        static void Main()
        {


            string exeDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Directory.SetCurrentDirectory(exeDir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //New splash form
            Program.MySplashForm = new SplashForm();

            //Runs application by starting splash form
            Application.Run(Program.MySplashForm);
        }
    }
}
