namespace Banco
{
    partial class Retiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retiro));
            this.PBRetiro = new System.Windows.Forms.PictureBox();
            this.lblcuenta = new System.Windows.Forms.Label();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.lblmonto = new System.Windows.Forms.Label();
            this.btnretirar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.lblretiro = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtfondos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBRetiro)).BeginInit();
            this.SuspendLayout();
            // 
            // PBRetiro
            // 
            this.PBRetiro.Image = ((System.Drawing.Image)(resources.GetObject("PBRetiro.Image")));
            this.PBRetiro.Location = new System.Drawing.Point(44, 67);
            this.PBRetiro.Name = "PBRetiro";
            this.PBRetiro.Size = new System.Drawing.Size(364, 123);
            this.PBRetiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBRetiro.TabIndex = 8;
            this.PBRetiro.TabStop = false;
            // 
            // lblcuenta
            // 
            this.lblcuenta.AutoSize = true;
            this.lblcuenta.Location = new System.Drawing.Point(21, 102);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(95, 13);
            this.lblcuenta.TabIndex = 9;
            this.lblcuenta.Text = "Numero de cuenta";
            // 
            // txtcuenta
            // 
            this.txtcuenta.Location = new System.Drawing.Point(136, 95);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(176, 20);
            this.txtcuenta.TabIndex = 10;
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Location = new System.Drawing.Point(21, 137);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(75, 13);
            this.lblmonto.TabIndex = 11;
            this.lblmonto.Text = "Monto a retirar";
            // 
            // btnretirar
            // 
            this.btnretirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirar.Location = new System.Drawing.Point(347, 220);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(84, 31);
            this.btnretirar.TabIndex = 13;
            this.btnretirar.Text = "Retirar";
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(246, 220);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(84, 31);
            this.btnregresar.TabIndex = 14;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // lblretiro
            // 
            this.lblretiro.AutoSize = true;
            this.lblretiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblretiro.Location = new System.Drawing.Point(157, 9);
            this.lblretiro.Name = "lblretiro";
            this.lblretiro.Size = new System.Drawing.Size(155, 24);
            this.lblretiro.TabIndex = 15;
            this.lblretiro.Text = "Retiro de efectivo";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(136, 130);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(176, 20);
            this.txtmonto.TabIndex = 17;
            // 
            // txtfondos
            // 
            this.txtfondos.Location = new System.Drawing.Point(136, 41);
            this.txtfondos.Name = "txtfondos";
            this.txtfondos.Size = new System.Drawing.Size(176, 20);
            this.txtfondos.TabIndex = 18;
            this.txtfondos.Visible = false;
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 261);
            this.Controls.Add(this.txtfondos);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.lblretiro);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnretirar);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.lblcuenta);
            this.Controls.Add(this.PBRetiro);
            this.Name = "Retiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiro";
            this.Load += new System.EventHandler(this.Retiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBRetiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBRetiro;
        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label lblretiro;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtfondos;
    }
}