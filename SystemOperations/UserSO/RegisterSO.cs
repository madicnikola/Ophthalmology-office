using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.UserSO
{
	public class RegisterSO : OpstaSO
	{
		public KorisnikSistema Result { get; private set; }

		protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat objekat)
		{
			KorisnikSistema k = objekat as KorisnikSistema;
			List<IDomenskiObjekat> korisnici = broker.Pronadji(k);

			if (korisnici.Count == 0)
			{
				broker.Sacuvaj(k);
			}

			if (korisnici.Count >= 1)
			{
				throw new Exception("Postoji podudaranje korisnika sa" +
					"tim parametrima u bazi");
			}
			korisnici = broker.Pronadji(k);
			Result = korisnici[0] as KorisnikSistema;
		}

		protected override void Validacija(IDomenskiObjekat objekat)
		{
			if (!(objekat is KorisnikSistema))
			{
				throw new ArgumentException("Objekat nije tipa KorisnikSistema.");
			}

			KorisnikSistema k = objekat as KorisnikSistema;

			if (string.IsNullOrEmpty(k.Username) || string.IsNullOrEmpty(k.Password))
			{
				throw new MissingFieldException("Korisnicko ime i lozinka moraju biti uneti!");
			}
			if (string.IsNullOrEmpty(k.Ime) || string.IsNullOrEmpty(k.Prezime))
			{
				throw new MissingFieldException("Ime i prezime moraju biti uneti!");
			}

		}
	}
}
