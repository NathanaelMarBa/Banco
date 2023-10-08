using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banco
{
    public partial class Cambiar_contraseña : Form
    {
        public Cambiar_contraseña()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Menu cambiar = new Menu();
            cambiar.Show();
            this.Hide();
        }

        private void txtcambiar_Click(object sender, EventArgs e)
        {
            string conexion = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
            MySqlConnection cn = new MySqlConnection(conexion);

            cn.Open();

            string numero = txtcuenta.Text;
            string contraseña = txtnueva.Text;
            string insertar = "update usuarios set contraseña = @contraseña  where numerotarjeta = @numero";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);

            
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.Parameters.AddWithValue("@numero", numero);

            MySqlDataReader campo = cmd.ExecuteReader();
   
                MessageBox.Show("Contraseña actualizada");
                txtcuenta.Clear();
                txtnueva.Clear();







        }
    }
}
