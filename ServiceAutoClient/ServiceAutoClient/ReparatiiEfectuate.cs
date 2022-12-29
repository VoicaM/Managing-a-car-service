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
    public partial class ReparatiiEfectuate : Form
    {
        ServiceAutoClient.ServiceReference1.WebService1SoapClient serviciu = new ServiceReference1.WebService1SoapClient();
        public ReparatiiEfectuate()
        {
            InitializeComponent();
            label1.Select();
            label1.Text = "Reparații efectuate";
            DataSet drepEf = serviciu.AfisReparatiiEfectuate();
            dataGridView1.DataSource = drepEf;
            dataGridView1.DataMember = "ReparatiiEfectuate";
            textBox_cod_reparatie.Text = Reparatii.COD_REPARATIE;
            textBox_cod_auto.Text = SelectareAuto.COD_AUTO;
        }

        private void button_adaugare_Click(object sender, EventArgs e)
        {
            int cod_reparatie = int.Parse(textBox_cod_reparatie.Text);
            int cod_auto = int.Parse(textBox_cod_auto.Text);
            string durata_efectuare = textBox_durata_efectuare.Text;
            string data_finalizare = textBox_data_finalizare.Text;

            try
            {
                serviciu.AdaugareReparatiiEfectuate(cod_reparatie.ToString(), cod_auto.ToString(), durata_efectuare, data_finalizare);
                MessageBox.Show("Datele s-au adăugat cu succes!");

            }
            catch
            {
                MessageBox.Show("Datele nu s-au adăugat!");
            }

            textBox_nr_crt.Clear();
            textBox_cod_reparatie.Clear();
            textBox_cod_auto.Clear();
            textBox_durata_efectuare.Clear();
            textBox_data_finalizare.Clear();
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            DataSet drepEf = serviciu.AfisReparatiiEfectuate();
            dataGridView1.DataSource = drepEf;
            dataGridView1.DataMember = "ReparatiiEfectuate";
        }

        private void button_editare_Click(object sender, EventArgs e)
        {
            try
            {
            int nr_crt = int.Parse(textBox_nr_crt.Text);
            int cod_reparatie = int.Parse(textBox_cod_reparatie.Text);
            int cod_auto = int.Parse(textBox_cod_auto.Text);
            string durata_efectuare = textBox_durata_efectuare.Text;
            string data_finalizare = textBox_data_finalizare.Text;
           
                serviciu.ModificareReparatiiEfectuate(nr_crt.ToString(), cod_reparatie.ToString(), cod_auto.ToString(), durata_efectuare, data_finalizare);
                MessageBox.Show("Modificarile s-au realizat cu succes!");
            }
            catch
            {
                MessageBox.Show("Modificarile nu s-au realizat!");
            }

            textBox_nr_crt.Clear();
            textBox_cod_reparatie.Clear();
            textBox_cod_auto.Text = "<-Selectează->";
            textBox_durata_efectuare.Clear();
            textBox_data_finalizare.Clear();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_nr_crt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_cod_reparatie.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_cod_auto.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_durata_efectuare.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox_data_finalizare.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_tipuri_reparatii_Click(object sender, EventArgs e)
        {
            VizualizareTipuriReparatii vizualizareTipuriRep = new VizualizareTipuriReparatii();
            vizualizareTipuriRep.Show();
        }

        private void button_autovehicule_Click(object sender, EventArgs e)
        {
            VizualizareAutovehicule vizualizareAuto = new VizualizareAutovehicule();
            vizualizareAuto.Show();
        }

        private void button_stergere_Click(object sender, EventArgs e)
        {
            try
            {
                int nr_crt = int.Parse(textBox_nr_crt.Text);
            
                serviciu.StergereReparatiiEfectuate(nr_crt.ToString());
                MessageBox.Show("Datele au fost șterse!");
            }
            catch
            {
                MessageBox.Show("Ștergerea datelor nu s-a realizat!");
            }
            textBox_nr_crt.Clear();
            textBox_cod_reparatie.Clear();
            textBox_cod_auto.Text = "<-Selectează->";
            textBox_durata_efectuare.Clear();
            textBox_data_finalizare.Clear();
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
