using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace TiendaPerrona  
{
  
    public partial class FormDelCase : Form 
    {
       private MensajeAgregado form1 = new MensajeAgregado();
        public FormDelCase()
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
           // MessageBox.Show($"El nombre del producto es: {Carrito.ProductosComprados.ElementAt(n).NombreProducto}" ,"test");
        }

        private void IdentifyButton(PictureBox b)
        {
            decimal precio = 0;
            switch (b.Name)
            {
                case "btnComprarCase1":
                    precio = sacarPrecio(lblPrecioCase1, "$", "+ IVA");
                    Carrito.AddProduct(lblCaseGamer1.Text,precio,Convert.ToInt32(lbCantidadCase1.Text));  
                    break;
                case "btnComprarCase2":
                    precio = sacarPrecio(lblPrecioCase2, "$", "+ IVA");
                    Carrito.AddProduct(lblCaseGamer2.Text, precio, Convert.ToInt32(lbCantidadCase2.Text));
                    break;
                case "btnComprarCase3":
                    precio = sacarPrecio(lblPrecioCase3, "$", "+ IVA");
                    Carrito.AddProduct(lblCaseGamer3.Text, precio, Convert.ToInt32(lbCantidadCase3.Text));
                    break;
                case "btnComprarCase4":
                    precio = sacarPrecio(lblPrecioCase4, "$", "+ IVA");
                    Carrito.AddProduct(lblCaseGamer4.Text, precio, Convert.ToInt32(lbCantidadCase4.Text));
                    break;
                case "btnComprarCase5":
                    precio = sacarPrecio(lblPrecioCase5, "$", "+ IVA");
                    Carrito.AddProduct(lblCaseGamer5.Text, precio, Convert.ToInt32(lbCantidadCase5.Text));
                    break;
                case "btnComprarCase6":
                    precio = sacarPrecio(lblPrecioCase6, "$", "+ IVA");
                    Carrito.AddProduct(lblCaseGamer6.Text, precio, Convert.ToInt32(lbCantidadCase6.Text));
                    break;
            }
        }

        private decimal sacarPrecio(Label l,string a,string b)
        {
            string x = l.Text;
            x = x.Replace(a, "");
            x = x.Replace(b, "");
            return Convert.ToDecimal(x);
        }

        private void FormDelCase_Load(object sender, EventArgs e)
        {

        }
    }
}
