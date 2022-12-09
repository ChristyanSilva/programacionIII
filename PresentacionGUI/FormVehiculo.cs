using Datos;
using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtmarca.Text.Trim() == "")
            {
                MessageBox.Show("todos los campos son obligatorios");
            }
            else
            {
                try
                {
                    Vehiculo ve = new Vehiculo();
                    ve.marca = txtmarca.Text.Trim().ToUpper();
                    ve.placa = txtplaca.Text.Trim().ToUpper();
                    ve.aniosdeUso = Convert.ToInt32(aniouso.Text.Trim());
                    ve.tipoGasolina= txtplaca.Text.Trim().ToUpper();
                    ve.kilometraje = Convert.ToDouble(txtkilometros.Text.Trim());
                    ve.estadodelVehiculo= txtestado.Text.Trim().ToUpper();
                    ve.idConductorAsignado= Convert.ToInt32(txtidconductor.Text.Trim());

                    if (VehiculoCAD.Guardardb(ve))
                    {
                        LlenarGrid();
                        LimparCampos();
                        MessageBox.Show("El vehiculo se ha guardado correctamente");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe otro vehiculo con estas caracteristicas");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtplaca.Text.Trim() == "")
            {
                MessageBox.Show("por favor ingrese la placa del vehiculo a consultar");
            }
            else
            {
                Vehiculo ve = VehiculoCAD.Consultar(txtmarca.Text.Trim(),txtplaca.Text.Trim());
                if (ve == null)
                {
                    MessageBox.Show("El vehiculo con placa " + txtplaca.Text + " no se encuentra registrado");
                    LimparCampos();
                    consultado = false;
                }
                else
                {
                    txtmarca.Text = ve.marca;
                    txtplaca.Text = ve.placa;
                    aniouso.Text = ve.aniosdeUso.ToString();
                    txtgasolina.Text = ve.tipoGasolina.ToString();
                    txtkilometros.Text= ve.kilometraje.ToString();
                    txtestado.Text= ve.estadodelVehiculo.ToString();
                    txtestado.Text = ve.estadodelVehiculo.ToString();
                    txtidconductor.Text= ve.idConductorAsignado.ToString();
                    consultado = true;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el vehiculo");
            }
            else if (txtplaca.Text.Trim() == "")
            {
                MessageBox.Show("El/los campos son obligatorios");
            }
            else
            {
                try
                {
                    Vehiculo ve = new Vehiculo();
                    ve.marca = txtmarca.Text.Trim().ToUpper();
                    ve.placa = txtplaca.Text.Trim().ToUpper();
                    ve.aniosdeUso = Convert.ToInt32(aniouso.Text.Trim());
                    ve.tipoGasolina = txtplaca.Text.Trim().ToUpper();
                    ve.kilometraje = Convert.ToDouble(txtkilometros.Text.Trim());
                    ve.estadodelVehiculo = txtestado.Text.Trim().ToUpper();
                    ve.idConductorAsignado = Convert.ToInt32(txtidconductor.Text.Trim());

                    if (VehiculoCAD.Actualizar(ve))
                    {
                        LlenarGrid();
                        LimparCampos();
                        MessageBox.Show("El vehiculo se ha actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el vehiculo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtplaca.Text.Trim() == "")
            {
                MessageBox.Show("El campos es obligatorio");
            }
            else if (DialogResult.Yes == MessageBox.Show(null, "¿Esta seguro que desea eliminar este vehiculo?", "Confirmacion", MessageBoxButtons.YesNo))
            {
                try
                {

                    if (VehiculoCAD.Eliminar(txtplaca.Text.Trim()))
                    {
                        LlenarGrid();
                        LimparCampos();
                        MessageBox.Show("El vehiculo se ha eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el vehiculo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public void LlenarGrid()
        {
            DataTable datos = VehiculoCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("no se logro acceder a los datos");
            }
            else
            {
                listaVehiculos.DataSource = datos.DefaultView;
            }
        }

        public void LimparCampos()
        {
            txtmarca.Text = "";
            txtplaca.Text ="";
            aniouso.Text = "";
            txtgasolina.Text = "";
            txtkilometros.Text = "";
            txtestado.Text = "";
            txtestado.Text = "";
            txtidconductor.Text = "";
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        bool consultado = false;
    }
}
