using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;

namespace SistenskeOperacije
{
	public class SavePacientSO	 : OpstaSO
	{

		public Pacijent Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			Pacijent p = objekat as Pacijent;
			p.BrojKartonaId = broker.Sacuvaj(p);
			Result = p;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
			if (!(objekat is Pacijent))
			{
				throw new ArgumentException("Objekat nije tipa Pacijent.");
			}

			Pacijent p = objekat as Pacijent;
			if (string.IsNullOrEmpty(p.Ime) || string.IsNullOrEmpty(p.Prezime))
			{
				throw new MissingFieldException("Ime i prezime moraju biti uneti!");
			}
		}
	}
}