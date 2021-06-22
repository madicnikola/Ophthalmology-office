using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Domen;
using Forme.Controller;

namespace View
{
    public class MainCoordinator
    {
        private MainController mainController;
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

        public void OpenLoginForm()
        {
            if(loginController == null)
			{
				loginController = new LoginController();
			}

			loginController.otvoriFrmLogin();
        }

        public void OpenMainForm(KorisnikSistema korisnik)
        {
           if(mainController==null)
			{
				mainController = new MainController();
			}

			mainController.otvoriFrmMain(korisnik);
        }
    }
}
