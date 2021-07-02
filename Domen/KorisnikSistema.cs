using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
		[Browsable(false)]

		public string NazivTabele => "KorisnikSistema";
		[Browsable(false)]

		public string VrednostiZaInsert => $"'{Ime}', '{Prezime}', '{Username}', '{Password}'";
		[Browsable(false)]

		public string VrednostZaUpdate => null;
		[Browsable(false)]

		public string KriterijumiZaPretragu
		{
			get
			{
				{
					return $"Username = '{Username}' AND Password = '{Password}'";
				}
			}
		}
		[Browsable(false)]


		public string PrimarniKljuc => "KorisnikId";
		[Browsable(false)]

		public IDictionary Kriterijumi { get; set; }
		[Browsable(false)]

		public string Identity => "KorisnikId";
		[Browsable(false)]

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
		public override int GetHashCode()
		{
			var hashCode = -864778390;
			hashCode = hashCode * -1521134295 + KorisnikId.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ime);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prezime);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
			return hashCode;
		}

		public override string ToString()
		{
			return Ime + " " + Prezime;
		}
	}
}
