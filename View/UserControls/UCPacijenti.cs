using System.Windows.Forms;
using View.Controller.Pacient;

namespace View.UserControls
{
	public partial class UCPacijenti : UserControl
	{
		public AllPacientsController AllPacientsController { get; set; }

		public UCPacijenti(AllPacientsController allPacientsController)
		{
			AllPacientsController = allPacientsController;
			InitializeComponent();
		}

		private void btnObrisi_Click(object sender, System.EventArgs e)
		{
			AllPacientsController.obrisiIzabranog();
		}

		private void btnPretrazi_Click(object sender, System.EventArgs e)
		{
			AllPacientsController.pretrazi();
		}

		private void btnPrikaziDetalje_Click(object sender, System.EventArgs e)
		{
			AllPacientsController.prikaziDetalje();
		}
	}
}
