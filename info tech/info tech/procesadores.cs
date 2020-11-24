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
using info_tech.Properties;

namespace info_tech
{
    public partial class procesadores : Form
    {
        public procesadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void procesadores_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Generación();

            FrecuenciaTurbo();

            Hilos();

            Nucleos();
        }
        // creacion de un method 
        private void Generación()
        {
            if (comboBox1.Text == "intel i3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Generación FROM procesador1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canGeneración = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblGeneración1.Text = "Generación:" + canGeneración;
                object imagen = Resources.ResourceManager.GetObject("procesador1");
                picproce1.Image = (Image)imagen;


            }
            else if (comboBox1.Text == "Ryzen R3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Generación FROM procesador1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canGeneración = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblGeneración1.Text = "Generación:" + canGeneración;
                object imagen = Resources.ResourceManager.GetObject("procesador2");
                picproce1.Image = (Image)imagen;


            }
            if (comboBox2.Text == "intel i3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Generación FROM procesador1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canGeneración = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblGeneración2.Text = "Generación:" + canGeneración;
                object imagen = Resources.ResourceManager.GetObject("procesador1");
                picproce2.Image = (Image)imagen;


            }
            else if (comboBox2.Text == "Ryzen R3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Generación FROM procesador1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canGeneración = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblGeneración2.Text = "Generación:" + canGeneración;
                object imagen = Resources.ResourceManager.GetObject("procesador2");
                picproce2.Image = (Image)imagen;


            }
        }
        private void FrecuenciaTurbo()
        {
            if (comboBox1.Text == "intel i3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT FrecuenciaTurbo FROM procesador1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canFrecuenciaTurbo = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblFrecuenciaTurbo1.Text = "Frecuencia Turbo:" + canFrecuenciaTurbo;


            }
            else if (comboBox1.Text == "Ryzen R3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT FrecuenciaTurbo FROM procesador1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canFrecuenciaTurbo = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblFrecuenciaTurbo1.Text = "Frecuencia Turbo:" + canFrecuenciaTurbo;


            }
            if (comboBox2.Text == "intel i3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT FrecuenciaTurbo FROM procesador1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canFrecuenciaTurbo = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblFrecuenciaTurbo2.Text = "Frecuencia Turbo:" + canFrecuenciaTurbo;


            }
            else if (comboBox2.Text == "Ryzen R3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT FrecuenciaTurbo FROM procesador1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canFrecuenciaTurbo = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblFrecuenciaTurbo2.Text = "Frecuencia Turbo:" + canFrecuenciaTurbo;


            }
        }

        private void Hilos()
        {
            if (comboBox1.Text == "intel i3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Hilos FROM procesador1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canHilos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblHilos1.Text = "Hilos:" + canHilos;

            }
            else if (comboBox1.Text == "Ryzen R3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Hilos FROM procesador1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canHilos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblHilos1.Text = "Hilos:" + canHilos;
            }
            if (comboBox2.Text == "intel i3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Hilos FROM procesador1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canHilos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblHilos2.Text = "Hilos:" + canHilos;


            }
            else if (comboBox2.Text == "Ryzen R3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Hilos FROM procesador1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canHilos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblHilos2.Text = "Hilos:" + canHilos;
            }

        }
        private void Nucleos()
        {
            if (comboBox1.Text == "intel i3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Nucleos FROM procesador1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canNucleos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblNucleos1.Text = "Nucleos:" + canNucleos;

            }
            else if (comboBox1.Text == "Ryzen R3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Nucleos FROM procesador1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canNucleos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblNucleos1.Text = "Nucleos:" + canNucleos;
            }
            if (comboBox2.Text == "intel i3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Nucleos FROM procesador1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canNucleos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblNucleos2.Text = "Nucleos:" + canNucleos;


            }
            else if (comboBox2.Text == "Ryzen R3")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Nucleos FROM procesador1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canNucleos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblNucleos2.Text = "Nucleos:" + canNucleos;
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Generación();

            FrecuenciaTurbo();

            Hilos();

            Nucleos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
