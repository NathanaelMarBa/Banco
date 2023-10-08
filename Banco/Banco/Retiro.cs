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
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu cambiar = new Menu();
            cambiar.Show();
            this.Hide();
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            string conexion = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
            MySqlConnection cn = new MySqlConnection(conexion);

            cn.Open();

            string numero = txtcuenta.Text;
            string insertar = "select saldo from usuarios where numerotarjeta = @tarjeta";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);

            cmd.Parameters.AddWithValue("@tarjeta", numero);
            MySqlDataReader campo = cmd.ExecuteReader();

            if (campo.Read())
            {
                txtfondos.Text = campo["saldo"].ToString();
            }
            cn.Close();

            string conec = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
            MySqlConnection con = new MySqlConnection(conec);

            con.Open();

            string saldo = txtfondos.Text;
            string monto = txtmonto.Text;
            int restante, saldoi, retiroi;
            retiroi = int.Parse(monto);
            saldoi = int.Parse(saldo);

            if (saldoi >= retiroi)
            {
                restante = saldoi - retiroi;
                string restant = restante + "";

                string carga = "update usuarios set saldo = @saldo  where numerotarjeta = @numero";
                MySqlCommand cm = new MySqlCommand(carga, con);


                cm.Parameters.AddWithValue("@saldo", restant);
                cm.Parameters.AddWithValue("@numero", numero);

                MySqlDataReader camp = cm.ExecuteReader();

                MessageBox.Show("Retiro completado, tome su dinero");

                txtcuenta.Clear();
                txtmonto.Clear();

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }

        }

        private void Retiro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
