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
    public partial class FormTeclados : Form
    {
        public FormTeclados()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FormTeclados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnComprarTeclado1_Click(object sender, EventArgs e)
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
                case "btnComprarTeclado1":
                    precio = sacarPrecio(lblPrecioTeclado1, "$", "+ IVA");
                    Carrito.AddProduct(lblTeclado1.Text, precio, Convert.ToInt32(cboCantTeclado1.SelectedItem.ToString()));
                    break;
                case "btnComprarTeclado2":
                    precio = sacarPrecio(lblPrecioTeclado2, "$", "+ IVA");
                    Carrito.AddProduct(lblTeclado2.Text, precio, Convert.ToInt32(cboCantTeclado2.SelectedItem.ToString()));
                    break;
                case "btnComprarTeclado3":
                    precio = sacarPrecio(lblPrecioTeclado3, "$", "+ IVA");
                    Carrito.AddProduct(lblTeclado3.Text, precio, Convert.ToInt32(cboCantTeclado3.SelectedItem.ToString()));
                    break;
                case "btnComprarTeclado4":
                    precio = sacarPrecio(lblPrecioTeclado4, "$", "+ IVA");
                    Carrito.AddProduct(lblTeclado4.Text, precio, Convert.ToInt32(cboCantTeclado4.SelectedItem.ToString()));
                    break;
                case "btnComprarTeclado5":
                    precio = sacarPrecio(lblPrecioTeclado5, "$", "+ IVA");
                    Carrito.AddProduct(lblTeclado5.Text, precio, Convert.ToInt32(cboCantTeclado5.SelectedItem.ToString()));
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
