using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Ejemplo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHaceClick_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola");

            string texto = textBox1.Text;
            label1.Text = "Hola " + texto;    




        }


    }
}
