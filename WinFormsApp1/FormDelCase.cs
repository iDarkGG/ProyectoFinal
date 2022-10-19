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

       

        private void btnComprarCase1_Click(object sender, EventArgs e)
        {
            MensajeAgregado abrirForm = new MensajeAgregado();
            abrirForm.Show();
        }

        private void btnComprarCase2_Click(object sender, EventArgs e)
        {
            MensajeAgregado abrirForm = new MensajeAgregado();
            abrirForm.Show();
        }

        private void btnComprarCase3_Click(object sender, EventArgs e)
        {
            MensajeAgregado abrirForm = new MensajeAgregado();
            abrirForm.Show();
        }

        private void btnComprarCase4_Click(object sender, EventArgs e)
        {
            MensajeAgregado abrirForm = new MensajeAgregado();
            abrirForm.Show();
        }

        private void btnComprarCase5_Click(object sender, EventArgs e)
        {
            MensajeAgregado abrirForm = new MensajeAgregado();
            abrirForm.Show();
        }

        private void btnComprarCase6_Click(object sender, EventArgs e)
        {
            MensajeAgregado abrirForm = new MensajeAgregado();
            abrirForm.Show();
        }
    }
}
