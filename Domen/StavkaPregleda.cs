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
    public class StavkaPregleda : IDomenskiObjekat
    {
        public Pregled Pregled { get; set; }
        public int StavkaPregledaId { get; set; }
        public string Naziv { get; set; }
        public override bool Equals(object obj)
        {
            return obj is StavkaPregleda pregleda &&
                   EqualityComparer<Pregled>.Default.Equals(Pregled, pregleda.Pregled) &&
                   StavkaPregledaId == pregleda.StavkaPregledaId;
        }
        #region ODO

        [Browsable(false)]

        public string NazivTabele => "stavkaPregleda";
        [Browsable(false)]

        public string VrednostiZaInsert => $"{Pregled.PregledId}, {StavkaPregledaId}, '{Naziv}'";
        [Browsable(false)]

        public string VrednostZaUpdate => $"Naziv = '{Naziv}'";
        [Browsable(false)]

        public string KriterijumiZaPretragu => $"PregledId = {Pregled.PregledId} AND StavkaPregledaId = {StavkaPregledaId}";
        [Browsable(false)]

        public string PrimarniKljuc => "PregledId, StavkaPregledaId";

        public IDictionary Kriterijumi { get; set; }

        public bool AdekvatnoPopunjen()
        {
            return true;
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is StavkaPregleda))
                return;

            StavkaPregleda sp = (StavkaPregleda)ido;
            Pregled = sp.Pregled;
            StavkaPregledaId = sp.StavkaPregledaId;
            Naziv = sp.Naziv;
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
                StavkaPregleda a = new StavkaPregleda
                {
                    StavkaPregledaId = (int)reader["StavkaPregledaId"],
                    Naziv = (string)reader["Naziv"],
                    Pregled = new Pregled()
                    {
                        PregledId = (int)reader["PregledId"]
                    }
                };

                list.Add(a);
            }
            return list;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            if (Pregled != null)
            {
                return Pregled as IDomenskiObjekat;
            }

            return null;
        }

        #endregion
    }
}
