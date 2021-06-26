using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.LekarSO
{
	public class UpdateDoctorSO : OpstaSO
	{
		public Lekar Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			broker.Azuriraj(objekat);
			Result = objekat as Lekar;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
		
		}
	}
}
