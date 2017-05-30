using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // CHANGE IT TO FileUserStore !!!!                
            var fileUserStore = new FileUserStore();
            var userService = new UserService(fileUserStore);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(userService,fileUserStore));
        }
    }
}
