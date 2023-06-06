
using Logica;
using System;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class ListadoServicios : Form
    {
 
        public ListadoServicios()
        {
            InitializeComponent();
            
        }

        private void ListadoServicios_Load(object sender, EventArgs e)
        {
           // if (txtTipo.Text == "1") { GrillaServicio.DataSource = ImpServicio.Buscar(txtBus.Text); }
           // if (txtTipo.Text == "2") { GrillaServicio.DataSource = ImpServicio.BuscarBici(txtBus.Text); }
           // if (txtTipo.Text == "3") { GrillaServicio.DataSource = ImpServicio.BuscarMoto(txtBus.Text); }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
