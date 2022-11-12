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
        PaginaPrincipal uwu = new PaginaPrincipal();
        private static string _user;
        public string User { get { return _user; } set { _user = value; } }
        public FormDelCarrito()
        {
            InitializeComponent();
            CargarProductos();
            lblNombreDeUsuario.Text = _user;
        }
        

        private void btnSeguirComprando_Click(object sender, EventArgs e)
        {
            this.Close();
           
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
            TarjetaCredito uwu = new TarjetaCredito();

            uwu.Show();
           
            
            
        }

        private void CargarLabels()
        {
            lblDescuento.Text = "C$ 0.00";
            lblImpuesto.Text = Carrito.PrecioImpuesto().ToString("C");
            lblSubTotal.Text = Carrito.PrecioSubtotal().ToString("C");
            lblTotal.Text = Carrito.PrecioTotal().ToString("C");
        }

        private void lvListaDelCarritoDeCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cleanAll()
        {
            lvListaDelCarritoDeCompras.Items.Clear();
            Carrito.VaciarCarrito();
            lblDescuento.Text = "C$ 0.00";
            lblImpuesto.Text = "C$ 0.00";
            lblNombreDeUsuario.Text = "C$ 0.00";
            lblSubTotal.Text = "C$ 0.00";
            lblTotal.Text = "C$ 0.00";
        }

        private void lblNombreDeUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
