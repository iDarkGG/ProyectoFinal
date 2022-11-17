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
    public partial class FormFuentesDePoder : Form
    {
        public FormFuentesDePoder()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
                case "btnFuente1":
                    precio = sacarPrecio(lblPrecioFuente1, "$", "+ IVA");
                    Carrito.AddProduct(lblFuente1.Text, precio, Convert.ToInt32(cboCantFuente1.SelectedItem.ToString()));
                    break;
                case "btnFuente2":
                    precio = sacarPrecio(lblPrecioFuente2, "$", "+ IVA");
                    Carrito.AddProduct(lblFuente2.Text, precio, Convert.ToInt32(cboCantFuente2.SelectedItem.ToString()));
                    break;
                case "btnFuente3":
                    precio = sacarPrecio(lblPrecioFuente3, "$", "+ IVA");
                    Carrito.AddProduct(lblFuente3.Text, precio, Convert.ToInt32(cboCantFuente3.SelectedItem.ToString()));
                    break;
                case "btnFuente4":
                    precio = sacarPrecio(lblPrecioFuente4, "$", "+ IVA");
                    Carrito.AddProduct(lblFuente4.Text, precio, Convert.ToInt32(cboCantFuente4.SelectedItem.ToString()));
                    break;
                case "btnFuente5":
                    precio = sacarPrecio(lblPrecioFuente5, "$", "+ IVA");
                    Carrito.AddProduct(lblFuente5.Text, precio, Convert.ToInt32(cboCantFuente5.SelectedItem.ToString()));
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
