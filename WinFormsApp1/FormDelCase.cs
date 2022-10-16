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
    public partial class FormDelCase : Form
    {
        MensajeAgregado form1 = new MensajeAgregado();
        public FormDelCase()
        {
            InitializeComponent();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
            form1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            form1.Show(); 
        }
    }
}
