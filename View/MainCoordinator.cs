using Domen;
using System.Windows.Forms;
using View.Controller;

namespace View
{
	public class MainCoordinator
    {
        private MainController mainController;
		private DialogController dialogController;
		private LoginController loginController;

        public KorisnikSistema Korisnik { get; set; }

        private static MainCoordinator instance;
        private MainCoordinator() { }

        public static MainCoordinator Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        public void OpenLoginForm(string username = "Pera", string password = "Pera")
        {
            if(loginController == null)
			{
				loginController = new LoginController();
			}

			loginController.otvoriFrmLogin(username,password);
        }
		public void OpenRegisterForm()
		{
			if (loginController == null)
			{
				loginController = new LoginController();
			}
			loginController.otvoriFrmRegister();
		}

		public void OpenMainForm(KorisnikSistema korisnik)
        {
           if(mainController==null)
			{
				mainController = new MainController();
			}

			mainController.otvoriFrmMain(korisnik);
        }

		public void OpenDialog(UserControl userControl)
		{
			if (dialogController == null)
			{
				dialogController = new DialogController(mainController);
			}
			dialogController.openDialog(userControl);
		}
	}
}
