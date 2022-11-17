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
    public partial class FormMemoriasRam : Form
    {
        public FormMemoriasRam()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
                case "btnComprarMemoria1":
                    precio = sacarPrecio(lblPrecioMemoria1, "$", "+ IVA");
                    Carrito.AddProduct(lblMemoria1.Text, precio, Convert.ToInt32(cboCantMemoria1.SelectedItem.ToString()));
                    break;
                case "btnComprarMemoria2":
                    precio = sacarPrecio(lblPrecioMemoria2, "$", "+ IVA");
                    Carrito.AddProduct(lblMemoria2.Text, precio, Convert.ToInt32(cboCantMemoria2.SelectedItem.ToString()));
                    break;
                case "btnComprarMemoria3":
                    precio = sacarPrecio(lblPrecioMemoria3, "$", "+ IVA");
                    Carrito.AddProduct(lblMemoria3.Text, precio, Convert.ToInt32(cboCantMemoria3.SelectedItem.ToString()));
                    break;
                case "btnComprarMemoria4":
                    precio = sacarPrecio(lblPrecioMemoria4, "$", "+ IVA");
                    Carrito.AddProduct(lblMemoria4.Text, precio, Convert.ToInt32(cboCantMemoria4.SelectedItem.ToString()));
                    break;
                case "btnComprarMemoria5":
                    precio = sacarPrecio(lblPrecioMemoria5, "$", "+ IVA");
                    Carrito.AddProduct(lblMemoria5.Text, precio, Convert.ToInt32(cboCantMemoria5.SelectedItem.ToString()));
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







        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
