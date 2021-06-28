﻿using Domen;
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
			foreach(StavkaPregleda sp in p.StavkePregleda)
			{
				broker.Obrisi(sp);
			}
			broker.Obrisi(p);
			Result = p;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{

		}
	}
}
