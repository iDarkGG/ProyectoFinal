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
    public partial class FormMouse : Form
    {
        public FormMouse()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprarMouse1_Click(object sender, EventArgs e)
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
                case "btnComprarMouse1":
                    precio = sacarPrecio(lblPrecioMouse1, "$", "+ IVA");
                    Carrito.AddProduct(lblMouse1.Text, precio, Convert.ToInt32(cboCantMouse1.SelectedItem.ToString()));
                    break;
                case "btnComprarMouse2":
                    precio = sacarPrecio(lblPrecioMouse2, "$", "+ IVA");
                    Carrito.AddProduct(lblMouse2.Text, precio, Convert.ToInt32(cboCantMouse2.SelectedItem.ToString()));
                    break;
                case "btnComprarMouse3":
                    precio = sacarPrecio(lblPrecioMouse3, "$", "+ IVA");
                    Carrito.AddProduct(lblMouse3.Text, precio, Convert.ToInt32(cboCantMouse3.SelectedItem.ToString()));
                    break;
                case "btnComprarMouse4":
                    precio = sacarPrecio(lblPrecioMouse4, "$", "+ IVA");
                    Carrito.AddProduct(lblMouse4.Text, precio, Convert.ToInt32(cboCantMouse4.SelectedItem.ToString()));
                    break;
                case "btnComprarMouse5":
                    precio = sacarPrecio(lblPrecioMouse5, "$", "+ IVA");
                    Carrito.AddProduct(lblMouse5.Text, precio, Convert.ToInt32(cboCantMouse5.SelectedItem.ToString()));
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
