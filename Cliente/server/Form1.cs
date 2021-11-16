﻿using DataInformation;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace server
{
    public partial class Form1 : Form
    {
        static int SERVER_PORT = 4404;
        static string IP = "localhost";
        private List<TrafficLight> trafficLights;
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint endpoint;

        Socket s_Server;
        Socket s_Client;

        public Form1()
        {
            trafficLights = new List<TrafficLight>();
            InitializeComponent();
            //trafficLights.Add(new TrafficLight(4, 5, eGroups.group3, 1));
            
            dataTrafficLight.DataSource = trafficLights;

            comboGroup.DataSource = Enum.GetValues(typeof(eGroups));
            comboColor.DataSource = Enum.GetValues(typeof(eColor));

            host = Dns.GetHostEntry(IP);
            ipAddress = host.AddressList[0];
            endpoint = new IPEndPoint(ipAddress, SERVER_PORT);

            s_Server = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_Server.Bind(endpoint);
            s_Server.Listen(2);

            timerLight.Interval = 1000;
            timerLight.Enabled = true;
            Start();
        }

        public void Start()
        {
            Thread t;
            t = new Thread(NewThread);
            t.Name = "Manage Sesions";
            t.Start();
        }

        public void NewThread()
        {
            Thread t;
            while (true)
            {
                s_Client = s_Server.Accept();
                t = new Thread(clientConnection);
                t.Start(s_Client);
            }
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
                    int indexTrafficLights = trafficLights.FindIndex(x => x.ClientId == trafficLight.ClientId && x.GroupId == trafficLight.GroupId);
                    if (indexTrafficLights > -1)
                    {
                        trafficLights[indexTrafficLights] = trafficLight;
                    }
                    else
                    {
                        trafficLights.Add(trafficLight);
                    }
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

        //private void timerData_Tick(object sender, EventArgs e)
        //{
        //    dataTrafficLight.DataSource = trafficLights;
        //    dataTrafficLight.Refresh();
        //    comboClient.DataSource = clientIds;
        //}

        public void SendObject(object toSend)
        {
            s_Client.Send(Serialization.Serialize(toSend));
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Enum.TryParse(comboColor.SelectedItem.ToString(), out eColor color);
            Enum.TryParse(comboGroup.SelectedItem.ToString(), out eGroups group);
            ColorLight colorLight = new ColorLight();
            colorLight.Color = color;
            colorLight.GroupId = group;
            colorLight.ClientId = "";
            SendObject(colorLight);
        }

        private void timerLight_Tick(object sender, EventArgs e)
        {
            trafficLightBindingSource.DataSource = trafficLights;
            dataTrafficLight.Update();
            dataTrafficLight.Refresh();
        }
    }
}
