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
    public partial class Reparatii : Form
    {
        ServiceAutoClient.ServiceReference1.WebService1SoapClient serviciu = new ServiceReference1.WebService1SoapClient();
        public static string COD_REPARATIE;
        public Reparatii()
        {
            InitializeComponent();
            label1.Select();
            label1.Text = "Tipuri reparații";
        }

        private void button_continuare_Click(object sender, EventArgs e)
        {
            if (COD_REPARATIE == textBox_cod_reparatie.Text)
            {
                SelectareAuto selectareAuto = new SelectareAuto();
                selectareAuto.Show();
            }
            else
            {
                MessageBox.Show("Selecteaza tipul reparației!");
            }
        }

        private void Reparatii_Load(object sender, EventArgs e)
        {
            DataSet drep = new DataSet();
            drep = serviciu.AfisTipuriReparatii();
            comboBox_reparatii.DataSource = drep.Tables[0];
            comboBox_reparatii.DisplayMember = "denumire_reparatie";
            comboBox_reparatii.ValueMember = "cod_reparatie";
            comboBox_reparatii.Text = "<-Selectează->";
            textBox_cod_reparatie.Clear();
            textBox_denumire_reparatie.Clear();
        }

        private void button_adăugare_Click(object sender, EventArgs e)
        {
            
            string denumire_reparatie = textBox_denumire_reparatie.Text;

            try
            {
                serviciu.AdaugareTipuriReparatii(denumire_reparatie);
                MessageBox.Show("Reparația a fost adăugată!");
            }
            catch
            {
                MessageBox.Show("Reparația nu a fost adăugată!");
            }
            
            textBox_denumire_reparatie.Clear();
            comboBox_reparatii.Text = "<-Selectează->";
        }

        private void comboBox_reparatii_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_cod_reparatie.Text = comboBox_reparatii.SelectedValue.ToString();
            textBox_denumire_reparatie.Text = comboBox_reparatii.GetItemText(comboBox_reparatii.SelectedItem);
            COD_REPARATIE = textBox_cod_reparatie.Text;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DataSet drep = new DataSet();
            drep = serviciu.AfisTipuriReparatii();
            comboBox_reparatii.DataSource = drep.Tables[0];
            comboBox_reparatii.DisplayMember = "denumire_reparatie";
            comboBox_reparatii.ValueMember = "cod_reparatie";
            comboBox_reparatii.Text = "<-Selectează->";
            textBox_cod_reparatie.Clear();
            textBox_denumire_reparatie.Clear();
        }

        private void button_editare_Click(object sender, EventArgs e)
        {
            try { 
            int cod_reparatie = int.Parse(textBox_cod_reparatie.Text);
            string denumire_reparatie = textBox_denumire_reparatie.Text;
            serviciu.ModificareTipuriReparatii(cod_reparatie.ToString(), denumire_reparatie);
            
                MessageBox.Show("Modificarile s-au realizat cu succes!");
            }
            catch
            {
                MessageBox.Show("Modificarile nu s-au realizat!");
            }
                textBox_cod_reparatie.Clear();
                textBox_denumire_reparatie.Clear();
                comboBox_reparatii.Text = "<-Selectează->";
        }

        private void button_stergere_Click(object sender, EventArgs e)
        {
            try
            {
                int cod_reparatie = int.Parse(textBox_cod_reparatie.Text);
            
                serviciu.StergereTipuriReparatii(cod_reparatie.ToString());
                MessageBox.Show("Datele au fost șterse!");
            }
            catch
            {
                MessageBox.Show("Ștergerea datelor nu s-a realizat!");
            }
            textBox_cod_reparatie.Clear();
            textBox_denumire_reparatie.Clear();
            comboBox_reparatii.Text = "<-Selectează->";
        }
    }
}
