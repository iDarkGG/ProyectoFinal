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
    public partial class Login : Form
    {
        private FormDelCarrito fmc = new FormDelCarrito();
        private InicioDeSesion iN = new InicioDeSesion();
        private DataBase dB = new DataBase();

        public Login()
        {
            InitializeComponent();
        }
        PaginaPrincipal uwu = new PaginaPrincipal();

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            label1.Focus();

            dB.starter();
            try
            {
                dB.generarArchivo();
                MessageBox.Show(dB.obtenerPath(), "desde el login (llamando al metodo obtener path)");
            }
            catch (Exception ex) { iN.cargarArchivo(); }

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            string Input = txtUsuario.Text, Contraseña = txtContraseña.Text;
            
            if (iN.PasswordAnUserQuerying(Input, Contraseña))
            {

                DialogResult r = MessageBox.Show("INGRESASTE CORRECTAMENTE", "EXITO", MessageBoxButtons.OK);
                uwu.Show();
                this.Visible = false;
                fmc.User = dB.UserShower(Input);
            }
            else
            {
                DialogResult r = MessageBox.Show("LOS DATOS INGRESADOS NO COICIDEN CON NINGUNOS EN NUESTRA BASE DE DATOS, POR FAVOR REINTENTE.", "ERROR", MessageBoxButtons.OK);

            }

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void btnRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro uwu = new Registro();
            uwu.Show();
            this.Hide();




        }
    }
}
