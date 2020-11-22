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
    public partial class mother : Form
    {
        public mother()
        {
            InitializeComponent();
        }

        private void mother_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modulos();
        }
        // creacion de un method 
        private void Modulos()
        {
            if (comboBox1.Text == "Gigabyte Z390 M")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Modulos FROM mother1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canModulos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblModulos1.Text = "Modulos:" + canModulos;


            }
            else if (comboBox1.Text == "ASUS PRIME B460M - A")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Modulos FROM mother1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canModulos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblModulos1.Text = "Modulos:" + canModulos;


            }
            if (comboBox2.Text == "Gigabyte Z390 M")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Modulos FROM mother1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canModulos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblModulos2.Text = "Modulos:" + canModulos;


            }
            else if (comboBox2.Text == "ASUS PRIME B460M - A")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Modulos FROM mother1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canModulos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblModulos2.Text = "Modulos:" + canModulos;


            }
        }
        private void Puertos()
        {
            if (comboBox1.Text == "Gigabyte Z390 M")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Puertos FROM mother1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPuertos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPuertos1.Text = "Puertos:" + canPuertos;

            }
            else if (comboBox1.Text == "ASUS PRIME B460M - A")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Puertos FROM mother1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPuertos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPuertos1.Text = "Puertos:" + canPuertos;
            }
            if (comboBox2.Text == "Gigabyte Z390 M")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Puertos FROM mother1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPuertos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPuertos2.Text = "Puertos:" + canPuertos;


            }
            else if (comboBox2.Text == "ASUS PRIME B460M - A")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Puertos FROM mother1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPuertos = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPuertos2.Text = "Puertos:" + canPuertos;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modulos();

            Puertos();
        }

        private void lblmodulos1_Click(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Form1();
            newForm.Show();
        }
    }
   
}
