using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using View.Exceptions;
using View.UserControls;
using View.UserControls.mode;
using View.Util;

namespace View.Controller.Pacient
{
	public class AllPacientsController
	{
		private MainController mainController;
		public UCPacijenti UserControl { get; set; }
		BindingList<Pacijent> pacijentiBindingList;

		public AllPacientsController(MainController mainController)
		{
			this.mainController = mainController;
		}

		internal void obrisiIzabranog()
		{
			try
			{
				DataGridViewRow row = UserControl.DgvPacijenti.SelectedRows[0];
				Pacijent p = (Pacijent)row.DataBoundItem;
				p = Communication.Communication.Instance.deletePacient(p);
				pacijentiBindingList = ListConverter.convert<Pacijent, IDomenskiObjekat>(Communication.Communication.Instance.GetAllPacients());
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

		public void prikaziDetalje()
		{
			try
			{
				DataGridViewRow row = UserControl.DgvPacijenti.SelectedRows[0];
				Pacijent pacijent = (Pacijent)row.DataBoundItem;
				mainController.OpenUCPacijentDetalji(pacijent, UCMode.VIEW);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				MessageBox.Show("Niste odabrali red!");
			}
		}

		internal void pretrazi()
		{
			try
			{
				Pacijent p = new Pacijent();
				string imeKrit = UserControl.TxtImePretraga.Text.Trim();
				string prezimeKrit = UserControl.TxtPrezimePretraga.Text.Trim();
				p.Kriterijumi = new Dictionary<string, object>();
				p.Kriterijumi.Add("Ime", imeKrit);
				p.Kriterijumi.Add("Prezime", prezimeKrit);
				pacijentiBindingList = ListConverter
					.convert<Pacijent, IDomenskiObjekat>(Communication.Communication.Instance.pretraziPacijente(p));
				UserControl.DgvPacijenti.DataSource = pacijentiBindingList;
			}
			catch (SystemOperationException se)
			{
				MessageBox.Show(se.Message);

			}
		}
		public UserControl open(UCMode mode)
		{
			UserControl = new UCPacijenti(this);
			InitUCAllPacients(UserControl as UCPacijenti);
			prepareUC(mode);

			return UserControl;
		}
		public void InitUCAllPacients(UCPacijenti ucPacijenti)
		{
			UserControl = ucPacijenti;
			pacijentiBindingList = ListConverter.convert<Pacijent, IDomenskiObjekat>(Communication.Communication.Instance.GetAllPacients());
			UserControl.DgvPacijenti.DataSource = pacijentiBindingList;
			UserControl.DgvPacijenti.Columns["BrojKartonaId"].HeaderText = "Br Kartona";
			UserControl.DgvPacijenti.Columns["DatumRodjenja"].HeaderText = "Datum Rodjenja";
			UserControl.DgvPacijenti.Columns["Dioptrija"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			UserControl.DgvPacijenti.Columns["Opis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

		}
		private void prepareUC(UCMode mode)
		{
		}
		private List<Pacijent> convert(List<IDomenskiObjekat> list)
		{
			List<Pacijent> l = new List<Pacijent>();
			foreach (var e in list)
			{
				l.Add(e as Pacijent);
			}
			return l;
		}
	}
}
