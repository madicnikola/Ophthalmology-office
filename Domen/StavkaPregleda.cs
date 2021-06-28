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
		public TipIntervencije TipIntervencije { get; set; }
		public override bool Equals(object obj)
		{
			return obj is StavkaPregleda sp &&
				   EqualityComparer<Pregled>.Default.Equals(Pregled, sp.Pregled) &&
				   StavkaPregledaId == sp.StavkaPregledaId;
		}
		public override int GetHashCode()
		{
			var hashCode = -1934028390;
			hashCode = hashCode * -1521134295 + EqualityComparer<Pregled>.Default.GetHashCode(Pregled);
			hashCode = hashCode * -1521134295 + StavkaPregledaId.GetHashCode();
			return hashCode;
		}

		#region ODO

		[Browsable(false)]

		public string NazivTabele => "stavkaPregleda";
		[Browsable(false)]

		public string VrednostiZaInsert => $"{Pregled.PregledId}, '{Naziv}', {TipIntervencije.TipIntervId}";
		[Browsable(false)]

		public string VrednostZaUpdate => $"Naziv = '{Naziv}', TipIntervId= {TipIntervencije.TipIntervId}";
		[Browsable(false)]

		public string KriterijumiZaPretragu => $"PregledId = {Pregled.PregledId} AND StavkaPregledaId = {StavkaPregledaId}";
		[Browsable(false)]

		public string PrimarniKljuc => "PregledId, StavkaPregledaId";
		[Browsable(false)]

		public IDictionary Kriterijumi { get; set; }
		[Browsable(false)]

		public string Identity => "StavkaPregledaId";

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
			TipIntervencije = sp.TipIntervencije;
		}

		public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
		{
			if (ido is TipIntervencije)
			{
				TipIntervencije = (TipIntervencije)ido;
			}
			if (ido is Pregled)
			{
				Pregled = (Pregled)ido;
			}

		}

		public string UslovFiltera()
		{
			if (Kriterijumi == null)
				throw new ArgumentException("Dictionary nije postavljen.");

			if (Kriterijumi.Contains("PregledId"))
			{
				return $"PregledId = {Kriterijumi["PregledId"]}";
			}
			else
			{

			return $"StavkaPregledaId = {Kriterijumi["StavkaPregledaId"]}";
			}
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
					,
					TipIntervencije = new TipIntervencije{
						TipIntervId = (int)reader["TipIntervId"]
					}
				};

				list.Add(a);
			}
			return list;
		}

		public IDomenskiObjekat VratiPodDomen()
		{
			if (TipIntervencije != null && TipIntervencije.Opis == null)
				return TipIntervencije as IDomenskiObjekat;
			if (Pregled != null && Pregled.DatumPregleda == null)
				return Pregled as IDomenskiObjekat;

			return null;
		}
		#endregion
	}
}
