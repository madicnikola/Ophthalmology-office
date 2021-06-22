using Domen;
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

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }

		//internal List<Manufacturer> GetAllManufacuturers()
		//{
		//    Request request = new Request() { Operacija = Operacija.GetAllManufacturers };
		//    client.SendRequest(request);
		//    return (List<Manufacturer>)client.GetResponseResult();
		//}

		//internal void SaveProduct(Product p)
		//{
		//    Request request = new Request() { Operacija = Operacija.SaveProduct };
		//    request.RequestObject = p;
		//    client.SendRequest(request);
		//    client.GetResponseResult();
		//}

		//internal void SaveManufacturer(Manufacturer m)
		//{
		//    Request request = new Request() { Operacija = Operacija.SaveManufacturer, RequestObject = m };
		//    client.SendRequest(request);
		//    client.GetResponseResult();
		//}

		//internal List<Product> GetAllProducts()
		//{
		//    Request request = new Request() { Operacija = Operacija.GetAllProducts };
		//    client.SendRequest(request);
		//    return (List<Product>)client.GetResponseResult();
		//}

		internal KorisnikSistema Login(string username, string password)
		{
			Zahtev request = new Zahtev()
			{
				Operacija = Operacija.PrijaviMe,
				Objekat = new KorisnikSistema { Username = username, Password = password }
			};
			client.SendRequest(request);
			return (KorisnikSistema)client.GetResponseResult();
		}

		//internal void SaveInvoice(Invoice invoice)
		//{
		//    Request request = new Request() { Operacija = Operacija.SaveInvoice, RequestObject = invoice };
		//    client.SendRequest(request);
		//    client.GetResponseResult();
		//}
	}
}
