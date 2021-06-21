using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Pregled : IDomenskiObjekat
    {
        public int PregledId { get; set; }
        public Lekar Lekar { get; set; }
        public Pacijent Pacijent { get; set; }
        public DateTime DatumPregleda { get; set; }
        public int BrojPregleda { get; set; }

        public List<StavkaPregleda> StavkePregleda { get; set; }

        public KorisnikSistema Korisnik { get; set; }

        public Pregled()
        {
            StavkePregleda = new List<StavkaPregleda>();
        }


        #region ODO
        [Browsable(false)]

        public string NazivTabele => "pregled";
        [Browsable(false)]

        public string VrednostiZaInsert => $"{PregledId}, {Pacijent.BrojKartonaId}, {Lekar.LekarId}," +
            $" '{DatumPregleda}', {BrojPregleda}, {Korisnik.KorisnikId}";
        [Browsable(false)]

        public string VrednostZaUpdate => $"LekarId = {Lekar.LekarId}, " +
            $"PacijentId = {Pacijent.BrojKartonaId}, DatumPregleada = '{DatumPregleda}', BrojPregleda = {BrojPregleda}, " +
            $"KorisnikId = {Korisnik.KorisnikId}";
        [Browsable(false)]

        public string KriterijumiZaPretragu => $"PregledId = {PregledId}";
        [Browsable(false)]

        public string PrimarniKljuc => "PregledId";

        public IDictionary Kriterijumi { get; set; }

        public bool AdekvatnoPopunjen()
        {

            if (DatumPregleda == null)
                return false;

            if (BrojPregleda <= 0)
                return false;

            return true;
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is Pregled))
                return;

            Pregled p = (Pregled)ido;

            PregledId = p.PregledId;
            Lekar = p.Lekar;
            Pacijent = p.Pacijent;
            DatumPregleda = p.DatumPregleda;
            BrojPregleda = p.BrojPregleda;
            Korisnik = p.Korisnik;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            if (ido is Lekar)
            {
                Lekar = (Lekar)ido;
            }

            if (ido is KorisnikSistema)
            {
                Korisnik = (KorisnikSistema)ido;
            }

            if (ido is Pacijent)
            {
                Pacijent = (Pacijent)ido;
            }

            if (ido is StavkaPregleda)
            {
                StavkePregleda.Add((StavkaPregleda)ido);
            }
        }

        public string UslovFiltera()
        {
            if (Kriterijumi == null)
                throw new ArgumentException("Dictionary nije postavljen.");

            return $"Datum <= '{(DateTime)Kriterijumi["datum"]}'";
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> pregledi = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Pregled p = new Pregled
                {
                    PregledId = (int)reader["PregledId"],
                    DatumPregleda = (DateTime)reader["DatumPregleda"],
                    BrojPregleda = (int)reader["BrojPregleda"],
                    Lekar = new Lekar()
                    {
                        LekarId = (int)reader["LekarId"]
                    },
                    Korisnik = new KorisnikSistema()
                    {
                        KorisnikId = (int)reader["KorisnikId"]
                    },
                    Pacijent = new Pacijent()
                    {
                        BrojKartonaId = (int)reader["BrojKartonaId"]
                    }
                };

                pregledi.Add(p);
            }

            return pregledi;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            return null;
        }


        #endregion
        public override bool Equals(object obj)
        {
            return obj is Pregled pregled &&
                   PregledId == pregled.PregledId;
        }
    }
}
