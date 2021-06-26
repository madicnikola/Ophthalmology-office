using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.PacijentSO
{
	public class UpdatePacientSO : OpstaSO
	{
		public Pacijent Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			broker.Azuriraj(objekat);
			Result = objekat as Pacijent;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
		}
	}
}
