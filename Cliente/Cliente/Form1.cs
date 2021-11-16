#region usings
using DataInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Cliente
{
    public partial class Form1 : Form
    {
        static int SERVER_PORT = 4404;
        static string IP = "localhost";
        TrafficLight trafficLight;
        Client client;

        public Form1()
        {
            InitializeComponent();
            client = new Client(IP, SERVER_PORT);
            client.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Thread t;
            t = new Thread(receiveMessages);
            t.Start();
        }

        public void receiveMessages()
        {
            while (true)
            {
                try
                {
                    ColorLight color = client.Receive();
                    //MessageBox.Show(aaa, "Ok");
                    switch (color.GroupId)
                    {
                        case eGroups.group1:
                            changeg1(color.Color);
                            break;
                        case eGroups.group2:
                            changeg2(color.Color);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(clientId.Text))
                {
                    MessageBox.Show("Se debe enviar el \"Id cliente\"", "Ok");
                    return;
                }
                Int32.TryParse(g1_amount.Text, out int amount);
                Int32.TryParse(g1_ligth.Text, out int ligthFail);
                trafficLight = new TrafficLight(amount, ligthFail, eGroups.group1, clientId.Text);
                client.SendObject(trafficLight);
                //MessageBox.Show("Enviando reporte", "Ok");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(clientId.Text))
                {
                    MessageBox.Show("Se debe enviar el \"Id cliente\"", "Ok");
                    return;
                }
                Int32.TryParse(g2_amount.Text, out int amount);
                Int32.TryParse(g2_ligth.Text, out int ligthFail);
                trafficLight = new TrafficLight(amount, ligthFail, eGroups.group2, clientId.Text);
                client.SendObject(trafficLight);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeg1(eColor color)
        {
            switch (color)
            {
                case eColor.Red:
                    g1_red.BackColor = Color.Red;
                    g1_yellow.BackColor = Color.FromArgb(255, 255, 192);
                    g1_green.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                case eColor.Yellow:
                    g1_red.BackColor = Color.FromArgb(255, 192, 192); ;
                    g1_yellow.BackColor = Color.Yellow;
                    g1_green.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                case eColor.Green:
                    g1_red.BackColor = Color.FromArgb(255, 192, 192); ;
                    g1_yellow.BackColor = Color.FromArgb(255, 255, 192);
                    g1_green.BackColor = Color.Green;
                    break;
            }
        }

        private void changeg2(eColor color)
        {
            switch (color)
            {
                case eColor.Red:
                    g2_red.BackColor = Color.Red;
                    g2_yellow.BackColor = Color.FromArgb(255, 255, 192);
                    g2_green.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                case eColor.Yellow:
                    g2_red.BackColor = Color.FromArgb(255, 192, 192); ;
                    g2_yellow.BackColor = Color.Yellow;
                    g2_green.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                case eColor.Green:
                    g2_red.BackColor = Color.FromArgb(255, 192, 192); ;
                    g2_yellow.BackColor = Color.FromArgb(255, 255, 192);
                    g2_green.BackColor = Color.Green;
                    break;
            }
        }
    }
}
