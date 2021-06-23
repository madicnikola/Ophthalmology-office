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
			List<IDomenskiObjekat> sviPregledi = broker.VratiSve(objekat);

			for (int i = 0; i < sviPregledi.Count;)
			{
				IDomenskiObjekat ido = sviPregledi[i];
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

			lista = sviPregledi;

		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
			if (!(objekat is Pregled))
			{
				throw new Exception("Objekat nije tipa Pregled!");
			}

		}
	}
}