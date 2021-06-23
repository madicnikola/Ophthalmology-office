using Domen;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using View.UserControls;
using View.UserControls.mode;
using View.Util;

namespace View.Controller.Pacient
{
	public class AllPacientsController
	{
		public UCPacijenti UserControl { get; set; }
		public BindingList<Pacijent> pacijenti = new BindingList<Pacijent>();
		public UserControl open(UCMode mode)
		{
			UserControl = new UCPacijenti();
			InitUCAllPacients(UserControl as UCPacijenti);
			prepareUC(mode);

			return UserControl;
		}
		public void InitUCAllPacients(UCPacijenti ucPacijenti)
		{
			UserControl = ucPacijenti;
			List<Pacijent> pacijenti = ListConverter.convert<Pacijent, IDomenskiObjekat>(Communication.Communication.Instance.GetAllPacients());
			UserControl.DgvPacijenti.DataSource = pacijenti;
			UserControl.DgvPacijenti.Columns["BrojKartonaId"].HeaderText = "Br Kartona";
			UserControl.DgvPacijenti.Columns["DatumRodjenja"].HeaderText = "Datum Rodjenja";
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
