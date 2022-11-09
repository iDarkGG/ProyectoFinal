using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace TiendaPerrona
{
    public interface ICargarProducto
    {
        public void createXml()
        {
            XElement xd = new XElement("Productos");
            XElement nuevoProducto = new XElement("Producto");
            nuevoProducto.Add(new XAttribute("Nombre del producto","tarjeta grafica"));
            nuevoProducto.Add(new XElement("Precio","15.3"));
            xd.Add(nuevoProducto);
            xd.Save("ElementosProductos.txt");
        }


        public void cargarXml()
        {
            var xddd = "path";
            XElement xml = XElement.Load(xddd);
            var lmao = from lol in xml.Element("Productos").Elements("Producto") select lol;
        }
    }
}
