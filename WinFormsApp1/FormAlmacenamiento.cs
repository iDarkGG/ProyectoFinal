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
    public partial class FormAlmacenamiento : Form
    {
        public FormAlmacenamiento()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprarCase1_Click(object sender, EventArgs e)
        {
            MensajeAgregado abrirForm = new MensajeAgregado();
            abrirForm.Show();

            PictureBox btnSeleccionado = sender as PictureBox;
            IdentifyButton(btnSeleccionado);
        }
        private void IdentifyButton(PictureBox b)
        {
            int i = cboCantAlmacenamieto1.SelectedIndex;
            decimal precio = 0;
            switch (b.Name)
            {
                case "btnAlmacenamieto1":
                    precio = sacarPrecio(lblPrecioAlmacenamieto1, "$", "+ IVA");
                    Carrito.AddProduct(lblAlmacenamieto1.Text, precio, Convert.ToInt32(cboCantAlmacenamieto1.SelectedItem.ToString()));
                    break;
                case "btnAlmacenamieto2":
                    precio = sacarPrecio(lblPrecioAlmacenamieto2, "$", "+ IVA");
                    Carrito.AddProduct(lblAlmacenamieto2.Text, precio, Convert.ToInt32(cboCantAlmacenamieto2.SelectedItem.ToString()));
                    break;
                case "btnAlmacenamieto3":
                    precio = sacarPrecio(lblPrecioAlmacenamieto3, "$", "+ IVA");
                    Carrito.AddProduct(lblAlmacenamieto3.Text, precio, Convert.ToInt32(cboCantAlmacenamieto3.SelectedItem.ToString()));
                    break;
                case "btnAlmacenamieto4":
                    precio = sacarPrecio(lblPrecioAlmacenamieto4, "$", "+ IVA");
                    Carrito.AddProduct(lblAlmacenamieto4.Text, precio, Convert.ToInt32(cboCantAlmacenamieto4.SelectedItem.ToString()));
                    break;
                case "btnAlmacenamieto5":
                    precio = sacarPrecio(lblPrecioAlmacenamieto5, "$", "+ IVA");
                    Carrito.AddProduct(lblAlmacenamieto5.Text, precio, Convert.ToInt32(cboCantAlmacenamieto5.SelectedItem.ToString()));
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
