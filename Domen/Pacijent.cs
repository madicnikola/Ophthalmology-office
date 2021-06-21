using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Pacijent : IDomenskiObjekat
    {
        public int BrojKartonaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Telefon { get; set; }
        public string Oboljenja { get; set; }
        public bool Dioptrija { get; set; }
        public string Opis { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Pacijent pacijent &&
                   BrojKartonaId == pacijent.BrojKartonaId;
        }
        #region ODO
        [Browsable(false)]

        public string NazivTabele => "pacijent";
        [Browsable(false)]

        public string VrednostiZaInsert => $"{BrojKartonaId}, '{Ime}', '{Prezime}'," +
            $" '{DatumRodjenja}', '{Telefon}', '{Oboljenja}', '{Dioptrija}', '{Opis}'";
        [Browsable(false)]

        public string VrednostZaUpdate => $"Ime = '{Ime}', " +
            $"Prezime = '{Prezime}', DatumRodjenja = '{DatumRodjenja}', Telefon = '{Telefon}', " +
            $"Oboljenja = '{Oboljenja}', Dioptrija = '{Dioptrija}', " +
            $"Opis = '{Opis}'";
        [Browsable(false)]
        public string KriterijumiZaPretragu => $"BrojKartonaId = {BrojKartonaId}";

        [Browsable(false)]
        public string PrimarniKljuc => "BrojKartonaId";

        public IDictionary Kriterijumi { get; set; }

        public bool AdekvatnoPopunjen()
        {
            if (Ime == null)
                return false;

            if (Prezime == null)
                return false;

            if (DatumRodjenja == new DateTime())
                return false;

            if (Opis == null)
                return false;

            return true;
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is Pacijent))
                return;

            Pacijent p = ido as Pacijent;

            BrojKartonaId = p.BrojKartonaId;
            Ime = p.Ime;
            Prezime = p.Prezime;
            DatumRodjenja = p.DatumRodjenja;
            Telefon = p.Telefon;
            Oboljenja = p.Oboljenja;
            Dioptrija = p.Dioptrija;
            Opis = p.Opis;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            return;
        }

        public string UslovFiltera()
        {
            if (Kriterijumi == null)
                throw new ArgumentException("Dictionary nije postavljen.");

            return $"Prezime LIKE '%{Kriterijumi["Prezime"] as string}%' AND " +
                $"Ime LIKE '%{Kriterijumi["ime"] as string}%' AND ";
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> pacijenti = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Pacijent p = new Pacijent
                {
                    BrojKartonaId = (int)reader["BrojKartonaId"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    DatumRodjenja = (DateTime)reader["DatumRodjenja"],
                    Telefon = (string)reader["Telefon"],
                    Oboljenja = (string)reader["Oboljenja"],
                    Dioptrija = (bool)reader["Dioptrija"],
                    Opis = (string)reader["Opis"],

                };

                pacijenti.Add(p);
            }

            return pacijenti;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            return null;
        }


        #endregion
    }
}
