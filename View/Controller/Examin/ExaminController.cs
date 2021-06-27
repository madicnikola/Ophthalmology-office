using Domen;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using View.Helpers;
using View.UserControls;
using View.UserControls.mode;
using View.Util;

namespace View.Controller
{
	public class ExaminController
	{
		public Pregled Pregled { get; set; }
		private UCPregled UserControl { get; set; }
		private MainController mainController;
		private BindingList<StavkaPregleda> stavkePregleda = new BindingList<StavkaPregleda>();


		public ExaminController(MainController mainController)
		{
			this.mainController = mainController;
		}
		public UserControl open(UCMode mode)
		{
			UserControl = new UCPregled(this);
			clearFields();
			prepareUC(mode);

			return UserControl;
		}

		private void prepareUC(UCMode mode)
		{
			if (mode.Equals(UCMode.ADD))
			{
				UserControl.TxtPregledId.Visible = false;
				UserControl.LblPregledId.Visible = false;
				populateComboBoxes();
				populateDataGrid(stavkePregleda);

			}
			if (mode.Equals(UCMode.VIEW))
			{
				UserControl.BtnSacuvaj.Visible = false;
				UserControl.BtnUnesi.Visible = false;
				UserControl.BtnObrisiIzabrano.Visible = false;
				UserControl.BtnNazad.Visible = false;

				stavkePregleda = new BindingList<StavkaPregleda>(Pregled.StavkePregleda);
				populateDataGrid(stavkePregleda);
				populateFields();
				setFieldsReadOnly();
				
			}
			if (mode.Equals(UCMode.UPDATE))
			{
				disableFieldsReadOnly();
			}
		}

		internal void obrisiStavku(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow row = UserControl.DgvStavke.SelectedRows[0];
				StavkaPregleda sp = (StavkaPregleda)row.DataBoundItem;
				stavkePregleda.Remove(sp);
				updateStavkePregleda();
			}
			catch (Exception)
			{
				MessageBox.Show("Niste odabrali red!");
			}
		}

	
		internal void unesiStavku(object sender, EventArgs e)
		{
			try { 
			validateStavka();
			stavkePregleda.Add(new StavkaPregleda
			{
				Naziv = UserControl.TxtNaziv.Text,
				StavkaPregledaId = stavkePregleda.Count+1,
				TipIntervencije = UserControl.CbTipIntervencije.SelectedItem as TipIntervencije
			});
				UserControl.SelectNextControl(UserControl.DgvStavke, true, true, false, true);
				Application.DoEvents();
				UserControl.DgvStavke.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void validateStavka()
		{
			if (!UserControlHelpers.EmptyFieldValidation(UserControl.TxtNaziv))
			{
				throw new Exception("Naziv je obavezno polje.");
			}
			if(UserControl.CbTipIntervencije.SelectedItem == null)
			{
				throw new Exception("Tip intervencije je obavezno polje.");
			}
		}

		private void populateDataGrid(BindingList<StavkaPregleda> stavkePregleda)
		{
			updateStavkePregleda();
			UserControl.DgvStavke.DataSource = stavkePregleda;
			UserControl.DgvStavke.Columns["Naziv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			UserControl.DgvStavke.Columns["TipIntervencije"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			UserControl.DgvStavke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			UserControl.DgvStavke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

			UserControl.DgvStavke.Columns[0].HeaderText = "Pregled ID";
			UserControl.DgvStavke.Columns[1].HeaderText = "Rb";
			UserControl.DgvStavke.Columns["TipIntervencije"].HeaderText = "Opis intervencije";


		}

		private void populateComboBoxes()
		{
			try
			{
				BindingList<Lekar> lekari = ListConverter.convert<Lekar, IDomenskiObjekat>(Communication.Communication.Instance.GetAllDoctors());
				UserControl.CbLekar.Items.Clear();
				UserControl.CbLekar.Items.AddRange(lekari.ToArray());

				BindingList<Pacijent> pacijenti = ListConverter.convert<Pacijent, IDomenskiObjekat>(Communication.Communication.Instance.GetAllPacients());
				UserControl.CbPacijent.Items.Clear();
				UserControl.CbPacijent.Items.AddRange(pacijenti.ToArray());

				BindingList<TipIntervencije> intervencije = ListConverter.convert<TipIntervencije, IDomenskiObjekat>(Communication.Communication.Instance.GetAllInterventions());
				UserControl.CbTipIntervencije.Items.Clear();
				UserControl.CbTipIntervencije.Items.AddRange(intervencije.ToArray());
			}
			catch(Exception e)
			{
				Console.WriteLine("Greska prilikom ucitavanja proizvoda iz baze");
				Console.WriteLine(e.StackTrace);
			}
		}

		internal void sacuvaj(object sender, EventArgs e)
		{
			try
			{
				validate();
				Pregled pregled = new Pregled
				{
					DatumPregleda = UserControl.DateTimePicker.Value,
					BrojPregleda = Convert.ToInt32(UserControl.TxtBrojPregleda.Text),
					Pacijent = UserControl.CbPacijent.SelectedItem as Pacijent,
					Lekar = UserControl.CbLekar.SelectedItem as Lekar,
					StavkePregleda = stavkePregleda.ToList()
				};
				Console.WriteLine(pregled.DatumPregleda);
				Console.WriteLine(pregled.BrojPregleda);
				Console.WriteLine(pregled.Pacijent);
				Console.WriteLine(pregled.Lekar);
				foreach(StavkaPregleda sp in pregled.StavkePregleda){
					Console.WriteLine(sp.Naziv);
					Console.WriteLine(sp.TipIntervencije);

				}


				pregled = Communication.Communication.Instance.saveExamin(pregled);
				if (pregled == null)
				{
					throw new Exception("Sistem ne može da zapamti novi pregled");
				}
				MessageBox.Show($"Sistem je zapamtio pregled");
				clearFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void clearFields()
		{
			stavkePregleda.Clear();
			UserControl.TxtBrojPregleda.Clear();
			UserControl.TxtNaziv.Clear();
			UserControl.TxtPregledId.Clear();

		}

		internal void nazad(object sender, EventArgs e)
		{
			UserControl.Dispose();
			mainController.openHomePanel();
		}

		private void setFieldsReadOnly()
		{
			UserControl.TxtPregledId.ReadOnly = true;
			UserControl.TxtBrojPregleda.ReadOnly = true;

			UserControl.CbLekar.Enabled = false;
			UserControl.DateTimePicker.Enabled = false;
			UserControl.CbPacijent.Enabled = false;

			UserControl.GbDodajStavku.Visible = false;
		}

		private void disableFieldsReadOnly()
		{
			UserControl.TxtPregledId.ReadOnly = false;
			UserControl.TxtBrojPregleda.ReadOnly = false;

			UserControl.CbLekar.Enabled = true;
			UserControl.DateTimePicker.Enabled = true;
			UserControl.CbPacijent.Enabled = true;

			UserControl.GbDodajStavku.Visible = true;
		}

		private void validate()
		{

		}

		private Pregled napraviObjekat()
		{
			Console.WriteLine(Convert.ToInt32(UserControl.TxtBrojPregleda.Text));
			return new Pregled
			{
				DatumPregleda = UserControl.DateTimePicker.Value,
				BrojPregleda = Convert.ToInt32(UserControl.TxtBrojPregleda.Text),
				Pacijent = UserControl.CbPacijent.SelectedItem as Pacijent,
				Lekar = UserControl.CbPacijent.SelectedItem as Lekar,
				StavkePregleda = stavkePregleda.ToList()
			};
		}
		private void populateFields()
		{
			UserControl.TxtPregledId.Text = Pregled.PregledId.ToString();
			UserControl.TxtBrojPregleda.Text = Pregled.BrojPregleda.ToString();
			Console.WriteLine("Pacijent -----------"+ Pregled.Pacijent);
			Console.WriteLine(Pregled.Lekar);

			UserControl.CbPacijent.Text = Pregled.Pacijent.ToString();
			UserControl.CbLekar.Text= Pregled.Lekar.ToString();
			UserControl.DgvStavke.DataSource = Pregled.StavkePregleda;
		}


		private void updateStavkePregleda()
		{
			for (int i = 0; i < stavkePregleda.Count; i++)
			{
				stavkePregleda[i].StavkaPregledaId = i+1;
			}
		}


	}
}