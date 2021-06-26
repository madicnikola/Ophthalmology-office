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
	public partial class UCLekari : UserControl
	{
		public AllDoctorsController AllDoctorsController { get; set; }

		public UCLekari(AllDoctorsController allDoctorsController)
		{
			AllDoctorsController = allDoctorsController;
			InitializeComponent();
		}

		private void btnObrisi_Click(object sender, EventArgs e)
		{
			AllDoctorsController.obrisiIzabranog(sender,e);
		}

		private void btnPretrazi_Click(object sender, EventArgs e)
		{
			AllDoctorsController.pretraziLekare();
		}

		private void btnPrikaziDetalje_Click(object sender, EventArgs e)
		{
			AllDoctorsController.prikaziDetalje();
		}
	}
}
