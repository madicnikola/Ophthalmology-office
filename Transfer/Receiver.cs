using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Transfer
{
	public class Receiver
	{
		private readonly Socket socket;
		private NetworkStream stream;
		private BinaryFormatter formatter;

		public Receiver(Socket socket)
		{
			this.socket = socket;
			this.stream = new NetworkStream(socket);
			this.formatter = new BinaryFormatter();
		}

		public object Receive() //Receive or Response object
		{
			return formatter.Deserialize(stream);
		}
	}
}
