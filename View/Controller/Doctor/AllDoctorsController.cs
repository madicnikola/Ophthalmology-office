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
	public class AllDoctorsController
	{
		public UCLekari UserControl { get; set; }
		private MainController mainController;
		BindingList<Lekar> lekariBindingList;

		public AllDoctorsController(MainController mainController)
		{
			this.mainController = mainController;
		}

		public UserControl open(UCMode mode)
		{
			UserControl = new UCLekari(this);
			InitUCAllDoctors(UserControl as UCLekari);
			prepareUC(mode);

			return UserControl;
		}

		public void InitUCAllDoctors(UCLekari ucLekar)
		{
			UserControl = ucLekar;
			lekariBindingList = ListConverter.convert<Lekar, IDomenskiObjekat>(Communication.Communication.Instance.GetAllDoctors());
			UserControl.DgvSviLekari.DataSource = lekariBindingList;
			UserControl.DgvSviLekari.Columns["LekarId"].HeaderText = "ID";
			UserControl.DgvSviLekari.Columns["specijalizacija"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		internal void prikaziDetalje()
		{
			try
			{
				DataGridViewRow row = UserControl.DgvSviLekari.SelectedRows[0];
				Lekar l = (Lekar)row.DataBoundItem;
				mainController.OpenUCLekarDetalji(l,UCMode.VIEW);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				MessageBox.Show("Niste odabrali red!");
			}
		}

		internal void pretraziLekare()
		{
			try
			{
				Lekar l = new Lekar();
				string imeKrit = UserControl.TxtImePretraga.Text.Trim();
				string prezimeKrit = UserControl.TxtPrezimePretraga.Text.Trim();
				l.Kriterijumi = new Dictionary<string, object>();
				l.Kriterijumi.Add("Ime", imeKrit);
				l.Kriterijumi.Add("Prezime", prezimeKrit);
				lekariBindingList = ListConverter
					.convert<Lekar, IDomenskiObjekat>(Communication.Communication.Instance.pretraziLekare(l));
				UserControl.DgvSviLekari.DataSource = lekariBindingList;
			}
			catch (SystemOperationException se)
			{
				MessageBox.Show(se.Message);

			}
		}

		internal void obrisiIzabranog(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow row = UserControl.DgvSviLekari.SelectedRows[0];
				Lekar l = (Lekar)row.DataBoundItem;
				l = Communication.Communication.Instance.deleteDoctor(l);
				lekariBindingList = ListConverter.convert<Lekar, IDomenskiObjekat>(Communication.Communication.Instance.GetAllDoctors());
				UserControl.DgvSviLekari.DataSource = lekariBindingList;
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

		private void prepareUC(UCMode mode)
		{
			if (mode.Equals(UCMode.VIEW))
			{

			}
			if (mode.Equals(UCMode.UPDATE))
			{

			}
		}
		private List<Lekar> convert(List<IDomenskiObjekat> list)
		{
			List<Lekar> l = new List<Lekar>();
			foreach (var e in list)
			{
				l.Add(e as Lekar);
			}
			return l;
		}
	}
}