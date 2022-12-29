using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAutoClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Select();
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Autovehicule autovehicule = new Autovehicule();
        private void button_autovehicule_Click(object sender, EventArgs e)
        {
            autovehicule.Show();
        }

        Reparatii reparatii = new Reparatii();
        private void button_reparatii_Click(object sender, EventArgs e)
        {
            reparatii.Show();
        }
    }
}
