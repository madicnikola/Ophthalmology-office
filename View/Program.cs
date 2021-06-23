using View.Exceptions;
using System;
using System.Windows.Forms;

namespace View
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
            // Application.Run(new FrmLogin());
            while (true)
            {
                try
                {
                    MainCoordinator.Instance.OpenLoginForm();
                    Application.Run();
                }
                catch (ServerException se)
                {
                    MessageBox.Show(se.Message);
                    Console.WriteLine(se.Message);
                }
            }
        }
    }
}
