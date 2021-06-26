using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Lekar : IDomenskiObjekat
    {
        public int LekarId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Specijalizacija { get; set; }



        #region ODO
        [Browsable(false)]

        public string NazivTabele => "lekar";
        [Browsable(false)]

        public string VrednostiZaInsert => $"'{Ime}', '{Prezime}', '{Specijalizacija}'";
        [Browsable(false)]

        public string VrednostZaUpdate => $"Ime = '{Ime}', " +
			$"Prezime = '{Prezime}', Specijalizacija = '{Specijalizacija}'";
		[Browsable(false)]

        public string KriterijumiZaPretragu => $"LekarId = {LekarId}";
        [Browsable(false)]

        public string PrimarniKljuc => "LekarId";
        [Browsable(false)]

        public IDictionary Kriterijumi { get; set; }
		[Browsable(false)]

		public string Identity => "LekarId";

		public bool AdekvatnoPopunjen()
        {
            if (Ime == null)
                return false;

            if (Prezime == null)
                return false;

            if (Specijalizacija == null)
                return false;

            return true;
        }
        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is Lekar))
                return;

            Lekar l = ido as Lekar;

            LekarId = l.LekarId;
            Ime = l.Ime;
            Prezime = l.Prezime;
            Specijalizacija = l.Specijalizacija;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            return;
        }

        public string UslovFiltera()
        {
            if (Kriterijumi == null)
                throw new ArgumentException("Dictionary nije postavljen.");

            return $"Ime LIKE '%{Kriterijumi["Ime"] as string}%' AND " +
             $"Prezime LIKE '%{Kriterijumi["Prezime"] as string}%'";
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> lekari = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
				Lekar l = new Lekar
				{
					LekarId = (int)reader["LekarId"],
					Ime = (string)reader["Ime"],
					Prezime = (string)reader["Prezime"],
					Specijalizacija = (string)reader["Specijalizacija"]
				};
                lekari.Add(l);
            }
            return lekari;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            return null;
        }
        #endregion

        public override bool Equals(object obj)
        {
            return obj is Lekar lekar &&
                   LekarId == lekar.LekarId;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return Ime + " " + Prezime;
		}
	}
}
