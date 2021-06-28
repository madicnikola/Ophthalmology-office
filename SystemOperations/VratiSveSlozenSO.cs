using Domen;
using System.Collections.Generic;
using System;

namespace SistemskeOperacije
{
	public class VratiSveSlozenSO : OpstaSO
	{
		public List<IDomenskiObjekat> lista;


		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			List<IDomenskiObjekat> rezultat = broker.VratiSve(objekat);
			foreach(IDomenskiObjekat id in rezultat)
			{
				StavkaPregleda sp = new StavkaPregleda();
				sp.Kriterijumi = new Dictionary<string, Object>();
				sp.Kriterijumi.Add("PregledId", ((Pregled)id).PregledId);
				List<IDomenskiObjekat> listaAsoc = broker.Filtriraj(sp);

				foreach (IDomenskiObjekat id2 in listaAsoc)
				{
					TipIntervencije ti = new TipIntervencije();
					ti.TipIntervId = ((StavkaPregleda)id2).TipIntervencije.TipIntervId;
					id2.PostaviVrednostPodDomena(broker.Pronadji(ti)[0]);
					id.PostaviVrednostPodDomena(id2);
				}
			}

			for (int i = 0; i < rezultat.Count;)
			{
				IDomenskiObjekat ido = rezultat[i];
				IDomenskiObjekat podDomen = ido.VratiPodDomen();

				while (podDomen != null)
				{
					podDomen.PostaviVrednost(broker.Pronadji(podDomen)[0]);

					while (podDomen.VratiPodDomen() != null)
					{
						IDomenskiObjekat podPod = podDomen.VratiPodDomen();

						podPod.PostaviVrednost(broker.Pronadji(podPod)[0]);
						podDomen.PostaviVrednostPodDomena(podPod);
					}

					ido.PostaviVrednostPodDomena(podDomen);
					podDomen = ido.VratiPodDomen();
				}

				i++;
			}

			lista = rezultat;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
			if (!(objekat is Pregled))
			{
				throw new Exception("Objekat nije tipa Pregled!");
			}

		}

		private void postaviPodDomen(List<IDomenskiObjekat> rezultat)
		{
			for (int i = 0; i < rezultat.Count;)
			{
				IDomenskiObjekat ido = rezultat[i];
				IDomenskiObjekat podDomen = ido.VratiPodDomen();

				while (podDomen != null)
				{
					podDomen.PostaviVrednost(broker.Pronadji(podDomen)[0]);

					while (podDomen.VratiPodDomen() != null)
					{
						IDomenskiObjekat podPod = podDomen.VratiPodDomen();

						podPod.PostaviVrednost(broker.Pronadji(podPod)[0]);
						podDomen.PostaviVrednostPodDomena(podPod);
					}

					ido.PostaviVrednostPodDomena(podDomen);
					podDomen = ido.VratiPodDomen();
				}

				i++;
			}

		}
	}
}