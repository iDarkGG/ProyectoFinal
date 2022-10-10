
using TiendaPerrona;

namespace Libreria
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }



        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form LosFormularios;
            LosFormularios = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();// esto busca en la coleccion el formulario
            if (LosFormularios == null)
            {
                LosFormularios = new MiForm();
                LosFormularios.TopLevel = false;
                LosFormularios.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(LosFormularios);
                panelContenedor.Tag = LosFormularios;
                LosFormularios.Show();
                LosFormularios.BringToFront();

            }//si el formulario existe sale
            else
            {
                LosFormularios.BringToFront();
            }
        }




        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;  

            btnMaximizar.Visible=false;
            btnRestaurar.Visible=true;
            

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx,ly);
            btnRestaurar.Visible=false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnProductoCase_Click(object sender, EventArgs e)
        {
            SubMenuCase.Visible = true;
           
        }

        private void btnCaseRGB_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCaseConRGB>();
            SubMenuCase.Visible = false;
        }

        private void btnCaseSinRGB_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCaseSinRGB>();
            SubMenuCase.Visible = false;
        }

        private void btnProductoProcesador_Click(object sender, EventArgs e)
        {
            SubMenuProcesadores.Visible = true;
        }
        
        private void btnProcesadorIntel_Click(object sender, EventArgs e)
        {
            SubMenuProcesadores.Visible = false;
        }

        private void btnProcesadorAmd_Click(object sender, EventArgs e)
        {
            SubMenuProcesadores.Visible = false;
        }

        private void btnProductoPlacasMadres_Click(object sender, EventArgs e)
        {
            SubMenuPlacasMadres.Visible = true;
        }

        private void BarraDeTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlacaMadreAsus_Click(object sender, EventArgs e)
        {
            SubMenuPlacasMadres.Visible = false;
        }

        private void btnPlacaMadreMsi_Click(object sender, EventArgs e)
        {
            SubMenuPlacasMadres.Visible = false;
        }
    }
}