using Domen;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Transfer;

namespace View.Communication
{
	public class Communication
	{
		private static Communication instance;

		private Socket socket;
		private CommunicationClient client;
		public static Communication Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Communication();
				}
				return instance;
			}
		}

		public object Request { get; private set; }

		private Communication()
		{

		}
		public void Connect()
		{
			if (socket != null && socket.Connected)
			{
				return;
			}
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect("127.0.0.1", 9999);
			client = new CommunicationClient(socket);

		}

		internal Pregled deleteExamin(Pregled p)
		{
			{
				Zahtev request = new Zahtev
				{
					Operacija = Operacija.DeleteExamin,
					Objekat = p
				};

				client.SendRequest(request);
				return (Pregled)client.GetResponseResult();
			}
		}

		internal Pacijent deletePacient(Pacijent p)
		{
			{
				Zahtev request = new Zahtev
				{
					Operacija = Operacija.DeletePacient,
					Objekat = p
				};

				client.SendRequest(request);
				return (Pacijent)client.GetResponseResult();
			}
		}

		internal List<IDomenskiObjekat> pretraziPacijente(Pacijent pacijent)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.SearchPacients,
				Objekat = pacijent
			};

			client.SendRequest(request);
			return (List<IDomenskiObjekat>)client.GetResponseResult();
		}

		internal List<IDomenskiObjekat> pretraziPreglede(Pregled pregled)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.SearchExamin,
				Objekat = pregled
			};

			client.SendRequest(request);
			return (List<IDomenskiObjekat>)client.GetResponseResult();
		}

		internal Lekar updateDoctor(Lekar l)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.UpdateDoctor,
				Objekat = l
			};

			client.SendRequest(request);
			return (Lekar)client.GetResponseResult();
		}

		internal Pacijent updatePacient(Pacijent p)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.UpdatePacient,
				Objekat = p
			};

			client.SendRequest(request);
			return (Pacijent)client.GetResponseResult();
		}

		internal List<IDomenskiObjekat> pretraziLekare(Lekar l)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.SearchDoctors,
				Objekat = l
			};

			client.SendRequest(request);
			return (List<IDomenskiObjekat>)client.GetResponseResult();
		}

		internal List<IDomenskiObjekat> GetAllDoctors()
		{
			Zahtev request = new Zahtev()
			{
				Operacija = Operacija.GetAllDoctors
		,
				Objekat = new Lekar()
			};
			client.SendRequest(request);

			return (List<IDomenskiObjekat>)client.GetResponseResult();
		}

		public List<IDomenskiObjekat> GetAllPacients()
		{
			Zahtev request = new Zahtev()
			{
				Operacija = Operacija.GetAllPacients
			,
				Objekat = new Pacijent()
			};
			client.SendRequest(request);

			return (List<IDomenskiObjekat>)client.GetResponseResult();
		}

		internal Lekar deleteDoctor(Lekar l)
		{
			{
				Zahtev request = new Zahtev
				{
					Operacija = Operacija.DeleteDoctor,
					Objekat = l
				};

				client.SendRequest(request);
				return (Lekar)client.GetResponseResult();
			}
		}
		public List<IDomenskiObjekat> GetAllExamins()
		{
			Zahtev request = new Zahtev()
			{
				Operacija = Operacija.GetAllExamins
		,
				Objekat = new Pregled()
			};
			client.SendRequest(request);

			return (List<IDomenskiObjekat>)client.GetResponseResult();
		}

		internal List<IDomenskiObjekat> GetAllInterventions()
		{
			Zahtev request = new Zahtev()
			{
				Operacija = Operacija.GetAllInterventions
					,
				Objekat = new TipIntervencije()
			};
			client.SendRequest(request);

			return (List<IDomenskiObjekat>)client.GetResponseResult();
		}

		internal void Disconnect()
		{
			socket.Close();
			socket = null;
		}

		internal Pacijent savePacient(Pacijent p)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.SavePacient,
				Objekat = p
		};

			client.SendRequest(request);
			return (Pacijent)client.GetResponseResult();
		}

		internal Lekar saveDoctor(Lekar l)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.SaveDoctor,
				Objekat = l
			};

			client.SendRequest(request);
			return (Lekar)client.GetResponseResult();
		}
		internal Pregled saveExamin(Pregled pregled)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.SaveExamin,
				Objekat = pregled
			};

			client.SendRequest(request);
			return (Pregled)client.GetResponseResult();
		}

		internal KorisnikSistema Login(string username, string password)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.Login,
				Objekat = new KorisnikSistema { Username = username, Password = password }
			};
			client.SendRequest(request);
			return (KorisnikSistema)client.GetResponseResult();
		}

		internal KorisnikSistema Register(string ime, string prezime, string username, string password)
		{
			Zahtev request = new Zahtev
			{
				Operacija = Operacija.Register,
				Objekat = new KorisnikSistema { Ime = ime,Prezime = prezime, Username = username, Password = password }
			};

			client.SendRequest(request);
			return (KorisnikSistema)client.GetResponseResult();
		}

	}
}
