
using TiendaPerrona;

namespace TiendaPerrona
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            
        }
        
        private void ocultasSUbMenu()
        {
            if (subMenuProcesadores.Visible == true)
                subMenuProcesadores.Visible = false;
            if (SubMenuPerifericos.Visible == true)
                SubMenuPerifericos.Visible = false;
        }
        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                ocultasSUbMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
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
            AbrirFormulario<FormDelCase>();
        }

        private void btnProcesadorIntel_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProcesadorIntel>();
            ocultasSUbMenu();
        }

        private void btnProcesadorRyzen_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProcesadorRyzen>();
            ocultasSUbMenu();
        }

        private void btnProductosPerifericos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuPerifericos);
        }

        private void btnPerifericosTeclados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTeclados>();
            ocultasSUbMenu();
        }

        private void btnPerifericosMouse_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormMouse>();
            ocultasSUbMenu();
        }

        private void btnAbrirCarrito_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDelCarrito>();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString(); 
            lblFecha.Text= DateTime.Now.ToLongDateString(); 
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductoTarjetasGraficas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTarjetasGraficas>();
        }

        private void btnProductoPlacasMadres_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormPlacasMadres>();
        }

        private void btnProductoMemoriasRam_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormMemoriasRam>();
        }

        private void btnProductosAlmacenamiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlmacenamiento>();
        }

        private void btnProductoFuentesDePoder_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormFuentesDePoder>();
        }

        private void btnProductoMonitores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormMonitores>();
        }

        private void btnProductoProcesador_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(subMenuProcesadores);
        }
        

     

        private void BarraDeTitulo_Paint(object sender, PaintEventArgs e)
        {

        }


       
    }
}