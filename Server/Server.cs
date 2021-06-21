using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
	public class Server
    {
        private Socket listener;
        private List<KlijentskaNit> clients = new List<KlijentskaNit>();
        private BindingList<KorisnikSistema> users = new BindingList<KorisnikSistema>();
        public BindingList<KorisnikSistema> Users {
            get { return users; }
        }
        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            listener.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(ConfigurationManager.AppSettings["port"])));
        }

        public void Listen()
        {
            listener.Listen(5);
            bool kraj = false;
            while (!kraj)
            {
                try
                {

                    Socket client = listener.Accept();
                    KlijentskaNit handler = new KlijentskaNit(client, users);
                    clients.Add(handler);
                    Thread thread = new Thread(handler.StartHandler);
                    thread.IsBackground = true;
                    thread.Start();

                }
                catch (SocketException)
                {
                    Console.WriteLine("Kraj rada");
                    kraj = true;
                }
            }
        }

        internal void Stop()
        {
            listener.Close();
            foreach(KlijentskaNit c in clients)
            {
                c.Stop();
            }
            clients.Clear();
        }
    }
}
