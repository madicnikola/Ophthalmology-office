using Domen;
using SistenskeOperacije;
using System;
using System.ComponentModel;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Transfer;

namespace Server
{
	public class KlijentskaNit
	{
		private Socket client;
		private readonly BindingList<KorisnikSistema> users;
		private KorisnikSistema loggedInUser;
		public KlijentskaNit(Socket client, System.ComponentModel.BindingList<KorisnikSistema> users)
		{
			this.client = client;
			this.users = users;
		}
		public void StartHandler()
		{
			try
			{
				NetworkStream stream = new NetworkStream(client);
				BinaryFormatter formatter = new BinaryFormatter();
				while (true)
				{
					Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
					Odgovor response;
					try
					{
						response = ProcessRequest(zahtev);
					}
					catch (Exception ex)
					{
						response = new Odgovor();
						response.Status = Status.ERR;
						response.Poruka = ex.Message;
					}
					formatter.Serialize(stream, response);
				}
			}
			catch (IOException)
			{
				Console.WriteLine("Doslo je do prekida veze");
				//obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
				//drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
				users.Remove(loggedInUser);

			}
			catch (SerializationException)
			{
				Console.WriteLine("Doslo je do prekida veze");
				//obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
				//drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
				users.Remove(loggedInUser);

			}
		}

		private Odgovor ProcessRequest(Zahtev zahtev)
		{
			Odgovor response = new Odgovor();
			response.Status = Status.OK;
			switch (zahtev.Operacija)
			{
				case Operacija.Login:
					response.Objekat = Kontroler.Instance.login((KorisnikSistema)zahtev.Objekat);
					loggedInUser = (KorisnikSistema)response.Objekat;
					users.Add(loggedInUser);
					break;

				case Operacija.Register:
					try
					{
						response.Objekat = Kontroler.Instance.register((KorisnikSistema)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da zapamti Korisnika Sistema.";
					}
					break;

				case Operacija.SavePacient:
					try
					{
						response.Objekat = Kontroler.Instance.sacuvajPacijenta((Pacijent)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da zapamti Pacijenta.";
					}
					break;

				case Operacija.UpdatePacient:
					try
					{
						response.Objekat = Kontroler.Instance.izmeniPacijenta((Pacijent)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da izmeni Pacijenta.";
					}
					break;

				case Operacija.DeletePacient:
					try
					{
						response.Objekat = Kontroler.Instance.obrisiPacijenta((IDomenskiObjekat)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da obrise Pacijenta.";
					}
					break;
				case Operacija.SaveDoctor:
					try
					{
						response.Objekat = Kontroler.Instance.sacuvajLekara((Lekar)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da sacuva Lekara.";
					}
					break;
				case Operacija.UpdateDoctor:
					try
					{
						response.Objekat = Kontroler.Instance.izmeniLekara((Lekar)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da izmeni Lekara.";
					}
					break;

				case Operacija.DeleteDoctor:
					try
					{
						response.Objekat = Kontroler.Instance.ObrisiLekara((IDomenskiObjekat)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da obrise Lekara.";
					}
					break;

				case Operacija.SaveExamin:
					try
					{
						response.Objekat = Kontroler.Instance.sacuvajPregled((Pregled)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da zapamti Pregled.";
					}
					break;

				case Operacija.DeleteExamin:
					try
					{
						response.Objekat = Kontroler.Instance.ObrisiPregled((IDomenskiObjekat)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = "Sistem ne moze da obrise Pregled.";
					}
					break;

				case Operacija.SearchPacients:
				case Operacija.SearchDoctors:
				case Operacija.SearchExamin:
					try
					{
						response.Objekat = Kontroler.Instance.pretraziDomenskeObjekte((IDomenskiObjekat)zahtev.Objekat);
					}
					catch (Exception e)
					{
						response.Status = Status.ERR;
						response.Poruka = $"Sistem ne moze da pronadje {zahtev.Objekat.GetType().ToString().Substring(6)} po zadatom kriterijumu.";
					}
					break;

				case Operacija.GetAllPacients:
				case Operacija.GetAllDoctors:
				case Operacija.GetAllInterventions:
					response.Objekat = Kontroler.Instance.vratiSve((IDomenskiObjekat)zahtev.Objekat);
					break;

				case Operacija.GetAllExamins:
					response.Objekat = Kontroler.Instance.vratiSveSlozen((IDomenskiObjekat)zahtev.Objekat);
					break;

				default:
					break;
			}
			return response;
		}

		internal void Stop()
		{
			client.Close();
		}
	}
}
