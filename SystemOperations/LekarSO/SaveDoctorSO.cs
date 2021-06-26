using Domen;
using SistemskeOperacije;
using System;

namespace SistenskeOperacije.LekarSO
{
	public class SaveDoctorSO: OpstaSO
	{

		public Lekar Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			Lekar lekar = objekat as Lekar;
			lekar.LekarId = broker.Sacuvaj(lekar);
			Result = lekar;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
			if (!(objekat is Lekar))
			{
				throw new ArgumentException("Objekat nije tipa Lekar.");
			}

			Lekar l = objekat as Lekar;
			if (string.IsNullOrEmpty(l.Ime) || string.IsNullOrEmpty(l.Prezime))
			{
				throw new MissingFieldException("Ime i prezime moraju biti uneti!");
			}
		}
	}
}