using Entidades;
using Logica;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Drawing;
using System.Windows.Forms;
using TallerMecanico;

namespace TALLERM
{
    public partial class PresentaciónClientes : Form
    {
        public PresentaciónClientes()
        {
            InitializeComponent();
            txtTipo.Text = "Seleccionar";
            txtTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Eventos Para Botones
        private void boxLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            txtCedula.Text = "Ingrese Su Cedula";
            txtNombre.Text = "Ingrese Su Nombre";
            txtApellido.Text = "Ingrese Sus Apellidos";
            txtTelefono.Text = "Ingrese Su Telefono";
        }

        private void boxSiguiente_Click(object sender, EventArgs e)
        {
            IniciarlizarCajas();
            VerificarCajas();

        }

        public void VerificarCajas()
        {
            if (txtCedula.Text == "Ingrese Su Cedula" || txtNombre.Text == "Ingrese Su Nombre" ||
            txtApellido.Text == "Ingrese Sus Apellidos" || txtTelefono.Text == "Ingrese Su Telefono" ||
            txtTipo.Text == "Seleccionar")
            {
                MessageBox.Show("Hay Campos sin Completar, Por Favor Reviselos");
            }
            else
            {
                MessageBox.Show("¡DATOS GUARDADOS EXITOSAMENTE! \n" +
                                "Será Dirigido a La Siguiente Sección.");
                

                if (txtTipo.Text == "Bicicleta")
                {
                    PresentaciónBicicleta bicis = new PresentaciónBicicleta();
                    bicis.txtCedu.Text = txtCedula.Text;
                    bicis.txtNom.Text = txtNombre.Text;
                    bicis.txtApe.Text = txtApellido.Text;
                    bicis.txtTel.Text = txtTelefono.Text;
                    this.Hide();
                    bicis.ShowDialog();
                    this.Close();

                }

                if (txtTipo.Text == "Motocicleta")
                {
                    PresentaciónMotos motos = new PresentaciónMotos();
                    motos.txtCedu.Text = txtCedula.Text;
                    motos.txtNom.Text = txtNombre.Text;
                    motos.txtApe.Text = txtApellido.Text;
                    motos.txtTel.Text = txtTelefono.Text;
                    this.Hide();
                    motos.ShowDialog();
                    this.Close();

                }

                if (txtTipo.Text == "Automovil")
                {
                    PresentaciónAutos autos = new PresentaciónAutos();
                    autos.txtCedu.Text = txtCedula.Text;
                    autos.txtNom.Text = txtNombre.Text;
                    autos.txtApe.Text = txtApellido.Text;
                    autos.txtTel.Text = txtTelefono.Text;
                    this.Hide();
                    autos.ShowDialog();
                    this.Close();
                }
            }
        }

        public void IniciarlizarCajas()
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ingrese Su Cedula";
            }

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }
        }

        public void Datos()
        {
            PresentaciónAutos autos = new PresentaciónAutos();
            autos.txtCedu.Text = txtCedula.Text;
            autos.txtNom.Text = txtNombre.Text;
            autos.txtApe.Text = txtApellido.Text;
            autos.txtCedu.Text = txtCedula.Text;
        }

        private void DatosClientes_Click(object sender, EventArgs e)
        {
            IniciarlizarCajas();
        }

        //Eventos Cajas de Textos
        private void txtcedula_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtCedula.Text == "Ingrese Su Cedula")
            {
                txtCedula.Text = "";
            }

            //Verificación de Cajas
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtNombre.Text == "Ingrese Su Nombre")
            {
                txtNombre.Text = "";
            }

            //Verificación del Resto Cajas
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ingrese Su Cedula";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtApellido.Text == "Ingrese Sus Apellidos")
            {
                txtApellido.Text = "";
            }

            //Verificación de Cajas
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ingrese Su Cedula";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtTelefono.Text == "Ingrese Su Telefono")
            {
                txtTelefono.Text = "";
            }

            //Verificación de Cajas
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ingrese Su Cedula";
            }
        }   

        private void boxServicios_MouseEnter(object sender, EventArgs e)
        {
            boxServicios.ForeColor = Color.LimeGreen;
            boxServicios.BackColor = Color.Black;
        }

        private void boxServicios_MouseLeave(object sender, EventArgs e)
        {
            boxServicios.ForeColor = Color.Black;
            boxServicios.BackColor = Color.LimeGreen;
        }

        private void boxLimpiar_MouseEnter(object sender, EventArgs e)
        {
            boxLimpiar.ForeColor = Color.LimeGreen;
            boxLimpiar.BackColor = Color.Black;
        }

        private void boxLimpiar_MouseLeave(object sender, EventArgs e)
        {
            boxLimpiar.ForeColor = Color.Black;
            boxLimpiar.BackColor = Color.LimeGreen;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.LimeGreen;
            btnVolver.BackColor = Color.Black;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.Black;
            btnVolver.BackColor = Color.LimeGreen;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentaciónPrincipal pPal = new PresentaciónPrincipal();
            this.Hide();
            pPal.ShowDialog();
            this.Close();
        }

        private void PresentaciónClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //var respuesta = MessageBox.Show("¿Desea salir?", "         T A L L E R      M E C Á N I C O", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (respuesta != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}

            //var respuesta = MessageBox.Show("Desea salir ....", "Agenda v:0.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (respuesta != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }
    }
    
}
