using Domen;
using System;
using System.Collections.Generic;

namespace SistemskeOperacije.UserSO
{
	public class LoginSO : OpstaSO
    {
        public KorisnikSistema Result { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat entity)
        {
            KorisnikSistema k = entity as KorisnikSistema;
			List<IDomenskiObjekat> korisnici = broker.Pronadji(k);

			if (korisnici.Count == 0)
			{
				throw new Exception("Nije pronadjen korisnik sa takvim parametrima");
			}

			if (korisnici.Count > 1)
			{
				throw new Exception("Postoji visestruko podudaranje korisnika sa" +
					"tim parametrima u bazi");
			}

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
		}
	}
}
