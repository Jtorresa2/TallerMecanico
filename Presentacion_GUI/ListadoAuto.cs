
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Logica;
using Entidades;
using System.Drawing;
using System.Collections.Generic;

namespace TallerMecanico
{
    public partial class ListadoAuto : Form
    {
        ImpAutomovil impAutomovil;
        Responce responce;
        public ListadoAuto()
        {
            InitializeComponent();
            ConfiguracionInicialGrid();
            responce = new Responce();
            impAutomovil = new ImpAutomovil(ConfigConnection.conecctionString);
            CargarGrilla();
        }
        

        private void ListadoAuto_Load(object sender, EventArgs e)
        {
           
        }

        public void CargarGrilla()
        {
            
            GrillaListadoGeneral.Rows.Clear();
            responce = impAutomovil.Consultar();
            try
            {
                foreach (var item in responce.autosResponce)
                {
                    GrillaListadoGeneral.Rows.Add(item.Propietario, item.idSer.IdServicio, item.Marca, item.Color, item.Placa);
                }
                GrillaListadoGeneral.Refresh();
            }
            catch (Exception e)
            {
                Console.WriteLine(responce.Message);
            }
            
        }
        private void ConfiguracionInicialGrid()
        {
            GrillaListadoGeneral.AllowUserToAddRows = false;

            GrillaListadoGeneral.Columns.Add("columPropietrario", "Nombre");
            GrillaListadoGeneral.Columns.Add("columidServicio", "Servicio");
            GrillaListadoGeneral.Columns.Add("columMarca", "Marca");
            GrillaListadoGeneral.Columns.Add("columColor", "Color");
            GrillaListadoGeneral.Columns.Add("columPlaca", "Placa");



            GrillaListadoGeneral.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            GrillaListadoGeneral.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaListadoGeneral.ColumnHeadersDefaultCellStyle.Font =
                new Font(GrillaListadoGeneral.Font, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrilla();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                ListadoServicios lser = new ListadoServicios();
                lser.txtBus.Text = txtBuscar.Text;
                lser.txtTipo.Text = "1";
                lser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Digite El Servicio A Buscar");
            }
        }
    }
}
