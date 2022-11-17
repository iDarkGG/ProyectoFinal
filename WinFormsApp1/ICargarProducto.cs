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
        protected void IdentifyButton(PictureBox b);

        protected decimal sacarPrecio(Label l, string a, string b);
    }
}
