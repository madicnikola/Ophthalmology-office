using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domen
{
	[Serializable]
    public class TipIntervencije : IDomenskiObjekat
    {
        public int TipIntervId { get; set; }
        public string Opis { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TipIntervencije intervencije &&
                   TipIntervId == intervencije.TipIntervId;
        }
		public override int GetHashCode()
		{
			return -98282121 + TipIntervId.GetHashCode();
		}

		public override string ToString()
		{
			return Opis;
		}


		#region ODO
		[Browsable(false)]

		public string NazivTabele => "tipIntervencije";
		[Browsable(false)]

		public string VrednostiZaInsert => $"'{Opis}'";
		[Browsable(false)]

		public string VrednostZaUpdate => $"Opis = '{Opis}'";
		[Browsable(false)]

		public string KriterijumiZaPretragu => $"TipIntervId = {TipIntervId}";
		[Browsable(false)]

		public string PrimarniKljuc => "TipIntervId";
		[Browsable(false)]

		public IDictionary Kriterijumi { get; set; }

		public string Identity => "TipIntervId";

		public bool AdekvatnoPopunjen()
        {
            throw new NotImplementedException();
        }
        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is TipIntervencije))
                return;

            TipIntervencije ti = (TipIntervencije)ido;

            TipIntervId = ti.TipIntervId;
            Opis = ti.Opis;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            return;
        }

        public string UslovFiltera()
        {
            return null;
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> list = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                TipIntervencije ti = new TipIntervencije
                {
                    TipIntervId = (int)reader["TipIntervId"],
                    Opis = (string)reader["Opis"],
                };

                list.Add(ti);
            }

            return list;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            return null;
        }
		#endregion
	}
}
