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
    public partial class Saldo : Form
    {
        public Saldo()
        {
            InitializeComponent();
        }

        private void Saldo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblcifra_Click(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu cambiar = new Menu();
            cambiar.Show();
            this.Hide();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {

            string conexion = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
            MySqlConnection cn = new MySqlConnection(conexion);

            cn.Open();

            string numero = txtnumero.Text;
            string insertar = "select saldo from usuarios where numerotarjeta = @tarjeta";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);

            cmd.Parameters.AddWithValue("@tarjeta", numero);
            MySqlDataReader campo = cmd.ExecuteReader();

            if (campo.Read())
            {
                txtsaldo.Text = campo["saldo"].ToString();
                MessageBox.Show("Su saldo es de: " + txtsaldo.Text + " pesos");
                txtnumero.Clear();
            }
            else
            {
                MessageBox.Show("Saldo no encontrado");
            }

        }
    }
}
