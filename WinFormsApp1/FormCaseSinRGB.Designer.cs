namespace TiendaPerrona
{
    partial class FormCaseSinRGB
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarCaseSinRGB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCaseSinRGB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "este es el panel de los case sin rgb";
            // 
            // btnCerrarCaseSinRGB
            // 
            this.btnCerrarCaseSinRGB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCaseSinRGB.Image = global::TiendaPerrona.Properties.Resources.x;
            this.btnCerrarCaseSinRGB.Location = new System.Drawing.Point(12, 11);
            this.btnCerrarCaseSinRGB.Name = "btnCerrarCaseSinRGB";
            this.btnCerrarCaseSinRGB.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarCaseSinRGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarCaseSinRGB.TabIndex = 1;
            this.btnCerrarCaseSinRGB.TabStop = false;
            this.btnCerrarCaseSinRGB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormCaseSinRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarCaseSinRGB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaseSinRGB";
            this.Text = "FormCaseSinRGB";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCaseSinRGB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btnCerrarCaseSinRGB;
        private Label label1;
    }
}