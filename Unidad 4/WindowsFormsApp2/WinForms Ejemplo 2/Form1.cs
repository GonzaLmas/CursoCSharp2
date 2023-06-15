using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Ejemplo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxColor.Items.Add("Rojo");
            cbxColor.Items.Add("Verde");
            cbxColor.Items.Add("Azul");

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = tbxNombre.Text;
            DateTime fecha = dtpFecha.Value;

            //Operador Ternario (es como si fuese un "if")
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "NO le gusta el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            string colorFavorito = cbxColor.SelectedItem.ToString();
            string numeroFavorito = numNumeroFav.Value.ToString();

            //Concateno TODOS los datos para que lo muestre en texto
            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su número fav es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + ", " + mensaje);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
