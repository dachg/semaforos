using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Int32.Parse(g1_amount.Text);
                int ligth = Int32.Parse(g1_ligth.Text);
                MessageBox.Show("Enviando reporte", "Ok");
            }
            catch
            {
                MessageBox.Show("Por favor ingrese solo números", "Error");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int amount = Int32.Parse(g2_amount.Text);
                int ligth = Int32.Parse(g2_ligth.Text);
                MessageBox.Show("Enviando reporte", "Ok");
            }
            catch
            {
                MessageBox.Show("Por favor ingrese solo números", "Error");
            }
        }

        private void changeg1(int color)
        {
            switch (color)
            {
                case 1:
                    g1_red.BackColor = Color.Red;
                    g1_yellow.BackColor = Color.FromArgb(255, 255, 192);
                    g1_green.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                case 2:
                    g1_red.BackColor = Color.FromArgb(255, 192, 192); ;
                    g1_yellow.BackColor = Color.Yellow;
                    g1_green.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                case 3:
                    g1_red.BackColor = Color.FromArgb(255, 192, 192); ;
                    g1_yellow.BackColor = Color.FromArgb(255, 255, 192);
                    g1_green.BackColor = Color.Green;
                    break;
            }
        }

        private void changeg2(int color)
        {
            switch (color)
            {
                case 1:
                    g1_red.BackColor = Color.Red;
                    g1_yellow.BackColor = Color.FromArgb(255, 255, 192);
                    g1_green.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                case 2:
                    g1_red.BackColor = Color.FromArgb(255, 192, 192); ;
                    g1_yellow.BackColor = Color.Yellow;
                    g1_green.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                case 3:
                    g1_red.BackColor = Color.FromArgb(255, 192, 192); ;
                    g1_yellow.BackColor = Color.FromArgb(255, 255, 192);
                    g1_green.BackColor = Color.Green;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            changeg1(Int32.Parse(g1_amount.Text));
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Enviando reporte", "Ok");
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            changeg1(Int32.Parse(g1_amount.Text));
        }
    }
}
