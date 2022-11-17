using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaPerrona
{
    public partial class FormTarjetasGraficas : Form
    {
        public FormTarjetasGraficas()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnComprarGrafica1_Click(object sender, EventArgs e)
        {
            MensajeAgregado abrirForm = new MensajeAgregado();
            abrirForm.Show();

            PictureBox btnSeleccionado = sender as PictureBox;
            IdentifyButton(btnSeleccionado);
        }
        private void IdentifyButton(PictureBox b)
        {
            decimal precio = 0;
            switch (b.Name)
            {
                case "btnComprarGrafica1":
                    precio = sacarPrecio(lblPrecioGrafica1, "$", "+ IVA");
                    Carrito.AddProduct(lblGrafica1.Text, precio, Convert.ToInt32(cboGrafica1.SelectedItem.ToString()));
                    break;
                case "btnComprarGrafica2":
                    precio = sacarPrecio(lblPrecioGrafica2, "$", "+ IVA");
                    Carrito.AddProduct(lblGrafica2.Text, precio, Convert.ToInt32(cboGrafica2.SelectedItem.ToString()));
                    break;
                case "btnComprarGrafica3":
                    precio = sacarPrecio(lblPrecioGrafica3, "$", "+ IVA");
                    Carrito.AddProduct(lblGrafica3.Text, precio, Convert.ToInt32(cboGrafica3.SelectedItem.ToString()));
                    break;
                case "btnComprarGrafica4":
                    precio = sacarPrecio(lblPrecioGrafica4, "$", "+ IVA");
                    Carrito.AddProduct(lblGrafica4.Text, precio, Convert.ToInt32(cboGrafica4.SelectedItem.ToString()));
                    break;
                case "btnComprarGrafica5":
                    precio = sacarPrecio(lblPrecioGrafica5, "$", "+ IVA");
                    Carrito.AddProduct(lblGrafica5.Text, precio, Convert.ToInt32(cboGrafica5.SelectedItem.ToString()));
                    break;
            }
        }

        private decimal sacarPrecio(Label l, string a, string b)
        {
            string x = l.Text;
            x = x.Replace(a, "");
            x = x.Replace(b, "");
            return Convert.ToDecimal(x);
        }
    }
}
