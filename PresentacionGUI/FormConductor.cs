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
    public partial class FormConductor : Form
    {
        public FormConductor()
        {
            InitializeComponent();
            LlenarGrid();
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrillaFamiliar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GrillaFamiliar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        ServicioConductor servicioConductor = new ServicioConductor();

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim()== "")
            {
                MessageBox.Show("todos los campos son obligatorios");
            }
            else
            {
                try
                {
                    
                    Conductor co = new Conductor();
                    co.nombre = txtNombre.Text.Trim().ToUpper();
                    co.apellido = txtApellido.Text.Trim().ToUpper();
                    co.fechaNacimiento = dtFecha.Value.Year+"-"+dtFecha.Value.Month+"-"+dtFecha.Value.Day;
                    co.aniosdeExperiencia = Convert.ToInt32(anioexp.Text.Trim());
                    if (servicioConductor.Guardardb(co))
                    {
                        LlenarGrid();
                        LimpiarCampos();
                        MessageBox.Show("El conductor se ha guardado correctamente");
                        //consultado = false; 
                    }
                    else
                    {
                        MessageBox.Show("Ya existe otro conductor con estas caracteristicas");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                    
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        
        public void LlenarGrid()
        {
            DataTable datos = servicioConductor.ListarTodo();
            if (datos == null)
            {
                MessageBox.Show("no se logro acceder a los datos");
            }
            else
            {
                listaConductores.DataSource = datos; 
            }
        }

        
        public void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtFecha.Text = "";
            anioexp.Text = "";
        }
        
        private void FormConductor_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        bool consultado = false; 


        private void consultaconductor_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("por favor ingrese el nombre del conductor a consultar");
            }
            else if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("por favor ingrese el apellido del conductor a consultar");
            }else
            {
                Conductor co = servicioConductor.Consultar(txtNombre.Text.Trim(), txtApellido.Text.Trim());
                if (co==null) {
                    MessageBox.Show("El conductor no se encuentra registrado");
                    LimpiarCampos();
                    consultado = false; 
                }
                else
                {
                    txtNombre.Text = co.nombre;
                    txtApellido.Text = co.apellido;
                    dtFecha.Text = co.fechaNacimiento;
                    anioexp.Text = co.aniosdeExperiencia.ToString();
                    consultado = true; 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (consultado==false)
            {
                MessageBox.Show("Primero debe consultar el conductor");
            }
            else if(txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El/los campos son obligatorios");
            }
            else
            {
                try
                {
                    Conductor co = new Conductor();
                    co.nombre = txtNombre.Text.Trim().ToUpper();
                    co.apellido = txtApellido.Text.Trim().ToUpper();
                    co.fechaNacimiento = dtFecha.Value.Year + "-" + dtFecha.Value.Month + "-" + dtFecha.Value.Day;
                    co.aniosdeExperiencia = Convert.ToInt32(anioexp.Text.Trim());

                    if (ServicioConductor.Actualizar(co))
                    {
                        LlenarGrid();
                        LimpiarCampos();
                        MessageBox.Show("El conductor se ha actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el contacto");
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
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El/los campos son obligatorios");
            }
            else if(DialogResult.Yes== MessageBox.Show(null,"¿Esta seguro que desea eliminar este conductor?", "Confirmacion",MessageBoxButtons.YesNo))
            {
                try
                {

                    if (ServicioConductor.Eliminar(txtNombre.Text.Trim(), txtApellido.Text.Trim()))
                    {
                        LlenarGrid();
                        LimpiarCampos();
                        MessageBox.Show("El conductor se ha eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el contacto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
