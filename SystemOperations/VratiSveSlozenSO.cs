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
			if (rezultat.Count == 0)
				lista = new List<IDomenskiObjekat>();
			else
			{
				foreach (IDomenskiObjekat id in rezultat)
				{
					StavkaPregleda sp = new StavkaPregleda();
					sp.Pregled = (Pregled)id;
					List<IDomenskiObjekat> listaStavki = broker.Pronadji(sp);
						postaviPodDomen(listaStavki);
					foreach (IDomenskiObjekat id2 in listaStavki)
					{
						id.PostaviVrednostPodDomena(id2);
					}
				}
				postaviPodDomen(rezultat);
				lista = rezultat;
			}
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