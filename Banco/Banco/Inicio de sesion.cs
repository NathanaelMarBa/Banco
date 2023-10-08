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
    public partial class Inicio_de_sesion : Form
    {
        public Inicio_de_sesion()
        {
            InitializeComponent();
        }
        
        private void btningresar_Click(object sender, EventArgs e)
        {

            

        MySqlConnection conectar = new MySqlConnection("server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco; ");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;

            codigo.CommandText = ("select *from usuarios where numerotarjeta = '" +txtnumero.Text+ "'and contraseña = '"+txtcontraseña.Text+"' " );

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido a HSBC tu banco de confianza");
                
                Menu cambiar = new Menu();
                cambiar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            conectar.Close();



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
