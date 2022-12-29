using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiceAutoWeb
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection con = new SqlConnection();
        [WebMethod]
        public void AdaugareAutovehicule(string marca, string model, string an_fabricatie)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM Autovehicule ORDER BY cod_auto", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet newQueryAuto = new DataSet();
            servAdapter.Fill(newQueryAuto, "Autovehicule");
            DataRow newRow = newQueryAuto.Tables["Autovehicule"].NewRow();
            newRow["marca"] = marca;
            newRow["model"] = model;
            newRow["an_fabricatie"] = an_fabricatie;
            newQueryAuto.Tables["Autovehicule"].Rows.Add(newRow);
            servAdapter.Update(newQueryAuto, "Autovehicule");
            con.Close();
        }

        [WebMethod]
        public void AdaugareTipuriReparatii(string denumire_reparatie)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM TipuriReparatii ORDER BY cod_reparatie", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet newQueryRep = new DataSet();
            servAdapter.Fill(newQueryRep, "TipuriReparatii");
            DataRow newRow = newQueryRep.Tables["TipuriReparatii"].NewRow();
            newRow["denumire_reparatie"] = denumire_reparatie;
            newQueryRep.Tables["TipuriReparatii"].Rows.Add(newRow);
            servAdapter.Update(newQueryRep, "TipuriReparatii");
            con.Close();
        }

        [WebMethod]
        public void AdaugareReparatiiEfectuate(string cod_reparatie, string cod_auto, string durata_efectuare, string data_finalizare)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM ReparatiiEfectuate ORDER BY nr_crt", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet newQueryRepEf = new DataSet();
            servAdapter.Fill(newQueryRepEf, "ReparatiiEfectuate");
            DataRow newRow = newQueryRepEf.Tables["ReparatiiEfectuate"].NewRow();
            newRow["cod_reparatie"] = cod_reparatie;
            newRow["cod_auto"] = cod_auto;
            newRow["durata_efectuare"] = durata_efectuare;
            newRow["data_finalizare"] = data_finalizare;
            newQueryRepEf.Tables["ReparatiiEfectuate"].Rows.Add(newRow);
            servAdapter.Update(newQueryRepEf, "ReparatiiEfectuate");
            con.Close();
        }

        [WebMethod]
        public void ModificareAutovehicule(string cod_auto, string marca, string model, string an_fabricatie)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM Autovehicule ORDER BY cod_auto", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet updateAuto = new DataSet();
            servAdapter.Fill(updateAuto, "Autovehicule");
            DataColumn[] pk = new DataColumn[1];
            pk[0] = updateAuto.Tables["Autovehicule"].Columns["cod_auto"];
            updateAuto.Tables["Autovehicule"].PrimaryKey = pk;
            DataRow cautare = null;
            while (cautare == null)
            {
                cautare = updateAuto.Tables["Autovehicule"].Rows.Find(cod_auto);
            }
            cautare["marca"] = marca;
            cautare["model"] = model;
            cautare["an_fabricatie"] = an_fabricatie;
            servAdapter.Update(updateAuto, "Autovehicule");
            con.Close();
        }

        [WebMethod]
        public void ModificareTipuriReparatii(string cod_reparatie, string denumire_reparatie)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM TipuriReparatii ORDER BY cod_reparatie", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet updateRep = new DataSet();
            servAdapter.Fill(updateRep, "TipuriReparatii");
            DataColumn[] pk = new DataColumn[1];
            pk[0] = updateRep.Tables["TipuriReparatii"].Columns["cod_reparatie"];
            updateRep.Tables["TipuriReparatii"].PrimaryKey = pk;
            DataRow cautare = null;
            while (cautare == null)
            {
                cautare = updateRep.Tables["TipuriReparatii"].Rows.Find(cod_reparatie);
            }
            cautare["denumire_reparatie"] = denumire_reparatie;
            servAdapter.Update(updateRep, "TipuriReparatii");
            con.Close();
        }

        [WebMethod]
        public void ModificareReparatiiEfectuate(string nr_crt, string cod_reparatie, string cod_auto, string durata_efectuare, string data_finalizare)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM ReparatiiEfectuate ORDER BY nr_crt", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet updateRepEf = new DataSet();
            servAdapter.Fill(updateRepEf, "ReparatiiEfectuate");
            DataColumn[] pk = new DataColumn[1];
            pk[0] = updateRepEf.Tables["ReparatiiEfectuate"].Columns["nr_crt"];
            updateRepEf.Tables["ReparatiiEfectuate"].PrimaryKey = pk;
            DataRow cautare = null;
            while (cautare == null)
            {
                cautare = updateRepEf.Tables["ReparatiiEfectuate"].Rows.Find(nr_crt);
            }
            cautare["cod_reparatie"] = cod_reparatie;
            cautare["cod_auto"] = cod_auto;
            cautare["durata_efectuare"] = durata_efectuare;
            cautare["data_finalizare"] = data_finalizare;
            servAdapter.Update(updateRepEf, "ReparatiiEfectuate");
            con.Close();
        }

        [WebMethod]
        public void StergereAutovehicule(string cod_auto)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM Autovehicule ORDER BY cod_auto", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet deleteAuto = new DataSet();
            servAdapter.Fill(deleteAuto, "Autovehicule");
            DataColumn[] pk = new DataColumn[1];
            pk[0] = deleteAuto.Tables["Autovehicule"].Columns["cod_auto"];
            deleteAuto.Tables["Autovehicule"].PrimaryKey = pk;
            DataRow caut = null;
            while (caut == null)
            {
                caut = deleteAuto.Tables["Autovehicule"].Rows.Find(cod_auto);
            }
            caut.Delete();
            servAdapter.Update(deleteAuto, "Autovehicule");
            con.Close();
        }

        [WebMethod]
        public void StergereTipuriReparatii(string cod_reparatie)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM TipuriReparatii ORDER BY cod_reparatie", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet deleteRep = new DataSet();
            servAdapter.Fill(deleteRep, "TipuriReparatii");
            DataColumn[] pk = new DataColumn[1];
            pk[0] = deleteRep.Tables["TipuriReparatii"].Columns["cod_reparatie"];
            deleteRep.Tables["TipuriReparatii"].PrimaryKey = pk;
            DataRow caut = null;
            while (caut == null)
            {
                caut = deleteRep.Tables["TipuriReparatii"].Rows.Find(cod_reparatie);
            }
            caut.Delete();
            servAdapter.Update(deleteRep, "TipuriReparatii");
            con.Close();
        }

        [WebMethod]
        public void StergereReparatiiEfectuate(string nr_crt)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM ReparatiiEfectuate ORDER BY nr_crt", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet deleteRepEf = new DataSet();
            servAdapter.Fill(deleteRepEf, "ReparatiiEfectuate");
            DataColumn[] pk = new DataColumn[1];
            pk[0] = deleteRepEf.Tables["ReparatiiEfectuate"].Columns["nr_crt"];
            deleteRepEf.Tables["ReparatiiEfectuate"].PrimaryKey = pk;
            DataRow caut = null;
            while (caut == null)
            {
                caut = deleteRepEf.Tables["ReparatiiEfectuate"].Rows.Find(nr_crt);
            }
            caut.Delete();
            servAdapter.Update(deleteRepEf, "ReparatiiEfectuate");
            con.Close();
        }


        [WebMethod]
        public DataSet AfisAutovehicule()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM Autovehicule ORDER BY cod_auto", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet afisAuto = new DataSet();
            servAdapter.Fill(afisAuto, "Autovehicule");
            con.Close();
            return (afisAuto);
        }

        [WebMethod]
        public DataSet AfisTipuriReparatii()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM TipuriReparatii ORDER BY cod_reparatie", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet afisRep = new DataSet();
            afisRep.AcceptChanges();
            servAdapter.Fill(afisRep, "TipuriReparatii");

            con.Close();
            return (afisRep);
        }


        [WebMethod]
        public DataSet AfisReparatiiEfectuate()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\source\repos\ServiceAutoWeb\ServiceAutoWeb\App_Data\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter servAdapter = new SqlDataAdapter("SELECT * FROM ReparatiiEfectuate ORDER BY nr_crt", con);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(servAdapter);
            DataSet afisRepEf = new DataSet();
            servAdapter.Fill(afisRepEf, "ReparatiiEfectuate");
            con.Close();
            return (afisRepEf);
        }
    }
}
