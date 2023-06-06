using Entidades;
using Logica;
using System;
using System.Drawing;
using System.Windows.Forms;
using TallerMecanico;

namespace TALLERM
{
    public partial class PresentaciónBicicleta : Form
    {
        string fecha = DateTime.Now.ToString("ddMMyy-");
        int idSer = 1;
        ImpBicicleta impBici;
        ImpCliente impCliente;
        ImpServicio servicioImp;
        public PresentaciónBicicleta()
        {
            InitializeComponent();
            boxServicio.Text = "Seleccionar";
            boxServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            impBici = new ImpBicicleta(ConfigConnection.conecctionString);
            impCliente = new ImpCliente(ConfigConnection.conecctionString);
            servicioImp = new ImpServicio(ConfigConnection.conecctionString);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            boxServicio.Text = "Seleccionar";
            txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            txtColor.Text = "Ingrese El Color Del Vehiculo";
            txtMecanico.Text = "Nombre Mecánico";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InicializarCajas();
            VerificarCajas();            
        }

        public void Guardado()
        {
            PresentaciónPrincipal ppal = new PresentaciónPrincipal();
            this.Hide();
            ppal.ShowDialog();
            this.Close();
        }

        #region Inserciones
        public void Insertar()
        {
            InsertarCliente();
            InsertarBici();
            InsertarServicio();
        }

        public void InsertarBici()
        {
            Bicicleta bici = new Bicicleta();
            bici.idSer = new Servicio() { IdServicio = fecha + "S" + idSer.ToString() };
            bici.Propietario = txtNom.Text + " " + txtApe.Text;
            bici.Marca = txtMarca.Text;
            bici.Color = txtColor.Text;

            
            int resultado = impBici.Insertar(bici);

            if (resultado > 0)
            {
                MessageBox.Show("Bicicleta Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar La Bicicleta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void InsertarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = txtCedu.Text;
            cliente.Nombre = txtNom.Text;
            cliente.Apellido = txtApe.Text;
            cliente.Telefono = txtTel.Text;

         

            int resultado = impCliente.InsertarClienteBici(cliente);

            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                int resultado = servicioImp.InsertarServicioBici(servicio);
            }

            MessageBox.Show("Servicio Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

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

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
            }
        }

        public void VerificarCajas()
        {
            if (txtMarca.Text == "Ingrese La Marca Del Vehiculo" || txtColor.Text == "Ingrese El Color Del Vehiculo" ||
                dgServicios.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Hay Campos sin Completar, Por Favor Reviselos");
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

        public void LimpiarTabla()
        {
            dgServicios.Rows.Clear();
            PrecioTotal();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            PresentaciónClientes bicis = new PresentaciónClientes();
            this.Hide();
            bicis.ShowDialog();
            this.Close();
        }

        private void PestañaVehiculos_Click(object sender, EventArgs e)
        {
            InicializarCajas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (boxServicio.Text != "Seleccionar" && txtMecanico.Text != "Seleccionar")
            {
                string valor = "";
                if (boxServicio.Text == "Lavado")
                {
                    valor = "15000";
                    txtMecanico.Text = "Junior Rodriguez";
                }
                else
                {
                    if (boxServicio.Text == "Mantenimiento")
                    {
                        valor = "150000";
                        txtMecanico.Text = "Juliana Torres";
                    }
                    else
                    {
                        if (boxServicio.Text == "Pinchazo")
                        {
                            valor = "1300";
                            txtMecanico.Text = "Steven Molina";
                        }
                        else
                        {
                            txtMecanico.Text = "Luis Pinto";
                            valor = "211000";
                        }
                    }
                }

                dgServicios.Rows.Add(boxServicio.Text, txtMecanico.Text, valor);
                PrecioTotal();
                boxServicio.Text = "Seleccionar";
                txtMecanico.Text = "Nombre Mecanico";
            }
            else
            {
                MessageBox.Show("Por Favor Complete Todos Los Campos.");
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
                }
            }
        }

        //Eventos De Verificación de Cajas
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

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
            }
        }

        private void txtServicio_Click(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea salir?", "         T A L L E R      M E C Á N I C O", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.BackColor = Color.LimeGreen;
        }


        private void btnAgregar_MouseLeave_1(object sender, EventArgs e)
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


        private void btnLimpiar_MouseEnter_1(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.LimeGreen;
            btnLimpiar.BackColor = Color.Black;
        }

        private void btnLimpiar_MouseLeave_1(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.BackColor = Color.LimeGreen;
        }

        private void btnVolver_MouseEnter_1(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.LimeGreen;
            btnVolver.BackColor = Color.Black;
        }

        private void btnVolver_MouseLeave_1(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.Black;
            btnVolver.BackColor = Color.LimeGreen;
        }

        private void btnGuardar_MouseEnter_1(object sender, EventArgs e)
        {
            btnGuardar.ForeColor = Color.LimeGreen;
            btnGuardar.BackColor = Color.Black;
        }

        private void btnGuardar_MouseLeave_1(object sender, EventArgs e)
        {
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.BackColor = Color.LimeGreen;
        }

        private void btnSalir_MouseEnter_1(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.LimeGreen;
            btnSalir.BackColor = Color.Black;
        }

        private void btnSalir_MouseLeave_1(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
            btnSalir.BackColor = Color.LimeGreen;
        }

        private void txtMecanico_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void boxServicio_TextChanged(object sender, EventArgs e)
        {
            if (boxServicio.Text != "Seleccionar" && txtMecanico.Text != "Seleccionar")
            {
                string valor = "";
                if (boxServicio.Text == "Lavado")
                {
                    valor = "15000";
                    txtMecanico.Text = "Junior Rodriguez";
                }
                else
                {
                    if (boxServicio.Text == "Mantenimiento")
                    {
                        valor = "150000";
                        txtMecanico.Text = "Juliana Torres";
                    }
                    else
                    {
                        if (boxServicio.Text == "Pinchazo")
                        {
                            valor = "1300";
                            txtMecanico.Text = "Steven Molina";
                        }
                        else
                        {
                            txtMecanico.Text = "Luis Pinto";
                            valor = "211000";
                        }
                    }
                }
            }
        }
    }
}