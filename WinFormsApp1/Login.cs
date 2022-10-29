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
        public Login()
        {
            InitializeComponent();
        }
        PaginaPrincipal uwu = new PaginaPrincipal();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
        uwu.Show();
        }
    }
}
