using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.PregledSO
{
	public class UpdateExaminSO : OpstaSO
	{
		public Pregled Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			Pregled p = objekat as Pregled;

			StavkaPregleda spPom = new StavkaPregleda();
			spPom.Kriterijumi = new Dictionary<string, Object>();
			spPom.Kriterijumi.Add("PregledId", ((Pregled)objekat).PregledId);
			List<IDomenskiObjekat> listaStavkiBaza = broker.Filtriraj(spPom);

			foreach (StavkaPregleda sp in listaStavkiBaza)
			{
				if (!p.StavkePregleda.Contains(sp))
				{
					broker.Obrisi(sp);
				}
			}
			foreach (StavkaPregleda sp in p.StavkePregleda)
			{
				if (!listaStavkiBaza.Contains(sp))
				{
					broker.Sacuvaj(sp);
				}
			}
			broker.Azuriraj(p);
			
			Result = p;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
		}
	}
}
