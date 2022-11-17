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
    public partial class FormMonitores : Form
    {
        public FormMonitores()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprarMonitor1_Click(object sender, EventArgs e)
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
                case "btnComprarMonitor1":
                    precio = sacarPrecio(lblPrecioMonitor1, "$", "+ IVA");
                    Carrito.AddProduct(lblMonitor1.Text, precio, Convert.ToInt32(cboCantMonitor1.SelectedItem.ToString()));
                    break;
                case "btnComprarMonitor2":
                    precio = sacarPrecio(lblPrecioMonitor2, "$", "+ IVA");
                    Carrito.AddProduct(lblMonitor2.Text, precio, Convert.ToInt32(cboCantMonitor2.SelectedItem.ToString()));
                    break;
                case "btnComprarMonitor3":
                    precio = sacarPrecio(lblPrecioMonitor3, "$", "+ IVA");
                    Carrito.AddProduct(lblMonitor3.Text, precio, Convert.ToInt32(cboCantMonitor3.SelectedItem.ToString()));
                    break;
                case "btnComprarMonitor4":
                    precio = sacarPrecio(lblPrecioMonitor4, "$", "+ IVA");
                    Carrito.AddProduct(lblMonitor4.Text, precio, Convert.ToInt32(cboCantMonitor4.SelectedItem.ToString()));
                    break;
                case "btnComprarMonitor5":
                    precio = sacarPrecio(lblPrecioMonitor5, "$", "+ IVA");
                    Carrito.AddProduct(lblMonitor5.Text, precio, Convert.ToInt32(cboCantMonitor5.SelectedItem.ToString()));
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
