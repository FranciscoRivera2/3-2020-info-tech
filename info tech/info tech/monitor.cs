﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel();
            Resolución();
            Hercios();
            Pulgadas();
        }
        // creacion de un method 
        private void Panel()
        {
            if (comboBox1.Text == "LG 24gl600f")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Panel FROM monitor1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPanel = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPanel1.Text = "Panel:" + canPanel;
                object imagen = Resources.ResourceManager.GetObject("monitor1");
                picmonitor1.Image = (Image)imagen;


            }
            else if (comboBox1.Text == "Viewsonic VX3276-4K-MHD")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Panel FROM monitor1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPanel = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPanel1.Text = "Panel:" + canPanel;
                object imagen = Resources.ResourceManager.GetObject("monitor2");
                picmonitor1.Image = (Image)imagen;


            }
            if (comboBox2.Text == "LG 24gl600f")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Panel FROM monitor1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPanel = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPanel2.Text = "Panel:" + canPanel;
                object imagen = Resources.ResourceManager.GetObject("monitor1");
                picmonitor2.Image = (Image)imagen;


            }
            else if (comboBox2.Text == "Viewsonic VX3276-4K-MHD")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Panel FROM monitor1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPanel = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPanel2.Text = "Panel:" + canPanel;
                object imagen = Resources.ResourceManager.GetObject("monitor2");
                picmonitor2.Image = (Image)imagen;


            }
        }
        private void Resolución()
        {
            if (comboBox1.Text == "LG 24gl600f")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Resolución FROM monitor1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canResolución = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblResolución1.Text = "Resolución:" + canResolución;

            }
            else if (comboBox1.Text == "Viewsonic VX3276-4K-MHD")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Resolución FROM monitor1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canResolución = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblResolución1.Text = "Resolución:" + canResolución;
            }
            if (comboBox2.Text == "LG 24gl600f")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Resolución FROM monitor1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canResolución = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblResolución2.Text = "Resolución:" + canResolución;


            }
            else if (comboBox2.Text == "Viewsonic VX3276-4K-MHD")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Resolución FROM monitor1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canResolución = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblResolución2.Text = "Resolución:" + canResolución;
            }

        }
        private void Hercios()
        {
            if (comboBox1.Text == "LG 24gl600f")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Hercios FROM monitor1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canHercios = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblHercios1.Text = "Hercios:" + canHercios;

            }
            else if (comboBox1.Text == "Viewsonic VX3276-4K-MHD")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Hercios FROM monitor1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canHercios = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblHercios1.Text = "Hercios:" + canHercios;
            }
            if (comboBox2.Text == "LG 24gl600f")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Hercios FROM monitor1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canHercios = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblHercios2.Text = "Hercios:" + canHercios;


            }
            else if (comboBox2.Text == "Viewsonic VX3276-4K-MHD")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Hercios FROM monitor1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canHercios = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblHercios2.Text = "Hercios:" + canHercios;
            }

        }
        private void Pulgadas()
        {
            if (comboBox1.Text == "LG 24gl600f")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Pulgadas FROM monitor1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPulgadas = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPulgadas1.Text = "Pulgadas:" + canPulgadas;

            }
            else if (comboBox1.Text == "Viewsonic VX3276-4K-MHD")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Pulgadas FROM monitor1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPulgadas = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPulgadas1.Text = "Pulgadas:" + canPulgadas;
            }
            if (comboBox2.Text == "LG 24gl600f")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Pulgadas FROM monitor1 WHERE Id = 1", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPulgadas = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPulgadas2.Text = "Pulgadas:" + canPulgadas;


            }
            else if (comboBox2.Text == "Viewsonic VX3276-4K-MHD")
            {
                //coneccion con la basedata
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = nuevainfotech.accdb");
                //abrimos coneccion
                con.Open();
                // comando de lo que va a ser "SELECT nombre de campo FROM nombre de entidad WHERE Id = ...", con
                OleDbCommand cmd = new OleDbCommand("SELECT Pulgadas FROM monitor1 WHERE Id = 2", con);
                //lee lo que ejecuto el cmd
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // hasta aca 
                //en una variable string guarda lo que saco de la base de datos
                string canPulgadas = rd.GetString(0);
                // aca abajo iria el label en donde se imprime el string previamente dicho
                lblPulgadas2.Text = "Pulgadas:" + canPulgadas;
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel();

            Resolución();

            Hercios();

            Pulgadas();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
