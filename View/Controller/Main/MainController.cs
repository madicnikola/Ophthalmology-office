using Domen;
using View.Controller.Doctor;
using View.Controller.Pacient;
using View.UserControls.mode;

namespace View.Controller
{
	public class MainController
	{
		private FrmMain frmMain;
		private PacientController pacientController;
		private AllPacientsController allPacientsController;

		private DoctorController doctorController;
		private AllDoctorsController allDoctorsController;

		private ExaminController examinController;
		private AllExaminController allExaminController;




		public KorisnikSistema Korisnik { get; set; }

		internal void openUCPacijent(FrmMain frmMain, UCMode mode)
		{
			if (pacientController == null)
			{
				pacientController = new PacientController();
			}
			frmMain.SetPanel(pacientController.open(mode));
		}

		internal void OpenUCAllPacients(FrmMain frmMain,UCMode mode)
		{
			if (allPacientsController == null)
			{
				allPacientsController = new AllPacientsController();
			}
			frmMain.SetPanel(allPacientsController.open(mode));
		}

		internal void CloseMainForm()
		{
			Communication.Communication.Instance.Disconnect();
			MainCoordinator.Instance.OpenLoginForm();
		}

		internal void otvoriFrmMain(KorisnikSistema korisnik)
		{
			frmMain = new FrmMain(this);
			frmMain.lblKorisnik.Text = korisnik.Ime;
			frmMain.Show();
		}

		internal void OpenUCLekar(FrmMain frmMain, UCMode mode)
		{
			if (doctorController == null)
			{
				doctorController = new DoctorController();
			}
			frmMain.SetPanel(doctorController.open(mode));
		}

		internal void OpenUCLekari(FrmMain frmMain, UCMode mode)
		{
			if (allDoctorsController == null)
			{
				allDoctorsController = new AllDoctorsController();
			}
			frmMain.SetPanel(allDoctorsController.open(mode));
		}
		internal void OpenUCPregled(FrmMain frmMain, UCMode mode)
		{
			if (examinController == null)
			{
				examinController = new ExaminController();
			}
			frmMain.SetPanel(examinController.open(mode));
		}

		internal void OpenUCPregledi(FrmMain frmMain, UCMode mode)
		{
			if (allExaminController == null)
			{
				allExaminController = new AllExaminController();
			}
			frmMain.SetPanel(allExaminController.open(mode));
		}
	}
}
