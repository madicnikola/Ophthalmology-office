using Domen;
using System;
using System.Windows.Forms;
using View.Helpers;
using View.UserControls;
using View.UserControls.mode;

namespace View.Controller.Doctor
{
	public class DoctorController
	{
		public Lekar Lekar { get; set; }
		public UCLekar UserControl { get; set; }
		private MainController mainController;

		public DoctorController(MainController mainController)
		{
			this.mainController = mainController;
		}
		public UserControl open(UCMode mode)
		{
			UserControl = new UCLekar(this);
			prepareUC(mode);

			return UserControl;
		}

		private void prepareUC(UCMode mode)
		{
			if (mode.Equals(UCMode.ADD))
			{
				UserControl.TxtId.Visible = false;
				UserControl.LblId.Visible = false;


				UserControl.BtnOmoguciIzmenu.Visible = false;
				UserControl.BtnSacuvajPromene.Visible = false;
				UserControl.BtnObrisi.Visible = false;

			}
			if (mode.Equals(UCMode.VIEW))
			{
				UserControl.BtnOmoguciIzmenu.Visible = true;
				UserControl.BtnSacuvajPromene.Visible = false;
				UserControl.BtnObrisi.Visible = false;
				UserControl.BtnNazad.Visible = false;
				UserControl.BtnSacuvaj.Visible = false;


				populateFields();
				setFieldsReadOnly();
			}
			if (mode.Equals(UCMode.UPDATE))
			{
				UserControl.TxtId.ReadOnly = true;
				UserControl.BtnSacuvajPromene.Visible = true;
				UserControl.BtnObrisi.Visible = false;
				UserControl.BtnSacuvaj.Visible = false;
				UserControl.BtnNazad.Visible = false;

				populateFields();
				disableFieldsReadOnly();

			}
		}


		internal void sacuvaj(object sender, EventArgs e)
		{
			try
			{
				validate();
				Lekar l = napraviObjekat();
				l = Communication.Communication.Instance.saveDoctor(l);
				if (l == null)
				{
					throw new Exception("Sistem ne može da zapamti novog lekara");
				}
				MessageBox.Show($"Sistem je zapamtio lekara");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private Lekar napraviObjekat()
		{
			return new Lekar
			{
				Ime = UserControl.TxtIme.Text,
				Prezime = UserControl.TxtPrezime.Text,
				Specijalizacija = UserControl.TxtSpecijalizacija.Text
			};
		}

		private void validate()
		{
			if (!UserControlHelpers.EmptyFieldValidation(UserControl.TxtIme))
			{
				throw new Exception("Ime je obavezno polje.");
			}
			if (!UserControlHelpers.EmptyFieldValidation(UserControl.TxtPrezime))
			{
				throw new Exception("Prezime je obavezno polje.");
			}
			if (!UserControlHelpers.EmptyFieldValidation(UserControl.TxtSpecijalizacija))
			{
				throw new Exception("Specijalizacija je obavezno polje.");
			}

		}

		internal void nazad(object sender, EventArgs e)
		{
			UserControl.Dispose();
			mainController.openHomePanel();
		}
		private void populateFields()
		{
			UserControl.TxtId.Text = Lekar.LekarId.ToString();
			UserControl.TxtIme.Text = Lekar.Ime;
			UserControl.TxtPrezime.Text = Lekar.Prezime;
			UserControl.TxtSpecijalizacija.Text = Lekar.Specijalizacija;

		}
		private void setFieldsReadOnly()
		{
			UserControl.TxtId.ReadOnly = true;
			UserControl.TxtIme.ReadOnly = true;
			UserControl.TxtPrezime.ReadOnly = true;
			UserControl.TxtSpecijalizacija.ReadOnly = true;
		}
		private void disableFieldsReadOnly()
		{
			UserControl.TxtId.ReadOnly = false;
			UserControl.TxtIme.ReadOnly = false;
			UserControl.TxtPrezime.ReadOnly = false;
			UserControl.TxtSpecijalizacija.ReadOnly = false;
		}

	}

}

