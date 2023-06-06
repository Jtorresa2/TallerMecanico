using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

using Oracle.ManagedDataAccess.Client;

namespace TallerMecanico
{
    public partial class ListadoBicicleta : Form
    {
        public ListadoBicicleta()
        {
            InitializeComponent();
        }

        private void ListadoBicicleta_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            string conexion = ConfigConnection.conecctionString;

            string consulta = "SELECT c.Cedula, c.Nombre, c.Apellido, c.Telefono, a.idServicio, a.Marca, a.Color FROM clientebicicleta c " +
                "JOIN bicicleta a WHERE c.idCliente = a.idCliente";
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);
            GrillaListadoGeneral.DataSource = dt;
        }

        private void volverToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PresentaciónPrincipal pPal = new PresentaciónPrincipal();
            this.Hide();
            pPal.ShowDialog();
            this.Close();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                ListadoServicios lser = new ListadoServicios();
                lser.txtTipo.Text = "2";
                lser.txtBus.Text = txtBuscar.Text;
                lser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Digite El Servicio A Buscar");
            }
        }
    }
}
