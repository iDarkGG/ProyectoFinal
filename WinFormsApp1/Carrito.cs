using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPerrona
{
    public class Carrito
    {

       private static List<Producto> productosComprados = new List<Producto>();

        public static void AddProduct(string s, decimal precio, int cant)
        {
            productosComprados.Add(new Producto(s, precio, cant));
        }

        public static ListViewItem[] ListaProductos()
        {
            ListViewItem[] lista = new ListViewItem[productosComprados.Count];
            for (int i = 0; i < productosComprados.Count; i++)
            {
                lista[i] = new ListViewItem(productosComprados[i].NombreProducto);
                lista[i].SubItems.Add(productosComprados[i].Precio.ToString("C"));
                lista[i].SubItems.Add(productosComprados[i].Cantidad.ToString());
                lista[i].SubItems.Add(productosComprados[i].PrecioBruto().ToString("C"));
            }
            return lista;            
        }

        public static void eliminarProducto(int index)
        {
            productosComprados.RemoveAt(index);
        }

        public static decimal PrecioSubtotal()
        {
            decimal subtotal = 0;
            foreach (Producto item in productosComprados)
                subtotal += item.PrecioBruto();
            
            return subtotal;
        }

        public static decimal PrecioImpuesto()
        {
            decimal impuesto = 0;
            foreach (Producto item in productosComprados)
                impuesto += item.CalcularIVA();

            return impuesto;
        }

        public static decimal PrecioTotal()
        {
            return PrecioSubtotal() + PrecioImpuesto();
        }

        public static void VaciarCarrito()
        {
            productosComprados.Clear();
        }
    }
}
