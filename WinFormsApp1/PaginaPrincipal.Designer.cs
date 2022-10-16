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
            this.SubMenuPerifericos = new System.Windows.Forms.Panel();
            this.btnPerifericosMouse = new System.Windows.Forms.Button();
            this.btnPerifericosTeclados = new System.Windows.Forms.Button();
            this.btnProductosPerifericos = new System.Windows.Forms.Button();
            this.btnProductoMonitores = new System.Windows.Forms.Button();
            this.btnProductoFuentesDePoder = new System.Windows.Forms.Button();
            this.btnProductosAlmacenamiento = new System.Windows.Forms.Button();
            this.btnProductoMemoriasRam = new System.Windows.Forms.Button();
            this.btnProductoPlacasMadres = new System.Windows.Forms.Button();
            this.btnProductoTarjetasGraficas = new System.Windows.Forms.Button();
            this.subMenuProcesadores = new System.Windows.Forms.Panel();
            this.btnProcesadorRyzen = new System.Windows.Forms.Button();
            this.btnProcesadorIntel = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnProductoProcesador = new System.Windows.Forms.Button();
            this.btnProductoCase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SubMenuPerifericos.SuspendLayout();
            this.subMenuProcesadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.BarraDeTitulo.Size = new System.Drawing.Size(919, 29);
            this.BarraDeTitulo.TabIndex = 0;
            this.BarraDeTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraDeTitulo_Paint);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::TiendaPerrona.Properties.Resources.maximizar_tamano;
            this.btnRestaurar.Location = new System.Drawing.Point(842, 1);
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
            this.btnMinimizar.Location = new System.Drawing.Point(811, 1);
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
            this.btnMaximizar.Location = new System.Drawing.Point(842, 1);
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
            this.btnCerrar.Location = new System.Drawing.Point(873, 1);
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
            this.MenuVertical.Controls.Add(this.SubMenuPerifericos);
            this.MenuVertical.Controls.Add(this.btnProductosPerifericos);
            this.MenuVertical.Controls.Add(this.btnProductoMonitores);
            this.MenuVertical.Controls.Add(this.btnProductoFuentesDePoder);
            this.MenuVertical.Controls.Add(this.btnProductosAlmacenamiento);
            this.MenuVertical.Controls.Add(this.btnProductoMemoriasRam);
            this.MenuVertical.Controls.Add(this.btnProductoPlacasMadres);
            this.MenuVertical.Controls.Add(this.btnProductoTarjetasGraficas);
            this.MenuVertical.Controls.Add(this.subMenuProcesadores);
            this.MenuVertical.Controls.Add(this.panel8);
            this.MenuVertical.Controls.Add(this.btnProductoProcesador);
            this.MenuVertical.Controls.Add(this.btnProductoCase);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 29);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 554);
            this.MenuVertical.TabIndex = 1;
            // 
            // SubMenuPerifericos
            // 
            this.SubMenuPerifericos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuPerifericos.Controls.Add(this.btnPerifericosMouse);
            this.SubMenuPerifericos.Controls.Add(this.btnPerifericosTeclados);
            this.SubMenuPerifericos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPerifericos.Location = new System.Drawing.Point(0, 438);
            this.SubMenuPerifericos.Name = "SubMenuPerifericos";
            this.SubMenuPerifericos.Size = new System.Drawing.Size(220, 66);
            this.SubMenuPerifericos.TabIndex = 12;
            this.SubMenuPerifericos.Visible = false;
            // 
            // btnPerifericosMouse
            // 
            this.btnPerifericosMouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerifericosMouse.FlatAppearance.BorderSize = 0;
            this.btnPerifericosMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPerifericosMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerifericosMouse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPerifericosMouse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPerifericosMouse.Location = new System.Drawing.Point(0, 30);
            this.btnPerifericosMouse.Name = "btnPerifericosMouse";
            this.btnPerifericosMouse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPerifericosMouse.Size = new System.Drawing.Size(220, 30);
            this.btnPerifericosMouse.TabIndex = 1;
            this.btnPerifericosMouse.Text = "Mouse";
            this.btnPerifericosMouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerifericosMouse.UseVisualStyleBackColor = true;
            this.btnPerifericosMouse.Click += new System.EventHandler(this.btnPerifericosMouse_Click);
            // 
            // btnPerifericosTeclados
            // 
            this.btnPerifericosTeclados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerifericosTeclados.FlatAppearance.BorderSize = 0;
            this.btnPerifericosTeclados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPerifericosTeclados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerifericosTeclados.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPerifericosTeclados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPerifericosTeclados.Location = new System.Drawing.Point(0, 0);
            this.btnPerifericosTeclados.Name = "btnPerifericosTeclados";
            this.btnPerifericosTeclados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPerifericosTeclados.Size = new System.Drawing.Size(220, 30);
            this.btnPerifericosTeclados.TabIndex = 0;
            this.btnPerifericosTeclados.Text = "Teclados";
            this.btnPerifericosTeclados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerifericosTeclados.UseVisualStyleBackColor = true;
            this.btnPerifericosTeclados.Click += new System.EventHandler(this.btnPerifericosTeclados_Click);
            // 
            // btnProductosPerifericos
            // 
            this.btnProductosPerifericos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductosPerifericos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosPerifericos.FlatAppearance.BorderSize = 0;
            this.btnProductosPerifericos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductosPerifericos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosPerifericos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductosPerifericos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductosPerifericos.Location = new System.Drawing.Point(0, 406);
            this.btnProductosPerifericos.Name = "btnProductosPerifericos";
            this.btnProductosPerifericos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductosPerifericos.Size = new System.Drawing.Size(220, 32);
            this.btnProductosPerifericos.TabIndex = 11;
            this.btnProductosPerifericos.Text = "Perifericos";
            this.btnProductosPerifericos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosPerifericos.UseVisualStyleBackColor = false;
            this.btnProductosPerifericos.Click += new System.EventHandler(this.btnProductosPerifericos_Click);
            // 
            // btnProductoMonitores
            // 
            this.btnProductoMonitores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoMonitores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductoMonitores.FlatAppearance.BorderSize = 0;
            this.btnProductoMonitores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoMonitores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoMonitores.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoMonitores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoMonitores.Location = new System.Drawing.Point(0, 374);
            this.btnProductoMonitores.Name = "btnProductoMonitores";
            this.btnProductoMonitores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductoMonitores.Size = new System.Drawing.Size(220, 32);
            this.btnProductoMonitores.TabIndex = 10;
            this.btnProductoMonitores.Text = "Monitores";
            this.btnProductoMonitores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoMonitores.UseVisualStyleBackColor = false;
            // 
            // btnProductoFuentesDePoder
            // 
            this.btnProductoFuentesDePoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoFuentesDePoder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductoFuentesDePoder.FlatAppearance.BorderSize = 0;
            this.btnProductoFuentesDePoder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoFuentesDePoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoFuentesDePoder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoFuentesDePoder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoFuentesDePoder.Location = new System.Drawing.Point(0, 342);
            this.btnProductoFuentesDePoder.Name = "btnProductoFuentesDePoder";
            this.btnProductoFuentesDePoder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductoFuentesDePoder.Size = new System.Drawing.Size(220, 32);
            this.btnProductoFuentesDePoder.TabIndex = 9;
            this.btnProductoFuentesDePoder.Text = "Fuentes de poder";
            this.btnProductoFuentesDePoder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoFuentesDePoder.UseVisualStyleBackColor = false;
            // 
            // btnProductosAlmacenamiento
            // 
            this.btnProductosAlmacenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductosAlmacenamiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosAlmacenamiento.FlatAppearance.BorderSize = 0;
            this.btnProductosAlmacenamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductosAlmacenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosAlmacenamiento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductosAlmacenamiento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductosAlmacenamiento.Location = new System.Drawing.Point(0, 310);
            this.btnProductosAlmacenamiento.Name = "btnProductosAlmacenamiento";
            this.btnProductosAlmacenamiento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductosAlmacenamiento.Size = new System.Drawing.Size(220, 32);
            this.btnProductosAlmacenamiento.TabIndex = 8;
            this.btnProductosAlmacenamiento.Text = "Almacenamiento";
            this.btnProductosAlmacenamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosAlmacenamiento.UseVisualStyleBackColor = false;
            // 
            // btnProductoMemoriasRam
            // 
            this.btnProductoMemoriasRam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoMemoriasRam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductoMemoriasRam.FlatAppearance.BorderSize = 0;
            this.btnProductoMemoriasRam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoMemoriasRam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoMemoriasRam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoMemoriasRam.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoMemoriasRam.Location = new System.Drawing.Point(0, 278);
            this.btnProductoMemoriasRam.Name = "btnProductoMemoriasRam";
            this.btnProductoMemoriasRam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductoMemoriasRam.Size = new System.Drawing.Size(220, 32);
            this.btnProductoMemoriasRam.TabIndex = 7;
            this.btnProductoMemoriasRam.Text = "Memorias Ram";
            this.btnProductoMemoriasRam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoMemoriasRam.UseVisualStyleBackColor = false;
            // 
            // btnProductoPlacasMadres
            // 
            this.btnProductoPlacasMadres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoPlacasMadres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductoPlacasMadres.FlatAppearance.BorderSize = 0;
            this.btnProductoPlacasMadres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoPlacasMadres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoPlacasMadres.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoPlacasMadres.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoPlacasMadres.Location = new System.Drawing.Point(0, 246);
            this.btnProductoPlacasMadres.Name = "btnProductoPlacasMadres";
            this.btnProductoPlacasMadres.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductoPlacasMadres.Size = new System.Drawing.Size(220, 32);
            this.btnProductoPlacasMadres.TabIndex = 6;
            this.btnProductoPlacasMadres.Text = "Placas madres";
            this.btnProductoPlacasMadres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoPlacasMadres.UseVisualStyleBackColor = false;
            // 
            // btnProductoTarjetasGraficas
            // 
            this.btnProductoTarjetasGraficas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoTarjetasGraficas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductoTarjetasGraficas.FlatAppearance.BorderSize = 0;
            this.btnProductoTarjetasGraficas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoTarjetasGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoTarjetasGraficas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoTarjetasGraficas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoTarjetasGraficas.Location = new System.Drawing.Point(0, 216);
            this.btnProductoTarjetasGraficas.Name = "btnProductoTarjetasGraficas";
            this.btnProductoTarjetasGraficas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductoTarjetasGraficas.Size = new System.Drawing.Size(220, 30);
            this.btnProductoTarjetasGraficas.TabIndex = 5;
            this.btnProductoTarjetasGraficas.Text = "Tarjetas Graficas";
            this.btnProductoTarjetasGraficas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoTarjetasGraficas.UseVisualStyleBackColor = false;
            // 
            // subMenuProcesadores
            // 
            this.subMenuProcesadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuProcesadores.Controls.Add(this.btnProcesadorRyzen);
            this.subMenuProcesadores.Controls.Add(this.btnProcesadorIntel);
            this.subMenuProcesadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProcesadores.Location = new System.Drawing.Point(0, 148);
            this.subMenuProcesadores.Name = "subMenuProcesadores";
            this.subMenuProcesadores.Size = new System.Drawing.Size(220, 68);
            this.subMenuProcesadores.TabIndex = 4;
            this.subMenuProcesadores.Visible = false;
            // 
            // btnProcesadorRyzen
            // 
            this.btnProcesadorRyzen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesadorRyzen.FlatAppearance.BorderSize = 0;
            this.btnProcesadorRyzen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProcesadorRyzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesadorRyzen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcesadorRyzen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcesadorRyzen.Location = new System.Drawing.Point(0, 30);
            this.btnProcesadorRyzen.Name = "btnProcesadorRyzen";
            this.btnProcesadorRyzen.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProcesadorRyzen.Size = new System.Drawing.Size(220, 30);
            this.btnProcesadorRyzen.TabIndex = 1;
            this.btnProcesadorRyzen.Text = "Ryzen";
            this.btnProcesadorRyzen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesadorRyzen.UseVisualStyleBackColor = true;
            this.btnProcesadorRyzen.Click += new System.EventHandler(this.btnProcesadorRyzen_Click);
            // 
            // btnProcesadorIntel
            // 
            this.btnProcesadorIntel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesadorIntel.FlatAppearance.BorderSize = 0;
            this.btnProcesadorIntel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProcesadorIntel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesadorIntel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcesadorIntel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcesadorIntel.Location = new System.Drawing.Point(0, 0);
            this.btnProcesadorIntel.Name = "btnProcesadorIntel";
            this.btnProcesadorIntel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProcesadorIntel.Size = new System.Drawing.Size(220, 30);
            this.btnProcesadorIntel.TabIndex = 0;
            this.btnProcesadorIntel.Text = "Intel";
            this.btnProcesadorIntel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesadorIntel.UseVisualStyleBackColor = true;
            this.btnProcesadorIntel.Click += new System.EventHandler(this.btnProcesadorIntel_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(220, 258);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 33);
            this.panel8.TabIndex = 3;
            // 
            // btnProductoProcesador
            // 
            this.btnProductoProcesador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoProcesador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductoProcesador.FlatAppearance.BorderSize = 0;
            this.btnProductoProcesador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoProcesador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoProcesador.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoProcesador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoProcesador.Location = new System.Drawing.Point(0, 118);
            this.btnProductoProcesador.Name = "btnProductoProcesador";
            this.btnProductoProcesador.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductoProcesador.Size = new System.Drawing.Size(220, 30);
            this.btnProductoProcesador.TabIndex = 2;
            this.btnProductoProcesador.Text = "Procesadores";
            this.btnProductoProcesador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoProcesador.UseVisualStyleBackColor = false;
            this.btnProductoProcesador.Click += new System.EventHandler(this.btnProductoProcesador_Click);
            // 
            // btnProductoCase
            // 
            this.btnProductoCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductoCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductoCase.FlatAppearance.BorderSize = 0;
            this.btnProductoCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductoCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoCase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductoCase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoCase.Location = new System.Drawing.Point(0, 86);
            this.btnProductoCase.Name = "btnProductoCase";
            this.btnProductoCase.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductoCase.Size = new System.Drawing.Size(220, 32);
            this.btnProductoCase.TabIndex = 1;
            this.btnProductoCase.Text = "Torre del CPU";
            this.btnProductoCase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoCase.UseVisualStyleBackColor = false;
            this.btnProductoCase.Click += new System.EventHandler(this.btnProductoCase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::TiendaPerrona.Properties.Resources.visual_studio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 29);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(699, 554);
            this.panelContenedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para gente perrona";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIENDA PERRONA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::TiendaPerrona.Properties.Resources.visual_studio;
            this.pictureBox2.Location = new System.Drawing.Point(171, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 583);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraDeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.BarraDeTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.SubMenuPerifericos.ResumeLayout(false);
            this.subMenuProcesadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Panel panel8;
        private Button btnProductoProcesador;
        private Button btnProductoCase;
        private Panel panelContenedor;
        private Panel subMenuProcesadores;
        private Button btnProcesadorRyzen;
        private Button btnProcesadorIntel;
        private Panel SubMenuPerifericos;
        private Button btnPerifericosMouse;
        private Button btnPerifericosTeclados;
        private Button btnProductosPerifericos;
        private Button btnProductoMonitores;
        private Button btnProductoFuentesDePoder;
        private Button btnProductosAlmacenamiento;
        private Button btnProductoMemoriasRam;
        private Button btnProductoPlacasMadres;
        private Button btnProductoTarjetasGraficas;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
    }
}