using Entidades;
using Logica;
using System;
using System.Drawing;
using System.Windows.Forms;
using TallerMecanico;

namespace TALLERM
{
    public partial class PresentaciónAutos : Form
    {
        string fecha = DateTime.Now.ToString("ddMMyy-");
        int idSer = 1;
        ImpAutomovil impAutomovil;
        ImpCliente clienteImp;
        ImpServicio servicioImp;
        public PresentaciónAutos()
        {
            InitializeComponent();
            boxServicio.Text = "Seleccionar";
            boxServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            impAutomovil = new ImpAutomovil(ConfigConnection.conecctionString);
            clienteImp = new ImpCliente(ConfigConnection.conecctionString);
            servicioImp = new ImpServicio (ConfigConnection.conecctionString);
        }


        #region Eventos Botones
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            boxServicio.Text = "Seleccionar";
            txtMecanico.Text = "Nombre Mecánico";
            txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            txtColor.Text = "Ingrese El Color Del Vehiculo";
            txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InicializarCajas();
            VerificarCajas();
        }

        public void InicializarCajas()
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }

            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            }

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
            }
        }

        public void VerificarCajas()
        {
            if (txtMarca.Text == "Ingrese La Marca Del Vehiculo" || txtColor.Text == "Ingrese El Color Del Vehiculo" ||
                txtPlaca.Text == "Ingrese La Placa Del Vehiculo" || dgServicios.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Hay Campos sin Llenar, Por Favor Reviselos", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Insertar();

                Servicio servicio = new Servicio();
                servicio.IdServicio = idSer.ToString();
                idSer++;

                LimpiarCajas();
                LimpiarTabla();
                Guardado();
            }
        }
        
        #region Inserciones
        public void Insertar()
        {
            InsertarCliente();
            //InsertarAuto();
            //InsertarServicio();
        }

        public void InsertarAuto()
        {
            Auto auto = new Auto();
            auto.idSer = new Servicio() { IdServicio = fecha + "S" + idSer.ToString() };
            auto.Propietario = txtNom.Text + " " + txtApe.Text;
            auto.Marca = txtMarca.Text;
            auto.Color = txtColor.Text;
            auto.Placa = txtPlaca.Text;

           
            int resultado = impAutomovil.Insertar(auto);

            if (resultado > 0)
            {
                MessageBox.Show("Automovil Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Automovil", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void InsertarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = txtCedu.Text;
            cliente.Nombre = txtNom.Text;
            cliente.Apellido = txtApe.Text;
            cliente.Telefono = txtTel.Text;

         

            string resultado = clienteImp.Insertar(cliente);

           MessageBox.Show(resultado);
            
        }

        public void InsertarServicio()
        {
            Servicio servicio = new Servicio();
            Mecanico mecanico = new Mecanico();
            
            int filas = dgServicios.Rows.Count;

            for (int i = 0; i < filas - 1; i++)
            {
                if ((string)dgServicios.Rows[i].Cells["Mecanico"].Value == "Junior Rodriguez")
                {
                    mecanico.idMecanico = "M1";
                    servicio.IdServicio = fecha + "S" + idSer.ToString();
                    servicio.NombreServicio = (string)dgServicios.Rows[i].Cells["descripciónServicios"].Value;
                    servicio.idMecanico = mecanico;
                    servicio.Precio = Convert.ToDouble(dgServicios.Rows[i].Cells["valor"].Value);
                }
                else
                {
                    if ((string)dgServicios.Rows[i].Cells["Mecanico"].Value == "Juliana Torres")
                    {
                        mecanico.idMecanico = "M2";
                        servicio.IdServicio = fecha + "S" + idSer.ToString();
                        servicio.NombreServicio = (string)dgServicios.Rows[i].Cells["descripciónServicios"].Value;
                        servicio.idMecanico = mecanico;
                        servicio.Precio = servicio.Precio = Convert.ToDouble(dgServicios.Rows[i].Cells["valor"].Value);
                    }
                    else
                    {
                        if ((string)dgServicios.Rows[i].Cells["Mecanico"].Value == "Luis Pinto")
                        {
                            mecanico.idMecanico = "M3";
                            servicio.IdServicio = fecha + "S" + idSer.ToString();
                            servicio.NombreServicio = (string)dgServicios.Rows[i].Cells["descripciónServicios"].Value;
                            servicio.idMecanico = mecanico;
                            servicio.Precio = servicio.Precio = Convert.ToDouble(dgServicios.Rows[i].Cells["valor"].Value);
                        }
                        else
                        {
                            if ((string)dgServicios.Rows[i].Cells["Mecanico"].Value == "Nayid Castellar")
                            {
                                mecanico.idMecanico = "M4";
                                servicio.IdServicio = fecha + "S" + idSer.ToString();
                                servicio.NombreServicio = (string)dgServicios.Rows[i].Cells["descripciónServicios"].Value;
                                servicio.idMecanico = mecanico;
                                servicio.Precio = servicio.Precio = Convert.ToDouble(dgServicios.Rows[i].Cells["valor"].Value);
                            }
                            else
                            {
                                if ((string)dgServicios.Rows[i].Cells["Mecanico"].Value == "Steven Molina")
                                {
                                    mecanico.idMecanico = "M5";
                                    servicio.IdServicio = fecha + "S" + idSer.ToString();
                                    servicio.NombreServicio = (string)dgServicios.Rows[i].Cells["descripciónServicios"].Value;
                                    servicio.idMecanico = mecanico;
                                    servicio.Precio = servicio.Precio = Convert.ToDouble(dgServicios.Rows[i].Cells["valor"].Value);
                                }
                            }
                        }
                    }
                }
                int resultado = servicioImp.Insertar(servicio);
            }

            MessageBox.Show("Servicio Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        public void LimpiarTabla()
        {
            dgServicios.Rows.Clear();
            PrecioTotal();
        }

        public void Guardado()
        {
            PresentaciónPrincipal ppal = new PresentaciónPrincipal();
            this.Hide();
            ppal.ShowDialog();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentaciónClientes autos = new PresentaciónClientes();
            this.Hide();
            autos.ShowDialog();
            this.Close();
        }

        private void PestañaVehiculos_Click(object sender, EventArgs e)
        {
            InicializarCajas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarServicio();
        }

        public void AgregarServicio()
        {
            string valor = "";

            if (boxServicio.Text != "Seleccionar")
            {
                if (boxServicio.SelectedIndex == 1) { valor = "530540"; txtMecanico.Text = "Junior Rodriguez"; }
                if (boxServicio.SelectedIndex == 2) { valor = "150000"; txtMecanico.Text = "Juliana Torres"; }
                if (boxServicio.SelectedIndex == 3) { valor = "25000"; txtMecanico.Text = "Luis Pinto"; }
                if (boxServicio.SelectedIndex == 4) { valor = "13000"; txtMecanico.Text = "Nayid Castellar"; }
                if (boxServicio.SelectedIndex == 5) { valor = "152000"; txtMecanico.Text = "Steven Molina"; }
                if (boxServicio.SelectedIndex == 6) { valor = "530540"; txtMecanico.Text = "Junior Rodriguez"; }
                if (boxServicio.SelectedIndex == 7) { valor = "58000"; txtMecanico.Text = "Juliana Torres"; }
                if (boxServicio.SelectedIndex == 8) { valor = "15600"; txtMecanico.Text = "Luis Pinto"; }
                if (boxServicio.SelectedIndex == 9) { valor = "54000"; txtMecanico.Text = "Nayid Castellar"; }
                if (boxServicio.SelectedIndex == 10) { valor = "35000"; txtMecanico.Text = "Steven Molina"; }
                if (boxServicio.SelectedIndex == 11) { valor = "110000"; txtMecanico.Text = "Junior Rodriguez"; }
                if (boxServicio.SelectedIndex == 12) { valor = "20000"; txtMecanico.Text = "Juliana Torres"; }
                if (boxServicio.SelectedIndex == 13) { valor = "18700"; txtMecanico.Text = "Luis Pinto"; }
                if (boxServicio.SelectedIndex == 14) { valor = "38000"; txtMecanico.Text = "Steven Molina"; }
                if (boxServicio.SelectedIndex == 0) { MessageBox.Show("Seleccione Uno de los Servicio.", 
                                                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                dgServicios.Rows.Add(boxServicio.Text, txtMecanico.Text, valor);
                PrecioTotal();
                boxServicio.Text = "Seleccionar";
                txtMecanico.Text = "Nombre Mecánico";
            }
        }

        public void PrecioTotal()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dgServicios.Rows)
            {
                Total += Convert.ToDecimal(row.Cells["valor"].Value);
            }
            Precio.Text = Total.ToString() + "$";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFila();
        }

        public void EliminarFila()
        {
            foreach (DataGridViewRow row in dgServicios.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    dgServicios.Rows.RemoveAt(dgServicios.CurrentRow.Index);
                    PrecioTotal();
                    break;
                }
                else
                {
                    MessageBox.Show("No Hay Fila Seleccionada");
                    break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion


        #region Eventos Cajas de Textos
        private void txtMarca_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Ingrese La Marca Del Vehiculo")
            {
                txtMarca.Text = "";
            }

            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            }

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
            }
        }

        private void txtColor_Click(object sender, EventArgs e)
        {
            if (txtColor.Text == "Ingrese El Color Del Vehiculo")
            {
                txtColor.Text = "";
            }

            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }

            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            }

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
            }
        }

        private void txtPlaca_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "Ingrese La Placa Del Vehiculo")
            {
                txtPlaca.Text = "";
            }

            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
            }
        }

        private void txtServicio_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            }

            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }

            OpcionMecanico();
        }

        private void txtServicio_TextChanged(object sender, EventArgs e)
        {
            OpcionMecanico();
        }

        public void OpcionMecanico()
        {
            if (boxServicio.Text != "Seleccionar")
            {
                if (boxServicio.SelectedIndex == 1) { txtMecanico.Text = "Junior Rodriguez"; }
                if (boxServicio.SelectedIndex == 2) { txtMecanico.Text = "Juliana Torres"; }
                if (boxServicio.SelectedIndex == 3) { txtMecanico.Text = "Luis Pinto"; }
                if (boxServicio.SelectedIndex == 4) { txtMecanico.Text = "Nayid Castellar"; }
                if (boxServicio.SelectedIndex == 5) { txtMecanico.Text = "Steven Molina"; }
                if (boxServicio.SelectedIndex == 6) { txtMecanico.Text = "Junior Rodriguez"; }
                if (boxServicio.SelectedIndex == 7) { txtMecanico.Text = "Juliana Torres"; }
                if (boxServicio.SelectedIndex == 8) { txtMecanico.Text = "Luis Pinto"; }
                if (boxServicio.SelectedIndex == 9) { txtMecanico.Text = "Nayid Castellar"; }
                if (boxServicio.SelectedIndex == 10) { txtMecanico.Text = "Steven Molina"; }
                if (boxServicio.SelectedIndex == 11) { txtMecanico.Text = "Junior Rodriguez"; }
                if (boxServicio.SelectedIndex == 12) { txtMecanico.Text = "Juliana Torres"; }
                if (boxServicio.SelectedIndex == 13) { txtMecanico.Text = "Luis Pinto"; }
                if (boxServicio.SelectedIndex == 14) { txtMecanico.Text = "Steven Molina"; }
            }
        }
        #endregion


        #region Diseño Botones
        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.BackColor = Color.LimeGreen;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.LimeGreen;
            btnAgregar.BackColor = Color.Black;
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.BackColor = Color.LimeGreen;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = Color.LimeGreen;
            btnEliminar.BackColor = Color.Black;
        }

        private void btnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.LimeGreen;
            btnLimpiar.BackColor = Color.Black;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.BackColor = Color.LimeGreen;
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.LimeGreen;
            btnVolver.BackColor = Color.Black;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.Black;
            btnVolver.BackColor = Color.LimeGreen;
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.ForeColor = Color.LimeGreen;
            btnGuardar.BackColor = Color.Black;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.BackColor = Color.LimeGreen;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.LimeGreen;
            btnSalir.BackColor = Color.Black;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
            btnSalir.BackColor = Color.LimeGreen;
        }
        #endregion

    }
}