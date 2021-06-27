using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.PregledSO
{
	public class DeleteExaminSO : OpstaSO
	{
		public Pregled Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			Pregled p = objekat as Pregled;
			Console.WriteLine(p.StavkePregleda[0].Pregled.PregledId);
			//StavkaPregleda sp = p.StavkePregleda[0];
			broker.Obrisi(p.StavkePregleda[0]);
			broker.Obrisi(p);
			Result = p;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{

		}
	}
}
