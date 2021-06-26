using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
	public interface IDomenskiObjekat
    {
        string NazivTabele { get; }
        string VrednostiZaInsert { get; }
        string VrednostZaUpdate { get; }
        string KriterijumiZaPretragu { get; }
        string PrimarniKljuc { get;}
		string Identity { get; }
        IDictionary Kriterijumi { get; set; }

        List<IDomenskiObjekat> VratiListu(SqlDataReader reader);
        IDomenskiObjekat VratiPodDomen();
        void PostaviVrednost(IDomenskiObjekat ido);
        void PostaviVrednostPodDomena(IDomenskiObjekat ido);
        bool AdekvatnoPopunjen();
        string UslovFiltera();
    }
}
