using BrokerBazePodataka;
using Domen;
using System;

namespace SistemskeOperacije
{
	public abstract class OpstaSO
	{
		protected Broker broker = new Broker();

		public void IzvrsiSO(IDomenskiObjekat objekat)
		{
			try
			{
				broker.OtvoriKonekciju();
				broker.PokreniTransakciju();

				Validacija(objekat);
				IzvrsiKonkretnuOperaciju(objekat);

				broker.Commit();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				broker.Rollback();
			}
			finally
			{
				broker.ZatvoriKonekciju();
			}
		}

		protected abstract void Validacija(IDomenskiObjekat objekat);
		protected abstract void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat);
	}
}
