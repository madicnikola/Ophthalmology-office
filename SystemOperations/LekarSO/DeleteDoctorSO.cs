using Domen;

namespace SistemskeOperacije.LekarSO
{
	public class DeleteDoctorSO : OpstaSO
	{
		public Lekar Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			Lekar l = objekat as Lekar;
			broker.Obrisi(l);
			Result = l;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{

		}
	}
}
