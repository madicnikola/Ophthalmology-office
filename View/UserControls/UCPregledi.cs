using System.Windows.Forms;
using View.Controller;

namespace View.UserControls
{
	public partial class UCPregledi : UserControl
	{
		public AllExaminController AllExaminController { get; set; }

		public UCPregledi(AllExaminController allExaminController)
		{
			AllExaminController= allExaminController;
			InitializeComponent();
		}

		private void btnObrisi_Click(object sender, System.EventArgs e)
		{
			AllExaminController.obrisiIzabrani(sender,e);
		}

		private void btnPretrazi_Click(object sender, System.EventArgs e)
		{
			AllExaminController.pretraziPreglede();
		}

		private void btnPrikaziDetalje_Click(object sender, System.EventArgs e)
		{
			AllExaminController.prikaziDetalje();

		}
	}
}
