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
        private Regex rg = new Regex(@"\s+");
        private string nombre;
        private string numeroTarjeta;
        private int codigo;
        private DateTime fechaExp;
        private TimeSpan timeSpan;
        private int xPosition, yPosition;
        private bool isPressed;

        public TarjetaCredito()
        {
            InitializeComponent();
        }

        private void TarjetaCredito_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label2;
            label2.Focus();
        }

        private void btnPagarTarjeta_Click(object sender, EventArgs e)
        {
            if (!verifyFields())
            {
                MessageBox.Show("¡TODOS LOS CAMPOS DEBEN ESTAR LLENOS PARA CONTINUAR CON LA COMPRA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            if (!validarTarjeta(txtNumeroTarjeta.Text))
            {
                MessageBox.Show("EL NUMERO INGRESADO NO CORRESPONDE A UNA TARJETA VALIDA. POR FAVOR " +
                   "INGRESE UNA TARJETA  VALIDA", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Error);
                clearAll();
                return;
            }

            obtenerDatos();
        }

        private void mtxtExpiracion_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //borrar
        }

        private void obtenerDatos()
        {
            if (!validarFecha())
            {
                MessageBox.Show("LA TARJETA INGRESADA SE ENCUENTRA VENCIDA. POR FAVOR " +
                    "INGRESE UNA TARJETA  VALIDA", "Mensaje", MessageBoxButtons.OK);
                clearAll();
                return;
            }
               
            numeroTarjeta = txtNumeroTarjeta.Text;
            codigo = Int32.Parse(mtxtCodigoDeSeguridad.Text);
            nombre = txtNombreTitular.Text;
            MessageBox.Show("¡El Cobro se ha Realizado Correctamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            clearAll();
        }

        private bool validarFecha()
        {
            try
            {
                Regex r = new Regex(@"(?<mes>\d{2})/(?<año>\d{2})");
                MatchCollection matches = r.Matches(mtxtExpiracion.Text);

                foreach (Match item in matches)
                {
                    GroupCollection g = item.Groups;

                    fechaExp = DateTime.Parse($"{DateTime.Now.Day}/{g["mes"].Value}/{g["año"].Value}");

                    timeSpan = fechaExp - DateTime.Now.Date;
                }

                return timeSpan.CompareTo(TimeSpan.Zero) > 0;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        private void clearAll()
        {
            mtxtExpiracion.Clear();
            mtxtCodigoDeSeguridad.Clear();
            txtNombreTitular.Clear();
            txtNumeroTarjeta.Clear();
        }

        public bool validarTarjeta(String cardNo)
        {
            cardNo = cardNo.Replace("-","");
            cardNo = eliminarEspacios(cardNo);

            int nDigits = cardNo.Length;

            int nSum = 0;
            bool isSecond = false;
            for (int i = nDigits - 1; i >= 0; i--)
            {

                int d = cardNo[i] - '0';

                if (isSecond == true)
                    d = d * 2;

                nSum += d / 10;
                nSum += d % 10;

                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }

        public string eliminarEspacios(string s)
        {
            return Regex.Replace(s,@"\s+",String.Empty);
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            xPosition = e.X;
            yPosition = e.Y;
        }

        private void pnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;
                this.Location = new Point(x - xPosition, y - yPosition);
            }
        }

        private void pnlBarra_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool verifyFields()
        {
            if(string.IsNullOrWhiteSpace(mtxtCodigoDeSeguridad.Text) || string.IsNullOrWhiteSpace(mtxtExpiracion.Text) 
             || string.IsNullOrWhiteSpace(txtNombreTitular.Text) || string.IsNullOrWhiteSpace(txtNumeroTarjeta.Text))
                return false;

            return true;
        }
    }
}
