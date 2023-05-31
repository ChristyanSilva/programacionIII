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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void registrarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {          
        }       

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        void Cerrar()
        {
            this.Close();
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void registrarConductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConductor formRegistroConductor = new FormConductor();
            formRegistroConductor.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void consultarConductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVehiculo formConsultaVehiculo = new FormVehiculo();
            formConsultaVehiculo.Show();
        }

        private void consultarConductoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("Desea Salir?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
