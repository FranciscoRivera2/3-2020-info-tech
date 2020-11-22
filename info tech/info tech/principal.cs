using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace info_tech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new almacenamiento();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new rams();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new gpu();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new procesadores();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new fuente();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newForm = new gabinete();
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new Form3();
            newForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new mother();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
