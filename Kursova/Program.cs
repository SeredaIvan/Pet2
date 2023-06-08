using BackLibrary;
using System.Net;

namespace Kursova{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Authorization authorization = new Authorization();
            //authorization.Show();
            User user = new User();

            Authorization page = new Authorization(user);
            //MainMenu page = new MainMenu();

            
            Application.Run(page);
            Application.Exit();

            user.PushInfoUser();
            MessageBox.Show($"{user.GetProgress() }Exit");

        }
    }
}
