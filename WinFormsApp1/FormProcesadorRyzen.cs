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
    public partial class FormProcesadorRyzen : Form
    {
        public FormProcesadorRyzen()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprarRyzen1_Click(object sender, EventArgs e)
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
                case "btnComprarRyzen1":
                    precio = sacarPrecio(lblPrecioRyzen1, "$", "+ IVA");
                    Carrito.AddProduct(lblRyzen1.Text, precio, Convert.ToInt32(cboRyzen1.SelectedItem.ToString()));
                    break;
                case "btnComprarRyzen2":
                    precio = sacarPrecio(lblPrecioRyzen2, "$", "+ IVA");
                    Carrito.AddProduct(lblRyzen2.Text, precio, Convert.ToInt32(cboRyzen2.SelectedItem.ToString()));
                    break;
                case "btnComprarRyzen3":
                    precio = sacarPrecio(lblPrecioRyzen3, "$", "+ IVA");
                    Carrito.AddProduct(lblRyzen3.Text, precio, Convert.ToInt32(cboRyzen3.SelectedItem.ToString()));
                    break;
                case "btnComprarRyzen4":
                    precio = sacarPrecio(lblPrecioRyzen4, "$", "+ IVA");
                    Carrito.AddProduct(lblRyzen4.Text, precio, Convert.ToInt32(cboRyzen4.SelectedItem.ToString()));
                    break;
                case "btnComprarRyzen5":
                    precio = sacarPrecio(lblPrecioRyzen5, "$", "+ IVA");
                    Carrito.AddProduct(lblRyzen5.Text, precio, Convert.ToInt32(cboRyzen5.SelectedItem.ToString()));
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
