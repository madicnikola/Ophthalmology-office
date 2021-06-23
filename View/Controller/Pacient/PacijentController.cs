using View.UserControls;
using View.UserControls.mode;
using System;
using System.Windows.Forms;
using View;

namespace View.Controller.Pacient
{
	public class PacientController
	{
		private UCPacijent userControl;

		public PacientController()
		{
		}



		public UserControl open(UCMode mode)
		{
			userControl = new UCPacijent();
			prepareUC(mode);

			return userControl;
		}

		private void prepareUC(UCMode mode)
		{
			if (mode.Equals(UCMode.ADD))
			{
				userControl.TxtBrojKartonaId.Visible = false;
				userControl.LblBrojKartonaId.Visible= false;


				userControl.BtnOmoguciIzmenu.Visible = false;
				userControl.BtnSacuvajPromene.Visible = false;
				userControl.BtnObrisi.Visible = false;

			}
			if (mode.Equals(UCMode.VIEW))
			{
				userControl.BtnOmoguciIzmenu.Visible = true;
				userControl.BtnSacuvajPromene.Visible = false;
				userControl.BtnObrisi.Visible = false;

				setFieldsReadOnly();
			}
			if (mode.Equals(UCMode.UPDATE))
			{
				userControl.TxtBrojKartonaId.ReadOnly = true;
				userControl.BtnSacuvajPromene.Visible = true;
				userControl.BtnObrisi.Visible = false;
				userControl.BtnSacuvaj.Visible = false;

				disableFieldsReadOnly();
			}
			if (mode.Equals(UCMode.DELETE))
			{
				userControl.BtnSacuvajPromene.Visible = false;
				userControl.BtnOmoguciIzmenu.Visible = false;
				userControl.BtnSacuvaj.Visible = false;
				userControl.BtnObrisi.Visible = true;

				setFieldsReadOnly();
			}
		}

	
		private void setFieldsReadOnly()
		{
			userControl.TxtBrojKartonaId.ReadOnly = true;

			userControl.TxtIme.ReadOnly = true;
			userControl.TxtPrezime.ReadOnly = true;
			userControl.DateTimePicker.Enabled = false;
			userControl.TxtTelefon.ReadOnly = true;


			userControl.TxtROpis.ReadOnly = true;
			userControl.TxtROboljenja.ReadOnly = true;
			userControl.CbDioptrija.Enabled = false;

		}

		private void disableFieldsReadOnly()
		{
			userControl.TxtBrojKartonaId.ReadOnly = false;

			userControl.TxtIme.ReadOnly = false;
			userControl.TxtPrezime.ReadOnly = false;
			userControl.DateTimePicker.Enabled = true;
			userControl.TxtTelefon.ReadOnly = false;


			userControl.TxtROpis.ReadOnly = false;
			userControl.TxtROboljenja.ReadOnly = false;
			userControl.CbDioptrija.Enabled = true;
		}

	}
}