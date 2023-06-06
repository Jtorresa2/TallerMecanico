using System;
using System.Windows.Forms;
using TALLERM;

namespace TallerMecanico
{
    public partial class PresentaciónPrincipal : Form
    {
        public PresentaciónPrincipal()
        {
            InitializeComponent();
        }

        private void regisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentaciónClientes cliente = new PresentaciónClientes();
            this.Hide();
            cliente.ShowDialog();
            this.Close();
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void auToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoAuto autos = new ListadoAuto();
            this.Hide();
            autos.ShowDialog();
            this.Close();
        }

        private void motoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoMoto motos = new ListadoMoto();
            this.Hide();
            motos.ShowDialog();
            this.Close();
        }

        private void bicicletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoBicicleta bici = new ListadoBicicleta();
            this.Hide();
            bici.ShowDialog();
            this.Close();
        }
    }
}
