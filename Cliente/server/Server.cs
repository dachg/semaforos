#region usings
using DataInformation;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
#endregion

namespace server
{
    class Server
    {
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint endpoint;

        Socket s_Server;
        Socket s_Client;

        public Server(string ip, int port)
        {
            host = Dns.GetHostEntry(ip);
            ipAddress = host.AddressList[0];
            endpoint = new IPEndPoint(ipAddress, port);

            s_Server = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_Server.Bind(endpoint);
            s_Server.Listen(2);
        }

        public void Start()
        {
            Thread t;
            //while (true)
            //{
                s_Client = s_Server.Accept();
                t = new Thread(clientConnection);
                t.Start(s_Client);
            //}
        }

        public void clientConnection(object s)
        {
            Socket s_Client = (Socket)s;
            byte[] buffer;
            TrafficLight trafficLight;

            try
            {
                while (true)
                {
                    buffer = new byte[1024];
                    s_Client.Receive(buffer);
                    trafficLight = (TrafficLight)Serialization.Deserialize(buffer);

                    byte[] response = Encoding.ASCII.GetBytes("Success");
                    s_Client.Send(response);

                    Console.WriteLine("Message: " + trafficLight.NumberFails + trafficLight.NumberLigths + trafficLight.GroupId);
                    Console.Out.Flush();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
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
