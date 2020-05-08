using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<string> stopNames)
        {
            InitializeComponent();
            foreach (string z in stopNames)
            {
                currentLocation.Items.Add(z);
                destination.Items.Add(z);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void findRoute_Click(object sender, EventArgs e)
        {
            outputText.Text = "Bus 5 - Pickup 5:30\nSculpture Park -> Principal Building\n\nBus 2 - Pickup 5:37\nPrincipal Building -> Fairgrounds -> Raygun\n\nArrival - 5:50";
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
