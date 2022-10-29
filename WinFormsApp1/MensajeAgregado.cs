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
    public partial class MensajeAgregado : Form
    {
        public MensajeAgregado()
        {
            InitializeComponent();
        }
        int contaador = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
             contaador += 1;
            if (contaador == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
            

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void MensajeAgregado_Load(object sender, EventArgs e)
        {

        }
    }
}
