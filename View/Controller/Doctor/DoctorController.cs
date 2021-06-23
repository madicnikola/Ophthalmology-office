using System;
using System.Windows.Forms;
using View.UserControls;
using View.UserControls.mode;

namespace View.Controller.Doctor
{
	public class DoctorController
	{
		private UCLekar userControl;

		public UserControl open(UCMode mode)
		{
			userControl = new UCLekar();
			prepareUC(mode);

			return userControl;
		}

		private void prepareUC(UCMode mode)
		{
			if (mode.Equals(UCMode.ADD))
			{
				userControl.TxtId.Visible = false;
				userControl.LblId.Visible = false;


				userControl.BtnOmoguciIzmenu.Visible = false;
				userControl.BtnSacuvajPromene.Visible = false;
				userControl.BtnObrisi.Visible = false;

			}
			if (mode.Equals(UCMode.VIEW))
			{
				userControl.BtnOmoguciIzmenu.Visible = true;
				userControl.BtnSacuvajPromene.Visible = false;
				userControl.BtnObrisi.Visible = false;

			}
			if (mode.Equals(UCMode.UPDATE))
			{
				userControl.TxtId.ReadOnly = true;
				userControl.BtnSacuvajPromene.Visible = true;
				userControl.BtnObrisi.Visible = false;
				userControl.BtnSacuvaj.Visible = false;

			}
			if (mode.Equals(UCMode.DELETE))
			{
				userControl.BtnSacuvajPromene.Visible = false;
				userControl.BtnOmoguciIzmenu.Visible = false;
				userControl.BtnSacuvaj.Visible = false;
				userControl.BtnObrisi.Visible = true;

			}
		}
	}

}

