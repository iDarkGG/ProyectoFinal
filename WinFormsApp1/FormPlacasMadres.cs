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
    public partial class FormPlacasMadres : Form
    {
        public FormPlacasMadres()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarPlaca1_Click(object sender, EventArgs e)
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
                case "btnComprarPlaca1":
                    precio = sacarPrecio(lblPrecioPlaca1, "$", "+ IVA");
                    Carrito.AddProduct(lblPlaca1.Text, precio, Convert.ToInt32(cboCantPlaca1.SelectedItem.ToString()));
                    break;
                case "btnComprarPlaca2":
                    precio = sacarPrecio(lblPrecioPlaca2, "$", "+ IVA");
                    Carrito.AddProduct(lblPlaca2.Text, precio, Convert.ToInt32(cboCantPlaca2.SelectedItem.ToString()));
                    break;
                case "btnComprarPlaca3":
                    precio = sacarPrecio(lblPrecioPlaca3, "$", "+ IVA");
                    Carrito.AddProduct(lblPlaca3.Text, precio, Convert.ToInt32(cboCantPlaca3.SelectedItem.ToString()));
                    break;
                case "btnComprarPlaca4":
                    precio = sacarPrecio(lblPrecioPlaca4, "$", "+ IVA");
                    Carrito.AddProduct(lblPlaca4.Text, precio, Convert.ToInt32(cboCantPlaca4.SelectedItem.ToString()));
                    break;
                case "btnComprarPlaca5":
                    precio = sacarPrecio(lblPrecioPlaca5, "$", "+ IVA");
                    Carrito.AddProduct(lblPlaca5.Text, precio, Convert.ToInt32(cboCantPlaca5.SelectedItem.ToString()));
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
