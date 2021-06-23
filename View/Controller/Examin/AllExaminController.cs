using Domen;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using View.UserControls;
using View.UserControls.mode;
using View.Util;

namespace View.Controller
{
	public class AllExaminController
	{

		public UCPregledi UserControl { get; set; }
		public BindingList<Pregled> pregledi = new BindingList<Pregled>();
		internal void InitUCAllExamins(UCPregledi ucPregledi)
		{
			UserControl = ucPregledi as UCPregledi;
			List<Pregled> pregledi = ListConverter.convert<Pregled, IDomenskiObjekat>(Communication.Communication.Instance.GetAllExamins());
			UserControl.DgvSviPregledi.DataSource = pregledi;

			nameColumns();
			resizeColumns();
		}



		public UserControl open(UCMode mode)
		{
			UserControl = new UCPregledi();
			InitUCAllExamins(UserControl as UCPregledi);
			prepareUC(mode);

			return UserControl;
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
