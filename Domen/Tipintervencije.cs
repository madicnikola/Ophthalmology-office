using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region ODO
        public string NazivTabele => "tipIntervencije";

        public string VrednostiZaInsert => $"{TipIntervId}, '{Opis}'";

        public string VrednostZaUpdate => null;

        public string KriterijumiZaPretragu => $"TipIntervencijeId = {TipIntervId}";

        public string PrimarniKljuc => "TipIntervencijeId";

        public IDictionary Kriterijumi { get; set; }

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
                    TipIntervId = (int)reader["TipIntervencijeId"],
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
