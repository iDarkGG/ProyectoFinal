namespace Libreria
{
    partial class PaginaPrincipal : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnProductoPlacasMadres = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProductoProcesador = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductoCase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SubMenuCase = new System.Windows.Forms.Panel();
            this.btnCaseRGB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCaseSinRGB = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SubMenuProcesadores = new System.Windows.Forms.Panel();
            this.btnProcesadorIntel = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnProcesadorAmd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SubMenuPlacasMadres = new System.Windows.Forms.Panel();
            this.btnPlacaMadreAsus = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnPlacaMadreMsi = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SubMenuCase.SuspendLayout();
            this.SubMenuProcesadores.SuspendLayout();
            this.SubMenuPlacasMadres.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraDeTitulo.Controls.Add(this.btnRestaurar);
            this.BarraDeTitulo.Controls.Add(this.btnMinimizar);
            this.BarraDeTitulo.Controls.Add(this.btnMaximizar);
            this.BarraDeTitulo.Controls.Add(this.btnCerrar);
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(1300, 29);
            this.BarraDeTitulo.TabIndex = 0;
            this.BarraDeTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraDeTitulo_Paint);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::TiendaPerrona.Properties.Resources.maximizar_tamano;
            this.btnRestaurar.Location = new System.Drawing.Point(1223, 1);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TiendaPerrona.Properties.Resources.minimizar_signo;
            this.btnMinimizar.Location = new System.Drawing.Point(1192, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::TiendaPerrona.Properties.Resources.maximizar__1_;
            this.btnMaximizar.Location = new System.Drawing.Point(1223, 1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TiendaPerrona.Properties.Resources.x;
            this.btnCerrar.Location = new System.Drawing.Point(1263, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.btnProductoPlacasMadres);
            this.MenuVertical.Controls.Add(this.panel8);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnProductoProcesador);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnProductoCase);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 29);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 621);
            this.MenuVertical.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 33);
            this.panel5.TabIndex = 2;
            // 
            // btnProductoPlacasMadres
            // 
            this.btnProductoPlacasMadres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoPlacasMadres.FlatAppearance.BorderSize = 0;
            this.btnProductoPlacasMadres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoPlacasMadres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoPlacasMadres.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoPlacasMadres.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoPlacasMadres.Location = new System.Drawing.Point(0, 258);
            this.btnProductoPlacasMadres.Name = "btnProductoPlacasMadres";
            this.btnProductoPlacasMadres.Size = new System.Drawing.Size(220, 33);
            this.btnProductoPlacasMadres.TabIndex = 4;
            this.btnProductoPlacasMadres.Text = "PLACAS MADRES";
            this.btnProductoPlacasMadres.UseVisualStyleBackColor = false;
            this.btnProductoPlacasMadres.Click += new System.EventHandler(this.btnProductoPlacasMadres_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(220, 258);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 33);
            this.panel8.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 33);
            this.panel2.TabIndex = 1;
            // 
            // btnProductoProcesador
            // 
            this.btnProductoProcesador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoProcesador.FlatAppearance.BorderSize = 0;
            this.btnProductoProcesador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoProcesador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoProcesador.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoProcesador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoProcesador.Location = new System.Drawing.Point(0, 183);
            this.btnProductoProcesador.Name = "btnProductoProcesador";
            this.btnProductoProcesador.Size = new System.Drawing.Size(220, 33);
            this.btnProductoProcesador.TabIndex = 2;
            this.btnProductoProcesador.Text = "PROCESADOR";
            this.btnProductoProcesador.UseVisualStyleBackColor = false;
            this.btnProductoProcesador.Click += new System.EventHandler(this.btnProductoProcesador_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnProductoCase
            // 
            this.btnProductoCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoCase.FlatAppearance.BorderSize = 0;
            this.btnProductoCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoCase.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoCase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoCase.Location = new System.Drawing.Point(0, 105);
            this.btnProductoCase.Name = "btnProductoCase";
            this.btnProductoCase.Size = new System.Drawing.Size(220, 33);
            this.btnProductoCase.TabIndex = 1;
            this.btnProductoCase.Text = "CASE";
            this.btnProductoCase.UseVisualStyleBackColor = false;
            this.btnProductoCase.Click += new System.EventHandler(this.btnProductoCase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::TiendaPerrona.Properties.Resources.visual_studio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SubMenuCase
            // 
            this.SubMenuCase.Controls.Add(this.panel4);
            this.SubMenuCase.Controls.Add(this.btnCaseSinRGB);
            this.SubMenuCase.Controls.Add(this.panel3);
            this.SubMenuCase.Controls.Add(this.btnCaseRGB);
            this.SubMenuCase.Location = new System.Drawing.Point(0, 105);
            this.SubMenuCase.Name = "SubMenuCase";
            this.SubMenuCase.Size = new System.Drawing.Size(195, 77);
            this.SubMenuCase.TabIndex = 0;
            this.SubMenuCase.Visible = false;
            // 
            // btnCaseRGB
            // 
            this.btnCaseRGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCaseRGB.FlatAppearance.BorderSize = 0;
            this.btnCaseRGB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCaseRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaseRGB.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaseRGB.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCaseRGB.Location = new System.Drawing.Point(0, 3);
            this.btnCaseRGB.Name = "btnCaseRGB";
            this.btnCaseRGB.Size = new System.Drawing.Size(195, 33);
            this.btnCaseRGB.TabIndex = 2;
            this.btnCaseRGB.Text = "CASE RGB";
            this.btnCaseRGB.UseVisualStyleBackColor = false;
            this.btnCaseRGB.Click += new System.EventHandler(this.btnCaseRGB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 33);
            this.panel3.TabIndex = 1;
            // 
            // btnCaseSinRGB
            // 
            this.btnCaseSinRGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCaseSinRGB.FlatAppearance.BorderSize = 0;
            this.btnCaseSinRGB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCaseSinRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaseSinRGB.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaseSinRGB.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCaseSinRGB.Location = new System.Drawing.Point(0, 39);
            this.btnCaseSinRGB.Name = "btnCaseSinRGB";
            this.btnCaseSinRGB.Size = new System.Drawing.Size(195, 33);
            this.btnCaseSinRGB.TabIndex = 3;
            this.btnCaseSinRGB.Text = "CASE SIN RGB";
            this.btnCaseSinRGB.UseVisualStyleBackColor = false;
            this.btnCaseSinRGB.Click += new System.EventHandler(this.btnCaseSinRGB_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 33);
            this.panel4.TabIndex = 2;
            // 
            // SubMenuProcesadores
            // 
            this.SubMenuProcesadores.Controls.Add(this.panel6);
            this.SubMenuProcesadores.Controls.Add(this.btnProcesadorAmd);
            this.SubMenuProcesadores.Controls.Add(this.panel7);
            this.SubMenuProcesadores.Controls.Add(this.btnProcesadorIntel);
            this.SubMenuProcesadores.Location = new System.Drawing.Point(0, 183);
            this.SubMenuProcesadores.Name = "SubMenuProcesadores";
            this.SubMenuProcesadores.Size = new System.Drawing.Size(195, 79);
            this.SubMenuProcesadores.TabIndex = 4;
            this.SubMenuProcesadores.Visible = false;
            // 
            // btnProcesadorIntel
            // 
            this.btnProcesadorIntel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProcesadorIntel.FlatAppearance.BorderSize = 0;
            this.btnProcesadorIntel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProcesadorIntel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesadorIntel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcesadorIntel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcesadorIntel.Location = new System.Drawing.Point(0, 3);
            this.btnProcesadorIntel.Name = "btnProcesadorIntel";
            this.btnProcesadorIntel.Size = new System.Drawing.Size(195, 33);
            this.btnProcesadorIntel.TabIndex = 2;
            this.btnProcesadorIntel.Text = "INTEL";
            this.btnProcesadorIntel.UseVisualStyleBackColor = false;
            this.btnProcesadorIntel.Click += new System.EventHandler(this.btnProcesadorIntel_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 33);
            this.panel7.TabIndex = 1;
            // 
            // btnProcesadorAmd
            // 
            this.btnProcesadorAmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProcesadorAmd.FlatAppearance.BorderSize = 0;
            this.btnProcesadorAmd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProcesadorAmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesadorAmd.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcesadorAmd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcesadorAmd.Location = new System.Drawing.Point(0, 39);
            this.btnProcesadorAmd.Name = "btnProcesadorAmd";
            this.btnProcesadorAmd.Size = new System.Drawing.Size(195, 33);
            this.btnProcesadorAmd.TabIndex = 3;
            this.btnProcesadorAmd.Text = "RYZEN";
            this.btnProcesadorAmd.UseVisualStyleBackColor = false;
            this.btnProcesadorAmd.Click += new System.EventHandler(this.btnProcesadorAmd_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 33);
            this.panel6.TabIndex = 2;
            // 
            // SubMenuPlacasMadres
            // 
            this.SubMenuPlacasMadres.Controls.Add(this.panel10);
            this.SubMenuPlacasMadres.Controls.Add(this.btnPlacaMadreMsi);
            this.SubMenuPlacasMadres.Controls.Add(this.panel11);
            this.SubMenuPlacasMadres.Controls.Add(this.btnPlacaMadreAsus);
            this.SubMenuPlacasMadres.Location = new System.Drawing.Point(0, 261);
            this.SubMenuPlacasMadres.Name = "SubMenuPlacasMadres";
            this.SubMenuPlacasMadres.Size = new System.Drawing.Size(195, 79);
            this.SubMenuPlacasMadres.TabIndex = 5;
            this.SubMenuPlacasMadres.Visible = false;
            // 
            // btnPlacaMadreAsus
            // 
            this.btnPlacaMadreAsus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPlacaMadreAsus.FlatAppearance.BorderSize = 0;
            this.btnPlacaMadreAsus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPlacaMadreAsus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlacaMadreAsus.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlacaMadreAsus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlacaMadreAsus.Location = new System.Drawing.Point(0, 3);
            this.btnPlacaMadreAsus.Name = "btnPlacaMadreAsus";
            this.btnPlacaMadreAsus.Size = new System.Drawing.Size(195, 33);
            this.btnPlacaMadreAsus.TabIndex = 2;
            this.btnPlacaMadreAsus.Text = "ASUS";
            this.btnPlacaMadreAsus.UseVisualStyleBackColor = false;
            this.btnPlacaMadreAsus.Click += new System.EventHandler(this.btnPlacaMadreAsus_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(0, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 33);
            this.panel11.TabIndex = 1;
            // 
            // btnPlacaMadreMsi
            // 
            this.btnPlacaMadreMsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPlacaMadreMsi.FlatAppearance.BorderSize = 0;
            this.btnPlacaMadreMsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPlacaMadreMsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlacaMadreMsi.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlacaMadreMsi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlacaMadreMsi.Location = new System.Drawing.Point(0, 39);
            this.btnPlacaMadreMsi.Name = "btnPlacaMadreMsi";
            this.btnPlacaMadreMsi.Size = new System.Drawing.Size(195, 33);
            this.btnPlacaMadreMsi.TabIndex = 3;
            this.btnPlacaMadreMsi.Text = "MSI";
            this.btnPlacaMadreMsi.UseVisualStyleBackColor = false;
            this.btnPlacaMadreMsi.Click += new System.EventHandler(this.btnPlacaMadreMsi_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(0, 39);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 33);
            this.panel10.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.SubMenuPlacasMadres);
            this.panelContenedor.Controls.Add(this.SubMenuProcesadores);
            this.panelContenedor.Controls.Add(this.SubMenuCase);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 29);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 621);
            this.panelContenedor.TabIndex = 2;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraDeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.BarraDeTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SubMenuCase.ResumeLayout(false);
            this.SubMenuProcesadores.ResumeLayout(false);
            this.SubMenuPlacasMadres.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BarraDeTitulo;
        private PictureBox btnCerrar;
        private Panel MenuVertical;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel8;
        private Panel panel2;
        private Button btnProductoProcesador;
        private Button btnProductoCase;
        private Panel panel5;
        private Button btnProductoPlacasMadres;
        private Panel SubMenuCase;
        private Panel panel4;
        private Button btnCaseSinRGB;
        private Panel panel3;
        private Button btnCaseRGB;
        private Panel SubMenuProcesadores;
        private Panel panel6;
        private Button btnProcesadorAmd;
        private Panel panel7;
        private Button btnProcesadorIntel;
        private Panel SubMenuPlacasMadres;
        private Panel panel10;
        private Button btnPlacaMadreMsi;
        private Panel panel11;
        private Button btnPlacaMadreAsus;
        private Panel panelContenedor;
    }
}