using Forme.Exceptions;
using System.IO;
using System.Net.Sockets;
using Transfer;

namespace View.Communication
{
	internal class CommunicationClient
    {
        private Receiver receiver;
        private Sender sender;
        public CommunicationClient(Socket socket)
        {
            receiver = new Receiver(socket);
            sender = new Sender(socket);
        }

        public void SendRequest(Zahtev request)
        {
            try
            {
                sender.Send(request);
            }
            catch (IOException ex)
            {
                throw new ServerException(ex.Message);
            }
            catch (SocketException ex)
            {

                throw new ServerException(ex.Message);
            }
        }
        public object GetResponseResult()
        {
            Odgovor response = (Odgovor)receiver.Receive();
            if (response.Status == Status.OK)
            {
                return response.Objekat;
            }
            else
            {
                throw new SystemOperationException(response.Poruka);
            }
        }
    }
}
