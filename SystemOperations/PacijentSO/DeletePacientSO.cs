using Domen;

namespace SistemskeOperacije.PacijentSO
{
	public class DeletePacientSO : OpstaSO
	{
		public Pacijent Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			Pacijent p = objekat as Pacijent;
			broker.Obrisi(p);
			Result = p;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{

		}
	}
}