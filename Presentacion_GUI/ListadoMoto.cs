using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class ListadoMoto : Form
    {
        public ListadoMoto()
        {
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentaciónPrincipal pPal = new PresentaciónPrincipal();
            this.Hide();
            pPal.ShowDialog();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ListadoMoto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            string conexion = ConfigConnection.conecctionString;

            string consulta = "SELECT c.Cedula, c.Nombre, c.Apellido, c.Telefono, a.idServicio, a.Marca, a.Color, a.Placa FROM clientemoto c " +
                "JOIN moto a WHERE c.idCliente = a.idCliente";
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);
            GrillaListadoGeneral.DataSource = dt;
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
                lser.txtBus.Text = txtBuscar.Text;
                lser.txtTipo.Text = "3";
                lser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Digite El Servicio A Buscar");
            }
        }
    }
}
