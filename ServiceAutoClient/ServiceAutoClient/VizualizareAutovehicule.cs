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
    public partial class VizualizareAutovehicule : Form
    {
        ServiceAutoClient.ServiceReference1.WebService1SoapClient serviciu = new ServiceReference1.WebService1SoapClient();
        public VizualizareAutovehicule()
        {
            InitializeComponent();
            DataSet dauto = serviciu.AfisAutovehicule();
            dataGridView1.DataSource = dauto;
            dataGridView1.DataMember = "Autovehicule";
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
