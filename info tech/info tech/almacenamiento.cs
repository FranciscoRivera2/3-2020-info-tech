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
    public partial class almacenamiento : Form
    {
        public almacenamiento()
        {
            InitializeComponent();
        }

        private void almacenamiento_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipo();
        }
        // creacion de un method 
        private void Tipo()
        {
            if (comboBox1.Text == "Seagate barracuda")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Tipo FROM Almacenamiento1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canTipo = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblTipo1.Text = "Tipo:" + canTipo;


            }
            else if (comboBox1.Text == "WD green")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Tipo FROM Almacenamiento1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canTipo = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblTipo1.Text = "Tipo:" + canTipo;


            }
            if (comboBox2.Text == "Seagate barracuda")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Tipo FROM Almacenamiento1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canTipo = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblTipo2.Text = "Tipo:" + canTipo;


            }
            else if (comboBox2.Text == "WD green")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Tipo FROM Almacenamiento1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canTipo = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblTipo2.Text = "Tipo:" + canTipo;


            }
        }
        private void Almacenamiento()
        {
            if (comboBox1.Text == "Seagate barracuda")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Almacenamiento FROM Almacenamiento1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canAlmacenamiento = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblAlmacenamiento1.Text = "Almacenamiento:" + canAlmacenamiento;

            }
            else if (comboBox1.Text == "WD green")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Almacenamiento FROM Almacenamiento1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canAlmacenamiento = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblAlmacenamiento1.Text = "Almacenamiento:" + canAlmacenamiento;
            }
            if (comboBox2.Text == "Seagate barracuda")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Almacenamiento FROM Almacenamiento1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canAlmacenamiento = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblAlmacenamiento2.Text = "Almacenamiento:" + canAlmacenamiento;


            }
            else if (comboBox2.Text == "WD green")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Almacenamiento FROM Almacenamiento1 WHERE Id = 2", con);
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
    }
}
