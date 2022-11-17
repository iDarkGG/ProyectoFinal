namespace TiendaPerrona
{
    partial class TarjetaCredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarjetaCredito));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPagarTarjeta = new System.Windows.Forms.Button();
            this.mtxtExpiracion = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCodigoDeSeguridad = new System.Windows.Forms.MaskedTextBox();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.pnlBarra.Controls.Add(this.btnCerrar);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(619, 49);
            this.pnlBarra.TabIndex = 0;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            this.pnlBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseMove);
            this.pnlBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TiendaPerrona.Properties.Resources.image__2_1;
            this.btnCerrar.Location = new System.Drawing.Point(582, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del titular";
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Location = new System.Drawing.Point(58, 119);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(266, 23);
            this.txtNombreTitular.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de la tarjeta";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(58, 189);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(266, 23);
            this.txtNumeroTarjeta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expiracion (mm/yy )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(207, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "C. de seguridad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(58, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datos de la tarjeta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiendaPerrona.Properties.Resources.perro;
            this.pictureBox1.Location = new System.Drawing.Point(502, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TiendaPerrona.Properties.Resources.Recurso_11;
            this.pictureBox2.Location = new System.Drawing.Point(366, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnPagarTarjeta
            // 
            this.btnPagarTarjeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPagarTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPagarTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnPagarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarTarjeta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPagarTarjeta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPagarTarjeta.Location = new System.Drawing.Point(514, 297);
            this.btnPagarTarjeta.Name = "btnPagarTarjeta";
            this.btnPagarTarjeta.Size = new System.Drawing.Size(93, 45);
            this.btnPagarTarjeta.TabIndex = 14;
            this.btnPagarTarjeta.Text = "Pagar";
            this.btnPagarTarjeta.UseVisualStyleBackColor = false;
            this.btnPagarTarjeta.Click += new System.EventHandler(this.btnPagarTarjeta_Click);
            // 
            // mtxtExpiracion
            // 
            this.mtxtExpiracion.Location = new System.Drawing.Point(58, 260);
            this.mtxtExpiracion.Mask = "00/00";
            this.mtxtExpiracion.Name = "mtxtExpiracion";
            this.mtxtExpiracion.Size = new System.Drawing.Size(110, 23);
            this.mtxtExpiracion.TabIndex = 15;
            this.mtxtExpiracion.ValidatingType = typeof(System.DateTime);
            this.mtxtExpiracion.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtExpiracion_MaskInputRejected);
            // 
            // mtxtCodigoDeSeguridad
            // 
            this.mtxtCodigoDeSeguridad.Location = new System.Drawing.Point(207, 260);
            this.mtxtCodigoDeSeguridad.Mask = "999";
            this.mtxtCodigoDeSeguridad.Name = "mtxtCodigoDeSeguridad";
            this.mtxtCodigoDeSeguridad.Size = new System.Drawing.Size(117, 23);
            this.mtxtCodigoDeSeguridad.TabIndex = 16;
            this.mtxtCodigoDeSeguridad.ValidatingType = typeof(int);
            // 
            // TarjetaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(619, 354);
            this.Controls.Add(this.mtxtCodigoDeSeguridad);
            this.Controls.Add(this.mtxtExpiracion);
            this.Controls.Add(this.btnPagarTarjeta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TarjetaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TarjetaCredito";
            this.Load += new System.EventHandler(this.TarjetaCredito_Load);
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlBarra;
        private Label label1;
        private TextBox txtNombreTitular;
        private Label label2;
        private TextBox txtNumeroTarjeta;
        private Label label3;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnPagarTarjeta;
        private MaskedTextBox mtxtExpiracion;
        private MaskedTextBox mtxtCodigoDeSeguridad;
        private PictureBox btnCerrar;
    }
}