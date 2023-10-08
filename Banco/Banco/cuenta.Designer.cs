namespace Banco
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PBMenu = new System.Windows.Forms.PictureBox();
            this.lblmenu = new System.Windows.Forms.Label();
            this.btnsaldo = new System.Windows.Forms.Button();
            this.btnretiro = new System.Windows.Forms.Button();
            this.btntransferencia = new System.Windows.Forms.Button();
            this.btncontraseña = new System.Windows.Forms.Button();
            this.PB2Menu = new System.Windows.Forms.PictureBox();
            this.PB3Menu = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // PBMenu
            // 
            this.PBMenu.Image = ((System.Drawing.Image)(resources.GetObject("PBMenu.Image")));
            this.PBMenu.Location = new System.Drawing.Point(580, -3);
            this.PBMenu.Name = "PBMenu";
            this.PBMenu.Size = new System.Drawing.Size(160, 136);
            this.PBMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMenu.TabIndex = 0;
            this.PBMenu.TabStop = false;
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.Location = new System.Drawing.Point(160, 23);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(367, 42);
            this.lblmenu.TabIndex = 1;
            this.lblmenu.Text = "¿Qué deseas hacer?";
            // 
            // btnsaldo
            // 
            this.btnsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaldo.Location = new System.Drawing.Point(153, 260);
            this.btnsaldo.Name = "btnsaldo";
            this.btnsaldo.Size = new System.Drawing.Size(170, 63);
            this.btnsaldo.TabIndex = 2;
            this.btnsaldo.Text = "Verficar Saldo";
            this.btnsaldo.UseVisualStyleBackColor = true;
            this.btnsaldo.Click += new System.EventHandler(this.btnsaldo_Click);
            // 
            // btnretiro
            // 
            this.btnretiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretiro.Location = new System.Drawing.Point(394, 122);
            this.btnretiro.Name = "btnretiro";
            this.btnretiro.Size = new System.Drawing.Size(196, 63);
            this.btnretiro.TabIndex = 3;
            this.btnretiro.Text = "Retiro en efectivo";
            this.btnretiro.UseVisualStyleBackColor = true;
            this.btnretiro.Click += new System.EventHandler(this.btnretiro_Click);
            // 
            // btntransferencia
            // 
            this.btntransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransferencia.Location = new System.Drawing.Point(153, 122);
            this.btntransferencia.Name = "btntransferencia";
            this.btntransferencia.Size = new System.Drawing.Size(170, 63);
            this.btntransferencia.TabIndex = 4;
            this.btntransferencia.Text = "Transferencia";
            this.btntransferencia.UseVisualStyleBackColor = true;
            this.btntransferencia.Click += new System.EventHandler(this.btntransferencia_Click);
            // 
            // btncontraseña
            // 
            this.btncontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontraseña.Location = new System.Drawing.Point(394, 260);
            this.btncontraseña.Name = "btncontraseña";
            this.btncontraseña.Size = new System.Drawing.Size(196, 63);
            this.btncontraseña.TabIndex = 5;
            this.btncontraseña.Text = "Cambiar contraseña";
            this.btncontraseña.UseVisualStyleBackColor = true;
            this.btncontraseña.Click += new System.EventHandler(this.btncontraseña_Click);
            // 
            // PB2Menu
            // 
            this.PB2Menu.Image = ((System.Drawing.Image)(resources.GetObject("PB2Menu.Image")));
            this.PB2Menu.Location = new System.Drawing.Point(-3, 260);
            this.PB2Menu.Name = "PB2Menu";
            this.PB2Menu.Size = new System.Drawing.Size(150, 130);
            this.PB2Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB2Menu.TabIndex = 6;
            this.PB2Menu.TabStop = false;
            // 
            // PB3Menu
            // 
            this.PB3Menu.Image = ((System.Drawing.Image)(resources.GetObject("PB3Menu.Image")));
            this.PB3Menu.Location = new System.Drawing.Point(153, 148);
            this.PB3Menu.Name = "PB3Menu";
            this.PB3Menu.Size = new System.Drawing.Size(437, 175);
            this.PB3Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB3Menu.TabIndex = 7;
            this.PB3Menu.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(631, 342);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(68, 35);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 389);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnsaldo);
            this.Controls.Add(this.PB2Menu);
            this.Controls.Add(this.btncontraseña);
            this.Controls.Add(this.btntransferencia);
            this.Controls.Add(this.btnretiro);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.PBMenu);
            this.Controls.Add(this.PB3Menu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBMenu;
        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.Button btnsaldo;
        private System.Windows.Forms.Button btnretiro;
        private System.Windows.Forms.Button btntransferencia;
        private System.Windows.Forms.Button btncontraseña;
        private System.Windows.Forms.PictureBox PB2Menu;
        private System.Windows.Forms.PictureBox PB3Menu;
        private System.Windows.Forms.Button btnsalir;
    }
}