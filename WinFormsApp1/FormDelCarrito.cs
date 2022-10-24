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
    public partial class FormDelCarrito : Form
    {
        Libreria.PaginaPrincipal uwu = new Libreria.PaginaPrincipal();
        public FormDelCarrito()
        {
            InitializeComponent();
            CargarProductos();
        }
        

        private void btnSeguirComprando_Click(object sender, EventArgs e)
        {
            this.Close();
            uwu.Show();
        }

        private void CargarProductos()
        {
            ListViewItem[]  productos = Carrito.ListaProductos();
            foreach(ListViewItem item in productos)
            {
                lvListaDelCarritoDeCompras.Items.Add(item);
            }

            CargarLabels();
        }

        private void lvListaDelCarritoDeCompras_DoubleClick(object sender, EventArgs e)
        {
            //borrar
        }

        private void lvListaDelCarritoDeCompras_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem eliminarProducto = lvListaDelCarritoDeCompras.GetItemAt(e.X, e.Y);
            DialogResult d = MessageBox.Show("¿Esta Seguro que desea aliminar este producto?","¡Advertencia!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(d == DialogResult.Yes)
            {
                Carrito.eliminarProducto(eliminarProducto.Index);
                lvListaDelCarritoDeCompras.Items.Remove(eliminarProducto);
                CargarLabels();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Su compra se ha realizado con exito!","Mensaje");
            lvListaDelCarritoDeCompras.Items.Clear();
            Carrito.VaciarCarrito();
        }

        private void CargarLabels()
        {
            lblDescuento.Text = "C$ 0.00";
            lblImpuesto.Text = Carrito.PrecioImpuesto().ToString("C");
            lblSubTotal.Text = Carrito.PrecioSubtotal().ToString("C");
            lblTotal.Text = Carrito.PrecioTotal().ToString("C");
        }
    }
}
