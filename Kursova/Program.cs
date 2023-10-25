using BackLibrary;
using System;
using System.Net;
using System.Windows.Forms;

namespace Kursova{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            User user = new User();

            Authorization page = new Authorization(user);
           
            
            Application.Run(page);
            Application.Exit();

            user.PushInfoUser();
            MessageBox.Show($"{user.GetProgress() }Exit");

        }
    }
}
