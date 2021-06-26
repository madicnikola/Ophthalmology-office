using View.UserControls;
using View.UserControls.mode;
using System;
using System.Windows.Forms;
using View.Helpers;
using Domen;

namespace View.Controller.Pacient
{
	public class PacientController
	{
		public Pacijent Pacijent { get; set; }

		public UCPacijent UserControl { get; set; }
		private MainController mainController;

		public PacientController(MainController mainController)
		{
			this.mainController = mainController;
		}

		public UserControl open(UCMode mode)
		{
			UserControl = new UCPacijent(this);
			prepareUC(mode);

			return UserControl;
		}

		private void prepareUC(UCMode mode)
		{
			if (mode.Equals(UCMode.ADD))
			{
				UserControl.TxtBrojKartonaId.Visible = false;
				UserControl.LblBrojKartonaId.Visible = false;


				UserControl.BtnOmoguciIzmenu.Visible = false;
				UserControl.BtnSacuvajPromene.Visible = false;
				UserControl.BtnObrisi.Visible = false;

			}
			if (mode.Equals(UCMode.VIEW))
			{
				UserControl.BtnOmoguciIzmenu.Visible = true;
				UserControl.BtnSacuvajPromene.Visible = false;
				UserControl.BtnSacuvaj.Visible = false;
				UserControl.BtnObrisi.Visible = false;
				UserControl.BtnNazad.Visible = false;

				populateFields();
				setFieldsReadOnly();
			}
			if (mode.Equals(UCMode.UPDATE))
			{
				UserControl.TxtBrojKartonaId.ReadOnly = true;
				UserControl.BtnSacuvajPromene.Visible = true;
				UserControl.BtnObrisi.Visible = false;
				UserControl.BtnSacuvaj.Visible = false;

				disableFieldsReadOnly();
			}
		}

		private void populateFields()
		{
			UserControl.TxtBrojKartonaId.Text = Pacijent.BrojKartonaId.ToString();

			UserControl.TxtIme.Text = Pacijent.Ime;
			UserControl.TxtPrezime.Text = Pacijent.Prezime;
			UserControl.DateTimePicker.Value = Pacijent.DatumRodjenja;
			UserControl.TxtTelefon.Text = Pacijent.Telefon;


			UserControl.TxtROpis.Text = Pacijent.Opis;
			UserControl.TxtROboljenja.Text = Pacijent.Oboljenja;
			UserControl.CbDioptrija.Checked = Pacijent.Dioptrija;

		}

		internal void sacuvaj(object sender, EventArgs e)
		{
			try
			{
				validate();
				Pacijent p = napraviObjekat();
				p = Communication.Communication.Instance.savePacient(p);
				if (p == null)
				{
					throw new Exception("Sistem ne može da zapamti novog pacijenta");
				}
				MessageBox.Show($"Sistem je zapamtio pacijenta");
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private Pacijent napraviObjekat()
		{
			return new Pacijent
			{
				Ime = UserControl.TxtIme.Text,
				Prezime = UserControl.TxtPrezime.Text,
				DatumRodjenja = UserControl.DateTimePicker.Value,
				Telefon = UserControl.TxtTelefon.Text,
				Oboljenja = UserControl.TxtROboljenja.Text,
				Opis = UserControl.TxtROpis.Text,
				Dioptrija = UserControl.CbDioptrija.Checked
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
			if (!UserControlHelpers.EmptyFieldValidation(UserControl.TxtTelefon))
			{
				throw new Exception("Telefon je obavezno polje.");
			}

		}

		private void setFieldsReadOnly()
		{
			UserControl.TxtBrojKartonaId.ReadOnly = true;

			UserControl.TxtIme.ReadOnly = true;
			UserControl.TxtPrezime.ReadOnly = true;
			UserControl.DateTimePicker.Enabled = false;
			UserControl.TxtTelefon.ReadOnly = true;


			UserControl.TxtROpis.ReadOnly = true;
			UserControl.TxtROboljenja.ReadOnly = true;
			UserControl.CbDioptrija.Enabled = false;

		}

		private void disableFieldsReadOnly()
		{
			UserControl.TxtBrojKartonaId.ReadOnly = false;

			UserControl.TxtIme.ReadOnly = false;
			UserControl.TxtPrezime.ReadOnly = false;
			UserControl.DateTimePicker.Enabled = true;
			UserControl.TxtTelefon.ReadOnly = false;


			UserControl.TxtROpis.ReadOnly = false;
			UserControl.TxtROboljenja.ReadOnly = false;
			UserControl.CbDioptrija.Enabled = true;
		}

		internal void nazad(object sender, EventArgs e)
		{
			UserControl.Dispose();
			mainController.openHomePanel();
		}

	}
}