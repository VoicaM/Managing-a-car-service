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
    public partial class SelectareAuto : Form
    {
        ServiceAutoClient.ServiceReference1.WebService1SoapClient serviciu = new ServiceReference1.WebService1SoapClient();
        public static string COD_AUTO;
        public SelectareAuto()
        {
            InitializeComponent();
            DataSet drepEf = serviciu.AfisAutovehicule();
            dataGridView1.DataSource = drepEf;
            dataGridView1.DataMember = "Autovehicule";
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_cod_auto.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            COD_AUTO = textBox_cod_auto.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (COD_AUTO == textBox_cod_auto.Text)
            {
                ReparatiiEfectuate reparatiiEfectuate = new ReparatiiEfectuate();
                reparatiiEfectuate.Show();
            }
            else
            {
                MessageBox.Show("Selecteaza autovehiculul!");
            }

        }
    }
}
