using System.Windows.Forms;
using View.UserControls;
using View.UserControls.mode;

namespace View.Controller
{
	public class ExaminController
	{
		private UCPregled userControl;

		public UserControl open(UCMode mode)
		{
			userControl = new UCPregled();
			prepareUC(mode);

			return userControl;
		}

		private void prepareUC(UCMode mode)
		{
			if (mode.Equals(UCMode.ADD))
			{
				userControl.TxtPregledId.Visible = false;
				userControl.LblPregledId.Visible = false;

			}
			if (mode.Equals(UCMode.VIEW))
			{
				userControl.BtnSacuvaj.Visible = false;
				userControl.BtnUnesi.Visible = false;
				userControl.BtnObrisiIzabrano.Visible = false;

				setFieldsReadOnly();
			}
			if (mode.Equals(UCMode.UPDATE))
			{
				disableFieldsReadOnly();
			}
			if (mode.Equals(UCMode.DELETE))
			{
				setFieldsReadOnly();
			}
		}
		private void setFieldsReadOnly()
		{
			userControl.TxtPregledId.ReadOnly = true;
			userControl.TxtBrojPregleda.ReadOnly = true;

			userControl.CbLekar.Enabled = false;
			userControl.DateTimePicker.Enabled = false;
			userControl.CbPacijent.Enabled = false;

			userControl.GbDodajStavku.Visible = false;
		}

		private void disableFieldsReadOnly()
		{
			userControl.TxtPregledId.ReadOnly = false;
			userControl.TxtBrojPregleda.ReadOnly = false;

			userControl.CbLekar.Enabled = true;
			userControl.DateTimePicker.Enabled = true;
			userControl.CbPacijent.Enabled = true;

			userControl.GbDodajStavku.Visible = true;
		}

	}
}