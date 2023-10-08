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
    public partial class transferencia : Form
    {
        public transferencia()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu cambiar = new Menu();
            cambiar.Show();
            this.Hide();
        }

        private void btntransferir_Click(object sender, EventArgs e)
        {
            string conexion = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
            MySqlConnection cn = new MySqlConnection(conexion);

            cn.Open();

            string tarjeta;
            tarjeta = txtnumero.Text;
            string insertar = "select saldo from usuarios where numerotarjeta = @tarjeta";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);

            cmd.Parameters.AddWithValue("@tarjeta", tarjeta);
            MySqlDataReader campo = cmd.ExecuteReader();

            if (campo.Read())
            {
                txtmisaldo.Text = campo["saldo"].ToString();
            }
            cn.Close();

            string conectar = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
            MySqlConnection con = new MySqlConnection(conectar);

            con.Open();

            string cuenta;
            cuenta = txtcuenta.Text;
            string subir = "select saldo from usuarios where numerotarjeta = @cuenta";
            MySqlCommand cm = new MySqlCommand(subir, con);

            cm.Parameters.AddWithValue("@cuenta", cuenta);
            MySqlDataReader camp = cm.ExecuteReader();

            if (camp.Read())
            {
                txtsusaldo.Text = camp["saldo"].ToString();
            }
            con.Close();

            string fond, tran;
            fond = txtmisaldo.Text;
            tran = txtmonto.Text;

            if(int.Parse(fond) >= int.Parse(tran))
            {
                string conec = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
                MySqlConnection conn = new MySqlConnection(conec);

                conn.Open();

                string numerocuenta = txtnumero.Text;
                string alias = txtalias.Text;
                string monto = txtmonto.Text;
                string referencia = txtreferencia.Text;
                string push = "insert into transferencias (numerotarjeta, alias, monto, referencia) values (@numero, @alias, @monto, @referencia)";
                MySqlCommand cmm = new MySqlCommand(push, conn);

                cmm.Parameters.AddWithValue("@numero", numerocuenta);
                cmm.Parameters.AddWithValue("@alias", alias);
                cmm.Parameters.AddWithValue("@monto", monto);
                cmm.Parameters.AddWithValue("@referencia", referencia);
                MySqlDataReader cam = cmm.ExecuteReader();

                MessageBox.Show("Transferencia exitosa");
                txtnumero.Clear();
                txtcuenta.Clear();
                txtmonto.Clear();
                txtalias.Clear();
                txtreferencia.Clear();

                conn.Close();

                string conecta = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
                MySqlConnection coonn = new MySqlConnection(conecta);

                coonn.Open();

                string saldo = txtmisaldo.Text;
                string mon = txtmonto.Text;
                int restante, saldoi, retiroi;
                retiroi = int.Parse(monto);
                saldoi = int.Parse(saldo);

                if (saldoi >= retiroi)
                {
                    restante = saldoi - retiroi;
                    string restant = restante + "";

                    string carga = "update usuarios set saldo = @saldo  where numerotarjeta = @numero";
                    MySqlCommand cmmd = new MySqlCommand(carga, coonn);


                    cmmd.Parameters.AddWithValue("@saldo", restant);
                    cmmd.Parameters.AddWithValue("@numero", tarjeta);

                    MySqlDataReader campp = cmmd.ExecuteReader();

                    txtcuenta.Clear();
                    txtmonto.Clear();

                }
                coonn.Close();


                string conex = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
                MySqlConnection cone = new MySqlConnection(conex);

                cone.Open();

                string fondo = txtsusaldo.Text;
                string mont = txtmonto.Text;
                int sobrante, saldor, retiror;
                retiror = int.Parse(monto);
                saldor = int.Parse(fondo);

                if (saldor >= retiror)
                {
                    sobrante = saldor + retiror;
                    string resta = sobrante + "";

                    string sub = "update usuarios set saldo = @saldo  where numerotarjeta = @numero";
                    MySqlCommand cnd = new MySqlCommand(sub, cone);


                    cnd.Parameters.AddWithValue("@saldo", resta);
                    cnd.Parameters.AddWithValue("@numero", cuenta);

                    MySqlDataReader campp = cnd.ExecuteReader();

                    txtcuenta.Clear();
                    txtmonto.Clear();

                }
                cone.Close();
            }
            else
            {
                MessageBox.Show("Fondos insuficientes");
                txtnumero.Clear();
                txtcuenta.Clear();
                txtmonto.Clear();
                txtalias.Clear();
                txtreferencia.Clear();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
