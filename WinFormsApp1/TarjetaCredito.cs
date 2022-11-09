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
    public partial class TarjetaCredito : Form
    {
        private Regex rg = new Regex(@"\d{4}\s+\d{4}\s+\d{4}\s+\d{3,4}");
        public TarjetaCredito()
        {
            InitializeComponent();
        }

        private void TarjetaCredito_Load(object sender, EventArgs e)
        {

        }

        private void btnPagarTarjeta_Click(object sender, EventArgs e)
        {
                
        }
    }
}
