using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using View.Exceptions;

namespace SistemskeOperacije.PacijentSO
{
	public class FilterSO : OpstaSO
	{
		public List<IDomenskiObjekat> Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			Result = broker.Filtriraj(objekat);
			for (int i = 0; i < Result.Count;)
			{
				IDomenskiObjekat ido = Result[i];
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
			if(Result.Count == 0)
			{
				throw new SystemOperationException();
			}
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{

		}
	}
}
