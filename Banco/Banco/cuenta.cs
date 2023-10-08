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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnsaldo_Click(object sender, EventArgs e)
        {
            Saldo cambiar = new Saldo();
            cambiar.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btntransferencia_Click(object sender, EventArgs e)
        {
            transferencia cambiar = new transferencia();
            cambiar.Show();
            this.Hide();
        }

        private void btnretiro_Click(object sender, EventArgs e)
        {
            Retiro cambiar = new Retiro();
            cambiar.Show();
            this.Hide();
        }

        private void btncontraseña_Click(object sender, EventArgs e)
        {
            Cambiar_contraseña cambiar = new Cambiar_contraseña();
            cambiar.Show();
            this.Hide();
        }
    }
}
