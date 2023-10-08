namespace Banco
{
    partial class Cambiar_contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cambiar_contraseña));
            this.PBContraseña = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.lblcuenta = new System.Windows.Forms.Label();
            this.lblnueva = new System.Windows.Forms.Label();
            this.txtnueva = new System.Windows.Forms.TextBox();
            this.Regresar = new System.Windows.Forms.Button();
            this.txtcambiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // PBContraseña
            // 
            this.PBContraseña.Image = ((System.Drawing.Image)(resources.GetObject("PBContraseña.Image")));
            this.PBContraseña.Location = new System.Drawing.Point(63, 49);
            this.PBContraseña.Name = "PBContraseña";
            this.PBContraseña.Size = new System.Drawing.Size(344, 119);
            this.PBContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBContraseña.TabIndex = 8;
            this.PBContraseña.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(139, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(200, 24);
            this.lbltitulo.TabIndex = 9;
            this.lbltitulo.Text = "Cambio de contraseña";
            // 
            // txtcuenta
            // 
            this.txtcuenta.Location = new System.Drawing.Point(203, 60);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(168, 20);
            this.txtcuenta.TabIndex = 10;
            // 
            // lblcuenta
            // 
            this.lblcuenta.AutoSize = true;
            this.lblcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuenta.Location = new System.Drawing.Point(22, 56);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(70, 24);
            this.lblcuenta.TabIndex = 11;
            this.lblcuenta.Text = "Cuenta";
            // 
            // lblnueva
            // 
            this.lblnueva.AutoSize = true;
            this.lblnueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnueva.Location = new System.Drawing.Point(22, 96);
            this.lblnueva.Name = "lblnueva";
            this.lblnueva.Size = new System.Drawing.Size(163, 24);
            this.lblnueva.TabIndex = 12;
            this.lblnueva.Text = "Contraseña nueva";
            this.lblnueva.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnueva
            // 
            this.txtnueva.Location = new System.Drawing.Point(203, 96);
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.Size = new System.Drawing.Size(168, 20);
            this.txtnueva.TabIndex = 13;
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(296, 174);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(75, 23);
            this.Regresar.TabIndex = 14;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // txtcambiar
            // 
            this.txtcambiar.Location = new System.Drawing.Point(380, 174);
            this.txtcambiar.Name = "txtcambiar";
            this.txtcambiar.Size = new System.Drawing.Size(75, 23);
            this.txtcambiar.TabIndex = 15;
            this.txtcambiar.Text = "Cambiar";
            this.txtcambiar.UseVisualStyleBackColor = true;
            this.txtcambiar.Click += new System.EventHandler(this.txtcambiar_Click);
            // 
            // Cambiar_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 221);
            this.Controls.Add(this.txtcambiar);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.lblnueva);
            this.Controls.Add(this.lblcuenta);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.PBContraseña);
            this.Name = "Cambiar_contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.PBContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBContraseña;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.Label lblnueva;
        private System.Windows.Forms.TextBox txtnueva;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button txtcambiar;
    }
}