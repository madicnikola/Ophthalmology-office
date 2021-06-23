using Domen;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using View.UserControls;
using View.UserControls.mode;
using View.Util;

namespace View.Controller
{
	public class AllDoctorsController
	{
		public UCLekari UserControl { get; set; }
		public BindingList<Lekar> lekari = new BindingList<Lekar>();

		public UserControl open(UCMode mode)
		{
			UserControl = new UCLekari();
			InitUCAllDoctors(UserControl as UCLekari);
			prepareUC(mode);

			return UserControl;
		}

		public void InitUCAllDoctors(UCLekari ucLekar)
		{
			UserControl = ucLekar;
			List<Lekar> lekari = ListConverter.convert<Lekar, IDomenskiObjekat>(Communication.Communication.Instance.GetAllDoctors());
			UserControl.DgvSviLekari.DataSource = lekari;
			UserControl.DgvSviLekari.Columns["LekarId"].HeaderText = "ID";
			UserControl.DgvSviLekari.Columns["specijalizacija"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

	

		private void prepareUC(UCMode mode)
		{
			if (mode.Equals(UCMode.VIEW))
			{

			}
			if (mode.Equals(UCMode.UPDATE))
			{

			}
			if (mode.Equals(UCMode.DELETE))
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