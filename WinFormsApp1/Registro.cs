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
        RegisterBase rb = new RegisterBase();
        InicioDeSesion iN = new InicioDeSesion();
        DataBase dB = new DataBase();
        Login uwu = new Login();
        
        public Registro()
        {
            
            InitializeComponent();
        }

        private void txtNombreCompleto_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "NOMBRE DE USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreCompleto_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "NOMBRE DE USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
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
            string Email = txtCorreo.Text, Contraseña= txtContraseñaRegistro.Text, ConfContraseña= txtContraseñaConfirmar.Text, User= txtUsuario.Text;
            //Null Checker
            if(txtUsuario.Text == "NOMBRE DE USUARIO" | txtCorreo.Text == "CORREO" | txtContraseñaRegistro.Text == "CONTRASEÑA" | txtContraseñaConfirmar.Text == "CONFIRMAR CONTRASEÑA")
            {
               DialogResult r = MessageBox.Show("UNO O MAS CAMPOS ESTAN VACIOS POR FAVOR REVISA Y RELLENA LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                if(!rb.UserNameChecker(User) & rb.PasswordChecker(Contraseña, ConfContraseña) & !rb.EmailChecker(Email) & rb.EmailVerifier(Email))
                {
                    DialogResult r = MessageBox.Show("TE REGISTRASTE CORRECTAMENTE, POR FAVOR CONTINUA AL LOGIN", "EXITO", MessageBoxButtons.OK);

                    if(r == DialogResult.OK)
                    {
                        dB.Users.Add(new TiendaPerrona.User(User, Email, Contraseña));
                        uwu.Show();
                        this.Close();
                    }
                    else
                    {
                        DialogResult g = MessageBox.Show("LOS DATOS INGRESADOS SON INCORRECTOS", "ERROR", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    DialogResult h = MessageBox.Show("LOS DATOS INGRESADOS SON INCORRECTOS", "ERROR", MessageBoxButtons.OK);
                }
                
            }
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
