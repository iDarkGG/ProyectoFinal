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
    public partial class FormProcesadorIntel : Form
    {
        public FormProcesadorIntel()
        {
            InitializeComponent();
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProcesadorIntel_Load(object sender, EventArgs e)
        {
            
        }

        private void btnComprarProcesador1_Click(object sender, EventArgs e)
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
                case "btnComprarProcesador1":
                    precio = sacarPrecio(lblPrecioProcesador1, "$", "+ IVA");
                    Carrito.AddProduct(lblProcesador1.Text, precio, Convert.ToInt32(cboProcesador1.SelectedItem.ToString()));
                    break;
                case "btnComprarProcesador2":
                    precio = sacarPrecio(lblPrecioProcesador2, "$", "+ IVA");
                    Carrito.AddProduct(lblProcesador2.Text, precio, Convert.ToInt32(cboProcesador2.SelectedItem.ToString()));
                    break;
                case "btnComprarProcesador3":
                    precio = sacarPrecio(lblPrecioProcesador3, "$", "+ IVA");
                    Carrito.AddProduct(lblProcesador3.Text, precio, Convert.ToInt32(cboProcesador3.SelectedItem.ToString()));
                    break;
                case "btnComprarProcesador4":
                    precio = sacarPrecio(lblPrecioProcesador4, "$", "+ IVA");
                    Carrito.AddProduct(lblProcesador4.Text, precio, Convert.ToInt32(cboProcesador4.SelectedItem.ToString()));
                    break;
                case "btnComprarProcesador5":
                    precio = sacarPrecio(lblPrecioProcesador5, "$", "+ IVA");
                    Carrito.AddProduct(lblProcesador5.Text, precio, Convert.ToInt32(cboProcesador5.SelectedItem.ToString()));
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
