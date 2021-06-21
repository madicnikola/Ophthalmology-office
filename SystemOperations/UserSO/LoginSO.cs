using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.UserSO
{
    public class LoginSO : OpstaSO
    {
        public KorisnikSistema Result { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat entity)
        {
            //  To-Do:
            // ? Result = repository.Search(entity);

            //dummy implementacija
            //ne sme ovako u projektnom radu!
            KorisnikSistema u = (KorisnikSistema)entity;
            if(u.Username =="pera" && u.Password == "pera")
            {
                u.KorisnikId = 1;
                u.Ime = "Pera";
                u.Prezime = "Peric";
                Result = u;
            }
            else
            {
                throw new Exception("Wrong user credentials!");
            }
        }

		protected override void Validacija(IDomenskiObjekat objekat)
		{
			return;
		}
	}
}
