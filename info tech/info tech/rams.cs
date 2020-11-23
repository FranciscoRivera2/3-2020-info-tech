using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace info_tech
{
    public partial class rams : Form
    {
        public rams()
        {
            InitializeComponent();
        }

        private void rams_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Form1();
            newForm.Show();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Frecuencia();
        }
        // creacion de un method 
        private void Frecuencia()
        {
            if (comboBox1.Text == "T-Force Vulcan Z")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Frecuencia FROM ram1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canFrecuencia = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblFrecuencia1.Text = "Frecuencia:" + canFrecuencia;


            }
            else if (comboBox1.Text == "Adata Value")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Frecuencia FROM ram1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canFrecuencia = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblFrecuencia1.Text = "Frecuencia:" + canFrecuencia;


            }
            if (comboBox2.Text == "T-Force Vulcan Z")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Frecuencia FROM ram1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canFrecuencia = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblFrecuencia2.Text = "Frecuencia:" + canFrecuencia;


            }
            else if (comboBox2.Text == "Adata Value")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Frecuencia FROM ram1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canFrecuencia = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblFrecuencia2.Text = "Frecuencia:" + canFrecuencia;


            }
        }
        private void DDR()
        {
            if (comboBox1.Text == "T-Force Vulcan Z")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT DDR FROM ram1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canDDR = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblDDR1.Text = "DDR:" + canDDR;

            }
            else if (comboBox1.Text == "Adata Value")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT DDR FROM ram1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canDDR = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblDDR1.Text = "DDR:" + canDDR;
            }
            if (comboBox2.Text == "T-Force Vulcan Z")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT DDR FROM ram1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canDDR = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblDDR2.Text = "DDR:" + canDDR;


            }
            else if (comboBox2.Text == "Adata Value")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT DDR FROM ram1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canDDR = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblDDR2.Text = "DDR:" + canDDR;
            }

        }
        private void Almacenamiento()
        {
            if (comboBox1.Text == "T-Force Vulcan Z")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Almacenamiento FROM ram1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canAlmacenamiento = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblAlmacenamiento1.Text = "Almacenamiento:" + canAlmacenamiento;

            }
            else if (comboBox1.Text == "Adata Value")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Almacenamiento FROM ram1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canAlmacenamiento = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblAlmacenamiento1.Text = "Almacenamiento:" + canAlmacenamiento;
            }
            if (comboBox2.Text == "T-Force Vulcan Z")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Almacenamiento FROM ram1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canAlmacenamiento = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblAlmacenamiento2.Text = "Almacenamiento:" + canAlmacenamiento;


            }
            else if (comboBox2.Text == "Adata Value")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Almacenamiento FROM ram1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canAlmacenamiento = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblAlmacenamiento2.Text = "Almacenamiento:" + canAlmacenamiento;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Frecuencia();

            DDR();

            Almacenamiento();
        }


    }

    }
