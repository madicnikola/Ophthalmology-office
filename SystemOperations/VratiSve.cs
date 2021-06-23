using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
	public class VratiSveSO : OpstaSO
	{
		public List<IDomenskiObjekat> lista;

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			List<IDomenskiObjekat> rezultat = broker.VratiSve(objekat);

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
		}
	}
}
