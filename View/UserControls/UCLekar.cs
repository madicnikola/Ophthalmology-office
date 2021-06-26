using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller.Doctor;

namespace View.UserControls
{
	public partial class UCLekar : UserControl
	{
		public DoctorController DoctorController { get; set; }

		public UCLekar(DoctorController doctorController)
		{
			DoctorController = doctorController;
			InitializeComponent();
		}

		private void btnNazad_Click(object sender, EventArgs e)
		{
			DoctorController.nazad(sender, e);
		}

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{
			DoctorController.sacuvaj(sender, e);
		}

		private void btnOmoguciIzmenu_Click(object sender, EventArgs e)
		{
			DoctorController.omoguciIzmenu(sender, e);

		}

		private void btnSacuvajPromene_Click(object sender, EventArgs e)
		{
			DoctorController.update(sender, e);

		}
	}
}
