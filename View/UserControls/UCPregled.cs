using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View.UserControls
{
	public partial class UCPregled : UserControl
	{
		public ExaminController ExaminController { get; set; }

		public UCPregled(ExaminController examinController)
		{
			ExaminController = examinController;
			InitializeComponent();
		}
		private void btnNazad_Click(object sender, EventArgs e)
		{
			ExaminController.nazad(sender, e);
		}

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{
			ExaminController.sacuvaj(sender, e);
		}

		private void btnUnesi_Click(object sender, EventArgs e)
		{
			ExaminController.unesiStavku(sender, e);

		}

		private void btnObrisiIzabrano_Click(object sender, EventArgs e)
		{
			ExaminController.obrisiStavku(sender, e);
		}
	}
}
