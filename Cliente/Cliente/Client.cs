#region usings
using DataInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Cliente
{
    class Client
    {
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint endpoint;

        Socket s_Client;

        public Client(string ip, int port)
        {
            host = Dns.GetHostEntry(ip);
            ipAddress = host.AddressList[0];
            endpoint = new IPEndPoint(ipAddress, port);

            s_Client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            s_Client.Connect(endpoint);
        }

        public void Send(string message)
        {
            byte[] byteMessage = Encoding.ASCII.GetBytes(message);
            s_Client.Send(byteMessage);
        }

        public void SendObject(object toSend)
        {
            s_Client.Send(Serialization.Serialize(toSend));
        }

        public ColorLight Receive()
        {
            ColorLight colorLight = new ColorLight();
            try
            {
                byte[] buffer = new byte[1024];
                s_Client.Receive(buffer);
                var response = Serialization.Deserialize(buffer);

                colorLight = (ColorLight)response;
                return colorLight;
            }
            catch (Exception ex)
            {
                throw new Exception("Cliente no permitido");
            }
        }

        public string byte2String(byte[] buffer)
        {
            string msg;
            int endIndex;
            msg = Encoding.ASCII.GetString(buffer);
            endIndex = msg.IndexOf('\0');
            if (endIndex > 0)
            {
                msg = msg.Substring(0, endIndex);
            }
            return msg;
        }
    }
}
