using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using View.Exceptions;
using View.UserControls;
using View.UserControls.mode;
using View.Util;

namespace View.Controller
{
	public class AllExaminController
	{
		private MainController mainController;
		public UCPregledi UserControl { get; set; }
		BindingList<Pregled> preglediBindingList;

		public AllExaminController(MainController mainController)
		{
			this.mainController = mainController;
		}

		internal void obrisiIzabrani(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow row = UserControl.DgvSviPregledi.SelectedRows[0];
				Pregled p = (Pregled)row.DataBoundItem;
				p = Communication.Communication.Instance.deleteExamin(p);
				preglediBindingList = ListConverter.convert<Pregled, IDomenskiObjekat>(Communication.Communication.Instance.GetAllExamins());
				UserControl.DgvSviPregledi.DataSource = preglediBindingList;

			}
			catch (SystemOperationException se)
			{
				MessageBox.Show(se.Message);

			}
			catch (Exception)
			{
				MessageBox.Show("Niste odabrali red!");
			}
		}

		internal void prikaziDetalje()
		{
			try
			{
				DataGridViewRow row = UserControl.DgvSviPregledi.SelectedRows[0];
				Pregled pregled = (Pregled)row.DataBoundItem;
				mainController.OpenUCPregledDetalji(pregled, UCMode.VIEW);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				MessageBox.Show("Niste odabrali red!");
			}
		}

		internal void pretraziPreglede()
		{
			Pregled pregled = new Pregled();
			try
			{
				pregled.Kriterijumi = new Dictionary<string, object>();
				string pregledIdStr = UserControl.TxtPregledId.Text;
				if (pregledIdStr != null && pregledIdStr.Length != 0)
				{
					int pregledId = Convert.ToInt32(UserControl.TxtPregledId.Text);
					pregled.Kriterijumi.Add("PregledId", pregledId);
					

				}
				DateTime datumKrit = UserControl.DateTimePicker.Value;
				pregled.Kriterijumi.Add("DatumPregleda", datumKrit);

				preglediBindingList = ListConverter
						.convert<Pregled, IDomenskiObjekat>(Communication.Communication.Instance.pretraziPreglede(pregled));
				UserControl.DgvSviPregledi.DataSource = preglediBindingList;
			}
			catch (SystemOperationException se)
			{
				preglediBindingList.Clear();
				MessageBox.Show(se.Message);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Pregled ID mora biti broj");
				Console.WriteLine(ex.StackTrace);
			}
			
		}

        public void pretraziPregledeZaKartonPacijenta(Pacijent pacijent)
		{
			Pregled pregled = new Pregled();
			try
			{
				pregled.Kriterijumi = new Dictionary<string, object>();
				pregled.Kriterijumi.Add("BrojKartonaId", pacijent.BrojKartonaId);
				preglediBindingList = ListConverter
						.convert<Pregled, IDomenskiObjekat>(Communication.Communication.Instance.pretraziPreglede(pregled));
				UserControl.DgvSviPregledi.DataSource = preglediBindingList;
			}
			catch (SystemOperationException se)
			{
				preglediBindingList.Clear();
				MessageBox.Show(se.Message);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Pregled ID mora biti broj");
				Console.WriteLine(ex.StackTrace);
			}

		}

		internal void refresh()
		{
			preglediBindingList = ListConverter.convert<Pregled, IDomenskiObjekat>(Communication.Communication.Instance.GetAllExamins());
			UserControl.DgvSviPregledi.DataSource = preglediBindingList;
		}

		internal void InitUCAllExamins(UCPregledi ucPregledi)
		{
			UserControl = ucPregledi as UCPregledi;
			preglediBindingList = ListConverter.convert<Pregled, IDomenskiObjekat>(Communication.Communication.Instance.GetAllExamins());
			UserControl.DgvSviPregledi.DataSource = preglediBindingList;

			nameColumns();
			resizeColumns();
		}



		public UserControl open(UCMode mode)
		{
			UserControl = new UCPregledi(this);
			InitUCAllExamins(UserControl as UCPregledi);
			prepareUC(mode);

			return UserControl;
		}
		internal UserControl openKartonPacijenta(Pacijent pacijent)
		{
			UserControl = new UCPregledi(this);
			pretraziPregledeZaKartonPacijenta(pacijent);

			nameColumns();
			resizeColumns();

			return UserControl;
		}

		private void prepareUC(UCMode mode)
		{
		}
		private List<Pregled> convert(List<IDomenskiObjekat> list)
		{
			List<Pregled> l = new List<Pregled>();
			foreach (var e in list)
			{
				l.Add(e as Pregled);
			}
			return l;
		}
		private void resizeColumns()
		{
			UserControl.DgvSviPregledi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			UserControl.DgvSviPregledi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			UserControl.DgvSviPregledi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			UserControl.DgvSviPregledi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			UserControl.DgvSviPregledi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}

		private void nameColumns()
		{
			UserControl.DgvSviPregledi.Columns[0].HeaderText = "ID";
			UserControl.DgvSviPregledi.Columns[1].HeaderText = "Lekar";
			UserControl.DgvSviPregledi.Columns[2].HeaderText = "Pacijent";
			UserControl.DgvSviPregledi.Columns[3].HeaderText = "Datum Pregleda";
			UserControl.DgvSviPregledi.Columns[4].HeaderText = "Broj Pregleda";
		}
	}
}
