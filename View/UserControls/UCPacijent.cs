using System.Windows.Forms;
using View.Controller.Pacient;

namespace View.UserControls
{
	public partial class UCPacijent : UserControl
	{
		public PacientController PacientController { get; set; }

		public UCPacijent(PacientController pacientController)
		{
			PacientController = pacientController;
			InitializeComponent();
		}

		private void btnSacuvaj_Click(object sender, System.EventArgs e)
		{
			PacientController.sacuvaj(sender,e);
		}

		private void btnNazad_Click(object sender, System.EventArgs e)
		{
			PacientController.nazad(sender,e);
		}
	}
}
