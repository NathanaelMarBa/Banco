namespace Banco
{
    partial class Saldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saldo));
            this.PB3Menu = new System.Windows.Forms.PictureBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcifra = new System.Windows.Forms.Label();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB3Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // PB3Menu
            // 
            this.PB3Menu.Image = ((System.Drawing.Image)(resources.GetObject("PB3Menu.Image")));
            this.PB3Menu.Location = new System.Drawing.Point(27, 32);
            this.PB3Menu.Name = "PB3Menu";
            this.PB3Menu.Size = new System.Drawing.Size(385, 153);
            this.PB3Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB3Menu.TabIndex = 8;
            this.PB3Menu.TabStop = false;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(12, 77);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(168, 24);
            this.lblnumero.TabIndex = 9;
            this.lblnumero.Text = "Numero de cuenta";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(208, 82);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(191, 20);
            this.txtnumero.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Consulta de saldo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcifra
            // 
            this.lblcifra.AutoSize = true;
            this.lblcifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcifra.Location = new System.Drawing.Point(186, 141);
            this.lblcifra.Name = "lblcifra";
            this.lblcifra.Size = new System.Drawing.Size(0, 24);
            this.lblcifra.TabIndex = 13;
            this.lblcifra.Click += new System.EventHandler(this.lblcifra_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(354, 162);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 15;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(273, 162);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 16;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // txtsaldo
            // 
            this.txtsaldo.Enabled = false;
            this.txtsaldo.Location = new System.Drawing.Point(208, 108);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(191, 20);
            this.txtsaldo.TabIndex = 14;
            this.txtsaldo.Visible = false;
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 197);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.lblcifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.PB3Menu);
            this.Name = "Saldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldo";
            this.Load += new System.EventHandler(this.Saldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB3Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB3Menu;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcifra;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.TextBox txtsaldo;
    }
}