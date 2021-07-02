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

		private void btnOmoguciIzmenu_Click(object sender, System.EventArgs e)
		{
			PacientController.omoguciIzmenu(sender,e);
		}

		private void btnSacuvajPromene_Click(object sender, System.EventArgs e)
		{
			PacientController.update(sender,e);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			PacientController.otvoriKartonPacijenta(sender,e);
		}
	}
}
