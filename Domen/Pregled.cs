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

        public Pregled()
        {
            StavkePregleda = new List<StavkaPregleda>();
        }

		public override string ToString()
		{
			return base.ToString();
		}




		#region ODO
		[Browsable(false)]

        public string NazivTabele => "pregled";
        [Browsable(false)]

        public string VrednostiZaInsert => $"{Lekar.LekarId}, {Pacijent.BrojKartonaId}," +
            $" '{DatumPregleda}', {BrojPregleda}";
        [Browsable(false)]

        public string VrednostZaUpdate => $"LekarId = {Lekar.LekarId}, " +
            $"PacijentId = {Pacijent.BrojKartonaId}, DatumPregleda = '{DatumPregleda}', BrojPregleda = {BrojPregleda}";
        [Browsable(false)]

        public string KriterijumiZaPretragu => $"PregledId = {PregledId} OR DatumPregleda='{DatumPregleda}'";
        [Browsable(false)]

        public string PrimarniKljuc => "PregledId";

		[Browsable(false)]

		public IDictionary Kriterijumi { get; set; }

		[Browsable(false)]

		public string Identity => "PregledId";

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
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            if (ido is Lekar)
            {
                Lekar = (Lekar)ido;
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
			if (Kriterijumi.Contains("PregledId"))
			{
				return $"DatumPregleda = '{(DateTime)Kriterijumi["DatumPregleda"]}' OR PregledId = {Kriterijumi["PregledId"]}";
			}else
				return $"DatumPregleda = '{(DateTime)Kriterijumi["DatumPregleda"]}'";

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
			if (Lekar != null && Lekar.Ime == null)
			{
				return Lekar as IDomenskiObjekat;
			}
			if(Pacijent != null && Pacijent.Ime == null)
			{
				return Pacijent as IDomenskiObjekat;
			}

			return null;
		}


        #endregion
        public override bool Equals(object obj)
        {
            return obj is Pregled pregled &&
                   PregledId == pregled.PregledId;
        }

		public override int GetHashCode()
		{
			return 2030567521 + PregledId.GetHashCode();
		}
	}
}
