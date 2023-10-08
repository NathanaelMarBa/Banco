namespace Banco
{
    partial class Inicio_de_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_de_sesion));
            this.picturelogo = new System.Windows.Forms.PictureBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picturelogo
            // 
            this.picturelogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturelogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picturelogo.ErrorImage")));
            this.picturelogo.Image = ((System.Drawing.Image)(resources.GetObject("picturelogo.Image")));
            this.picturelogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturelogo.InitialImage")));
            this.picturelogo.Location = new System.Drawing.Point(125, 34);
            this.picturelogo.Name = "picturelogo";
            this.picturelogo.Size = new System.Drawing.Size(262, 58);
            this.picturelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturelogo.TabIndex = 0;
            this.picturelogo.TabStop = false;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(57, 153);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(136, 20);
            this.lblnumero.TabIndex = 1;
            this.lblnumero.Text = "Número de tarjeta";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(57, 209);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(92, 20);
            this.lblcontraseña.TabIndex = 2;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(210, 153);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(202, 20);
            this.txtnumero.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(337, 292);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(429, 292);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(210, 208);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(202, 20);
            this.txtcontraseña.TabIndex = 7;
            // 
            // Inicio_de_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 327);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.picturelogo);
            this.Name = "Inicio_de_sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturelogo;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtcontraseña;
    }
}