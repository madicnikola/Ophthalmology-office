using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBazePodataka
{
	public class Broker
	{
		private SqlConnection konekcija;
		private SqlTransaction transakcija;

		public Broker()
		{
			konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=oft-office-db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}

		public void OtvoriKonekciju()
		{
			konekcija.Open();
		}

		public void ZatvoriKonekciju()
		{
			konekcija.Close();
		}

		public void PokreniTransakciju()
		{
			transakcija = konekcija.BeginTransaction();
		}

		public void Commit()
		{
			transakcija.Commit();
		}

		public void Rollback()
		{
			transakcija.Rollback();
		}

		public int Obrisi(IDomenskiObjekat objekat)
		{
			SqlCommand command = new SqlCommand("", konekcija, transakcija);
			command.CommandText = $"DELETE FROM {objekat.NazivTabele} WHERE" +
				$" {objekat.KriterijumiZaPretragu}";
			return command.ExecuteNonQuery();
		}

		public int Sacuvaj(IDomenskiObjekat objekat)
		{
			SqlCommand command = new SqlCommand("", konekcija, transakcija);
			command.CommandText = $"INSERT INTO {objekat.NazivTabele} VALUES" +
				$" ({objekat.VrednostiZaInsert})";
			return command.ExecuteNonQuery();
		}

		public object VratiNajveciID(IDomenskiObjekat objekat)
		{
			SqlCommand command = new SqlCommand("", konekcija, transakcija);
			command.CommandText = $"SELECT MAX({objekat.PrimarniKljuc}) FROM " +
				$"{objekat.NazivTabele}";
			object rez = command.ExecuteScalar();
			return rez;
		}

		public List<IDomenskiObjekat> VratiSve(IDomenskiObjekat objekat)
		{
			SqlCommand command = new SqlCommand("", konekcija, transakcija);
			command.CommandText = $"SELECT * FROM {objekat.NazivTabele}";
			SqlDataReader reader = command.ExecuteReader();
			List<IDomenskiObjekat> rezultat = objekat.VratiListu(reader);
			reader.Close();
			return rezultat;
		}

		public List<IDomenskiObjekat> Pronadji(IDomenskiObjekat objekat)
		{
			SqlCommand command = new SqlCommand("", konekcija, transakcija);
			command.CommandText = $"SELECT * FROM {objekat.NazivTabele} " +
				$"WHERE {objekat.KriterijumiZaPretragu}";
			SqlDataReader reader = command.ExecuteReader();
			List<IDomenskiObjekat> rezultat = objekat.VratiListu(reader);
			reader.Close();
			return rezultat;
		}

		public List<IDomenskiObjekat> Filtriaj(IDomenskiObjekat objekat)
		{
			SqlCommand command = new SqlCommand("", konekcija, transakcija);
			command.CommandText = $"SELECT * FROM {objekat.NazivTabele} " +
				$"WHERE {objekat.UslovFiltera()}";
			SqlDataReader reader = command.ExecuteReader();
			List<IDomenskiObjekat> rezultat = objekat.VratiListu(reader);
			reader.Close();
			return rezultat;
		}

		public object Azuriraj(IDomenskiObjekat objekat)
		{
			SqlCommand command = new SqlCommand("", konekcija, transakcija);
			command.CommandText = $"UPDATE {objekat.NazivTabele} SET {objekat.VrednostZaUpdate} " +
				$"WHERE {objekat.KriterijumiZaPretragu}";
			object rez = command.ExecuteNonQuery();
			return rez;
		}
	}
}
