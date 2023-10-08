namespace Banco
{
    partial class Pantalla_de_Inicio
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
            this.components = new System.ComponentModel.Container();
            this.gif = new System.Windows.Forms.PictureBox();
            this.timerinicio = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // gif
            // 
            this.gif.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gif.Location = new System.Drawing.Point(0, -1);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(545, 420);
            this.gif.TabIndex = 0;
            this.gif.TabStop = false;
            // 
            // timerinicio
            // 
            this.timerinicio.Tick += new System.EventHandler(this.timerinicio_Tick);
            // 
            // Pantalla_de_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 416);
            this.Controls.Add(this.gif);
            this.Name = "Pantalla_de_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSBC";
            this.Load += new System.EventHandler(this.Pantalla_de_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.Timer timerinicio;
    }
}