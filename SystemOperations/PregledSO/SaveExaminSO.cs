using Domen;
using SistemskeOperacije;
using System;

namespace SistenskeOperacije.PregledSO
{
	public class SaveExaminSO : OpstaSO
	{

		public Pregled Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			Pregled pregled = objekat as Pregled;
			pregled.PregledId = broker.Sacuvaj(pregled);
			Console.WriteLine(pregled.PregledId);	
			foreach(StavkaPregleda sp in pregled.StavkePregleda)
			{
				sp.Pregled = pregled;
				sp.StavkaPregledaId = broker.Sacuvaj(sp);
				Console.WriteLine(sp.StavkaPregledaId);
			}
			Result = pregled;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
			if (!(objekat is Pregled))
			{
				throw new ArgumentException("Objekat nije tipa Pregled.");
			}

			Pregled pregled = objekat as Pregled;
			if (string.IsNullOrEmpty(pregled.DatumPregleda.ToString()) || string.IsNullOrEmpty(pregled.BrojPregleda.ToString()))
			{
				throw new MissingFieldException("Datum i broj moraju biti uneti!");
			}
		}
	}
}