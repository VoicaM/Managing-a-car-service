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
    public partial class VizualizareTipuriReparatii : Form
    {
        ServiceAutoClient.ServiceReference1.WebService1SoapClient serviciu = new ServiceReference1.WebService1SoapClient();
        public VizualizareTipuriReparatii()
        {
            InitializeComponent();
            DataSet dTipuriRep = serviciu.AfisTipuriReparatii();
            dataGridView1.DataSource = dTipuriRep;
            dataGridView1.DataMember = "TipuriReparatii";
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
