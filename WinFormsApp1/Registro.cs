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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void txtNombreCompleto_Enter(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text == "NOMBRE COMPLETO")
            {
                txtNombreCompleto.Text = "";
                txtNombreCompleto.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreCompleto_Leave(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text == "")
            {
                txtNombreCompleto.Text = "NOMBRE COMPLETO";
                txtNombreCompleto.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "CORREO")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "CORREO";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseñaRegistro_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaRegistro.Text == "CONTRASEÑA")
            {
                txtContraseñaRegistro.Text = "";
                txtContraseñaRegistro.ForeColor = Color.LightGray;
                txtContraseñaRegistro.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseñaRegistro_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaRegistro.Text == "")
            {
                txtContraseñaRegistro.Text = "CONTRASEÑA";
                txtContraseñaRegistro.ForeColor = Color.DimGray;
                txtContraseñaRegistro.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseñaConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaConfirmar.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtContraseñaConfirmar.Text = "";
                txtContraseñaConfirmar.ForeColor = Color.DimGray;
                txtContraseñaConfirmar.UseSystemPasswordChar= true;
            }
        }

        private void txtContraseñaConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaConfirmar.Text == "")
            {
                txtContraseñaConfirmar.Text = "CONFIRMAR CONTRASEÑA";
                txtContraseñaConfirmar.ForeColor = Color.LightGray;
                txtContraseñaConfirmar.UseSystemPasswordChar = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Login uwu = new Login();
            uwu.Show();
            this.Close();
        }
    }
}
