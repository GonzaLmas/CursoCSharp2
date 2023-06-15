using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Escritorio
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void tbxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8 )
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text == "")
                tbxNombre.BackColor = Color.Red;
            if (tbxApellido.Text == "")
                tbxApellido.BackColor = Color.Red;   
            if (tbxEdad.Text == "")
                tbxEdad.BackColor = Color.Red;
            if (tbxDirec.Text == "")
                tbxDirec.BackColor = Color.Red;

            string Apellido = tbxApellido.Text;
            string Nombre = tbxNombre.Text;
            string Edad = tbxEdad.Text;
            string Direc = tbxDirec.Text;

            tbxRes.AppendText("Apellido y Nombre: " + Apellido + " " + Nombre + Environment.NewLine);
            tbxRes.AppendText("Edad: " + Edad + Environment.NewLine);
            tbxRes.AppendText("Dirección: " + Direc);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
