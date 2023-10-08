namespace Banco
{
    partial class transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transferencia));
            this.PBTransferencia = new System.Windows.Forms.PictureBox();
            this.lbltarjeta = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblalias = new System.Windows.Forms.Label();
            this.txtalias = new System.Windows.Forms.TextBox();
            this.lblmonto = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.lblreferencia = new System.Windows.Forms.Label();
            this.txtreferencia = new System.Windows.Forms.TextBox();
            this.lbltransferir = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btntransferir = new System.Windows.Forms.Button();
            this.lblcuenta = new System.Windows.Forms.Label();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.txtmisaldo = new System.Windows.Forms.TextBox();
            this.txtsusaldo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBTransferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // PBTransferencia
            // 
            this.PBTransferencia.Image = ((System.Drawing.Image)(resources.GetObject("PBTransferencia.Image")));
            this.PBTransferencia.Location = new System.Drawing.Point(46, 83);
            this.PBTransferencia.Name = "PBTransferencia";
            this.PBTransferencia.Size = new System.Drawing.Size(437, 175);
            this.PBTransferencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTransferencia.TabIndex = 8;
            this.PBTransferencia.TabStop = false;
            // 
            // lbltarjeta
            // 
            this.lbltarjeta.AutoSize = true;
            this.lbltarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarjeta.Location = new System.Drawing.Point(28, 71);
            this.lbltarjeta.Name = "lbltarjeta";
            this.lbltarjeta.Size = new System.Drawing.Size(136, 20);
            this.lbltarjeta.TabIndex = 9;
            this.lbltarjeta.Text = "Numero de tarjeta";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(184, 73);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(203, 20);
            this.txtnumero.TabIndex = 10;
            // 
            // lblalias
            // 
            this.lblalias.AutoSize = true;
            this.lblalias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalias.Location = new System.Drawing.Point(28, 143);
            this.lblalias.Name = "lblalias";
            this.lblalias.Size = new System.Drawing.Size(43, 20);
            this.lblalias.TabIndex = 11;
            this.lblalias.Text = "Alias";
            // 
            // txtalias
            // 
            this.txtalias.Location = new System.Drawing.Point(184, 143);
            this.txtalias.Name = "txtalias";
            this.txtalias.Size = new System.Drawing.Size(203, 20);
            this.txtalias.TabIndex = 12;
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.Location = new System.Drawing.Point(29, 176);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(54, 20);
            this.lblmonto.TabIndex = 13;
            this.lblmonto.Text = "Monto";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(184, 178);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(203, 20);
            this.txtmonto.TabIndex = 14;
            // 
            // lblreferencia
            // 
            this.lblreferencia.AutoSize = true;
            this.lblreferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreferencia.Location = new System.Drawing.Point(29, 211);
            this.lblreferencia.Name = "lblreferencia";
            this.lblreferencia.Size = new System.Drawing.Size(87, 20);
            this.lblreferencia.TabIndex = 15;
            this.lblreferencia.Text = "Referencia";
            // 
            // txtreferencia
            // 
            this.txtreferencia.Location = new System.Drawing.Point(184, 213);
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(203, 20);
            this.txtreferencia.TabIndex = 16;
            // 
            // lbltransferir
            // 
            this.lbltransferir.AutoSize = true;
            this.lbltransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransferir.Location = new System.Drawing.Point(165, 9);
            this.lbltransferir.Name = "lbltransferir";
            this.lbltransferir.Size = new System.Drawing.Size(181, 31);
            this.lbltransferir.TabIndex = 17;
            this.lbltransferir.Text = "Transferencia";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(344, 288);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 18;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btntransferir
            // 
            this.btntransferir.Location = new System.Drawing.Point(447, 288);
            this.btntransferir.Name = "btntransferir";
            this.btntransferir.Size = new System.Drawing.Size(75, 23);
            this.btntransferir.TabIndex = 19;
            this.btntransferir.Text = "Transferir";
            this.btntransferir.UseVisualStyleBackColor = true;
            this.btntransferir.Click += new System.EventHandler(this.btntransferir_Click);
            // 
            // lblcuenta
            // 
            this.lblcuenta.AutoSize = true;
            this.lblcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuenta.Location = new System.Drawing.Point(28, 107);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(141, 20);
            this.lblcuenta.TabIndex = 20;
            this.lblcuenta.Text = "Cuenta a transferir";
            this.lblcuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcuenta
            // 
            this.txtcuenta.Location = new System.Drawing.Point(184, 107);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(203, 20);
            this.txtcuenta.TabIndex = 21;
            // 
            // txtmisaldo
            // 
            this.txtmisaldo.Location = new System.Drawing.Point(427, 71);
            this.txtmisaldo.Name = "txtmisaldo";
            this.txtmisaldo.Size = new System.Drawing.Size(38, 20);
            this.txtmisaldo.TabIndex = 22;
            this.txtmisaldo.Visible = false;
            // 
            // txtsusaldo
            // 
            this.txtsusaldo.Location = new System.Drawing.Point(427, 107);
            this.txtsusaldo.Name = "txtsusaldo";
            this.txtsusaldo.Size = new System.Drawing.Size(38, 20);
            this.txtsusaldo.TabIndex = 23;
            this.txtsusaldo.Visible = false;
            // 
            // transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 323);
            this.Controls.Add(this.txtsusaldo);
            this.Controls.Add(this.txtmisaldo);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.lblcuenta);
            this.Controls.Add(this.btntransferir);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.lbltransferir);
            this.Controls.Add(this.txtreferencia);
            this.Controls.Add(this.lblreferencia);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.txtalias);
            this.Controls.Add(this.lblalias);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbltarjeta);
            this.Controls.Add(this.PBTransferencia);
            this.Name = "transferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia";
            ((System.ComponentModel.ISupportInitialize)(this.PBTransferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBTransferencia;
        private System.Windows.Forms.Label lbltarjeta;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblalias;
        private System.Windows.Forms.TextBox txtalias;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label lblreferencia;
        private System.Windows.Forms.TextBox txtreferencia;
        private System.Windows.Forms.Label lbltransferir;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btntransferir;
        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.TextBox txtmisaldo;
        private System.Windows.Forms.TextBox txtsusaldo;
    }
}