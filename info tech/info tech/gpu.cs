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
    public partial class gpu : Form
    {
        public gpu()
        {
            InitializeComponent();
        }

        private void gpu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gama();

            Vram();

            DDR();
        }
        // creacion de un method 
        private void Gama()
        {
            if (comboBox1.Text == "Nvidea 1660 Super")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Gama FROM gpu1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canGama = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblGama1.Text = "Gama:" + canGama;
                object imagen = Resources.ResourceManager.GetObject("gpu1");
                picgpu1.Image = (Image)imagen;


            }
            else if (comboBox1.Text == "Radeon 590")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Gama FROM gpu1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canGama = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblGama1.Text = "Gama:" + canGama;
                object imagen = Resources.ResourceManager.GetObject("gpu2");
                picgpu1.Image = (Image)imagen;


            }
            if (comboBox2.Text == "Nvidea 1660 Super")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Gama FROM gpu1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canGama = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblGama2.Text = "Gama:" + canGama;
                object imagen = Resources.ResourceManager.GetObject("gpu1");
                picgpu2.Image = (Image)imagen;


            }
            else if (comboBox2.Text == "Radeon 590")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Gama FROM gpu1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canGama = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblGama2.Text = "Gama:" + canGama;
                object imagen = Resources.ResourceManager.GetObject("gpu2");
                picgpu2.Image = (Image)imagen;


            }
        }
        private void Vram()
        {
            if (comboBox1.Text == "Nvidea 1660 Super")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Vram FROM gpu1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canVram = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblVram1.Text = "Vram:" + canVram;

            }
            else if (comboBox1.Text == "Radeon 590")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Vram FROM gpu1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canVram = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblVram1.Text = "Vram:" + canVram;
            }
            if (comboBox2.Text == "Nvidea 1660 Super")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Vram FROM gpu1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canVram = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblVram2.Text = "Vram:" + canVram;


            }
            else if (comboBox2.Text == "Radeon 590")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Vram FROM gpu1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canVram = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblVram2.Text = "Vram:" + canVram;
            }

        }
        private void DDR()
        {
            if (comboBox1.Text == "Nvidea 1660 Super")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT DDR FROM gpu1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canDDR = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblDDR1.Text = "DDR:" + canDDR;

            }
            else if (comboBox1.Text == "Radeon 590")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT DDR FROM gpu1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canDDR = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblDDR1.Text = "DDR:" + canDDR;
            }
            if (comboBox2.Text == "Nvidea 1660 Super")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT DDR FROM gpu1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canDDR = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblDDR2.Text = "DDR:" + canDDR;


            }
            else if (comboBox2.Text == "Radeon 590")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT DDR FROM gpu1 WHERE Id = 2", con);
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gama();

            Vram();

            DDR();
        }
    }
}
