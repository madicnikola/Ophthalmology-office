using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class KorisnikSistema : IDomenskiObjekat
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            return obj is KorisnikSistema sistema &&
                   Username == sistema.Username &&
                   Password == sistema.Password;
        }

        #region ODO
        public string NazivTabele => "korisnikSistema";

        public string VrednostiZaInsert => $"{KorisnikId}, '{Ime}', '{Prezime}', '{Username}', '{Password}'";

        public string VrednostZaUpdate => null;

        public string KriterijumiZaPretragu => null;

        public string PrimarniKljuc => "KorisnikId";

        public IDictionary Kriterijumi { get; set; }



        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> korisnici = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                KorisnikSistema k = new KorisnikSistema
                {
                    KorisnikId = (int)reader["KorisnikId"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"]
                };

                korisnici.Add(k);
            }

            return korisnici;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            throw null;
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is KorisnikSistema))
                return;

            KorisnikSistema k = (KorisnikSistema)ido;

            KorisnikId = k.KorisnikId;
            Ime = k.Ime;
            Prezime = k.Prezime;
            Username = k.Username;
            Password = k.Password;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            return;
        }

        public bool AdekvatnoPopunjen()
        {
            if (KorisnikId <= 0)
                return false;

            if (Ime == null)
                return false;

            if (Prezime == null)
                return false;

            if (Username == null)
                return false;

            if (Password == null)
                return false;

            return true;
        }

        public string UslovFiltera()
        {
            return null;
        }

        #endregion
    }
}
