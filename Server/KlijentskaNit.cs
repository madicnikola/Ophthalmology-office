using Domen;
using KontrolerNS;
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
				case Operacija.PrijaviMe:
					response.Objekat = Kontroler.Instance.login((KorisnikSistema)zahtev.Objekat);
					loggedInUser = (KorisnikSistema)response.Objekat;
					users.Add(loggedInUser);
					break;
				case Operacija.GetAllPacients:
					response.Objekat = Kontroler.Instance.vratiSve((IDomenskiObjekat)zahtev.Objekat);
					break;
				case Operacija.GetAllDoctors:
					response.Objekat = Kontroler.Instance.vratiSve((IDomenskiObjekat)zahtev.Objekat);
					break;
				case Operacija.GetAllExamins:
					response.Objekat = Kontroler.Instance.vratiSveSlozen((IDomenskiObjekat)zahtev.Objekat);
					break;
				//case Operacija.GetAllManufacturers:
				//    response.Result = Controller.Instance.GetAllManufacturers();
				//    break;
				//case Operacija.GetAllProducts:
				//    response.Result = Controller.Instance.GetAllProducts();
				//    break;
				//case Operacija.SaveInvoice:
				//    Controller.Instance.SaveInvoice((Invoice)Zahtev.RequestObject);
				//    break;
				//case Operacija.SaveManufacturer:
				//    Controller.Instance.SaveManufacturer((Manufacturer)Zahtev.RequestObject);
				//    break;
				//case Operacija.SaveProduct:
				//    Controller.Instance.SaveProduct((Product)Zahtev.RequestObject);
				//    break;
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
