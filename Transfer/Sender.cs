using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Transfer
{
	public class Sender
	{
		private readonly Socket socket;
		private NetworkStream stream;
		private BinaryFormatter formatter;

		public Sender(Socket socket)
		{
			this.socket = socket;
			this.stream = new NetworkStream(socket);
			this.formatter = new BinaryFormatter();
		}

		public void Send(object message) //send object
		{
			formatter.Serialize(stream, message);
		}
	}
}
