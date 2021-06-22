using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helpers;

namespace View
{
	public class MainController
	{
		private FrmMain frmMain;
		public KorisnikSistema Korisnik { get; set; }

		internal void OpenUCManufacturer(FrmMain frmMain)
		{
		}

		internal void OpenUCProduct(FrmMain frmMain)
		{
		}

		internal void OpenUCAllManufacturers(FrmMain frmMain)
		{
		}

		internal void OpenUCDataGridViewManufacturer(FrmMain frmMain)
		{
		}

		internal void CloseMainForm()
		{
			Communication.Communication.Instance.Disconnect();
			MainCoordinator.Instance.OpenLoginForm();
		}

		internal void OpenUCAddInvoice(FrmMain frmMain)
		{
		}

		internal void otvoriFrmMain(KorisnikSistema korisnik)
		{
			frmMain = new FrmMain(this);
			frmMain.lblKorisnik.Text = korisnik.Ime;
			frmMain.Show();
		}
	}
}
