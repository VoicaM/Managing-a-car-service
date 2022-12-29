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
    public partial class Autovehicule : Form
    {
        ServiceAutoClient.ServiceReference1.WebService1SoapClient serviciu = new ServiceReference1.WebService1SoapClient();
        public Autovehicule()
        {
            InitializeComponent();
            label1.Text = "Autovehicule";
            DataSet dauto = serviciu.AfisAutovehicule();
            dataGridView1.DataSource = dauto;
            dataGridView1.DataMember = "Autovehicule";
        }

        private void button_adaugare_Click(object sender, EventArgs e)
        {
            string marca = textBox_marca.Text;
            string model = textBox_model.Text;
            string an_fabricatie = textBox_an_fabricatie.Text;

            try
            {
                serviciu.AdaugareAutovehicule(marca, model, an_fabricatie);
                MessageBox.Show("Autovehiculul a fost adăugat!");

            }
            catch
            {
                MessageBox.Show("Autovehiculul nu a fost adăugat!");
            }

            textBox_marca.Clear();
            textBox_model.Clear();
            textBox_an_fabricatie.Clear();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_cod_auto.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_marca.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_model.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_an_fabricatie.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DataSet dauto = serviciu.AfisAutovehicule();
            dataGridView1.DataSource = dauto;
            dataGridView1.DataMember = "Autovehicule";
        }

        private void button_editare_Click(object sender, EventArgs e)
        {
            try
            {
            int cod_auto = int.Parse(textBox_cod_auto.Text);
            string marca = textBox_marca.Text;
            string model = textBox_model.Text;
            int an_fabricatie = int.Parse(textBox_an_fabricatie.Text);
            
                serviciu.ModificareAutovehicule(cod_auto.ToString(), marca, model, an_fabricatie.ToString());
                MessageBox.Show("Modificarile s-au realizat cu succes!");
            }
            catch
            {
                MessageBox.Show("Modificarile nu s-au realizat!");
            }

            textBox_cod_auto.Clear();
            textBox_marca.Clear();
            textBox_model.Clear();
            textBox_an_fabricatie.Clear();
        }

        private void button_stergere_Click(object sender, EventArgs e)
        {
            try
            {
                int cod_auto = int.Parse(textBox_cod_auto.Text);
            
                serviciu.StergereAutovehicule(cod_auto.ToString());
                MessageBox.Show("Datele au fost șterse!");
            }
            catch
            {
                MessageBox.Show("Ștergerea datelor nu s-a realizat!");
            }

            textBox_cod_auto.Clear();
            textBox_marca.Clear();
            textBox_model.Clear();
            textBox_an_fabricatie.Clear();
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
