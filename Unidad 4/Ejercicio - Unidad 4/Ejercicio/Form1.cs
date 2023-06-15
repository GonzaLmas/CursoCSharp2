using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void App_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento Click", "Atención");
            //this.BackColor = Color.Blue;
            if (tbxApellido.Text == "")
                tbxApellido.BackColor = Color.Cyan;
            else
                tbxApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Frm_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el botón izquierdo");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el botón derecho");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presionó el botón del medio");
        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void tbxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbxNuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + tbxNuevo.Text.Length + " caracteres");
        }
    }
}
