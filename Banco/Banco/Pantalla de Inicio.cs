using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Pantalla_de_Inicio : Form
    {

        private int conteo;
        public Pantalla_de_Inicio()
        {
            InitializeComponent();
            conteo = 0;
            
        }

        private void timerinicio_Tick(object sender, EventArgs e)
        {
            conteo++;

            if (conteo == 40)
            {
                this.Hide();
                Inicio_de_sesion cambiar = new Inicio_de_sesion();
                cambiar.Show();
            }
        }

        private void Pantalla_de_Inicio_Load(object sender, EventArgs e)
        {
            timerinicio.Enabled = true;

            if(timerinicio.Enabled == true)
            {
                gif.Image = Image.FromFile(@"D:\Poo\C#\Banco img's\Inicio.gif");
                gif.SizeMode = PictureBoxSizeMode.StretchImage;
            }   
        }

        
    }
}
