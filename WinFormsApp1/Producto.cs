using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPerrona
{
    public class Producto
    {
        private string nombreProducto;
        private decimal precio;
        private int cantidad;

        public Producto(string nombreProducto, decimal precio, int cantidad)
        {
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
        }

        public decimal Precio
        {
            get { return precio; }
        }

        public int Cantidad
        {
            get { return cantidad; }
        }

        public decimal CalcularIVA()
        {
            return precio * 15 / 100;
        }

        public decimal PrecioBruto()
        {
            return precio * cantidad;
        }



       
    }
}
