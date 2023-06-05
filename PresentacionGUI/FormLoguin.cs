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
    public partial class FormLoguin : Form
    {
        public FormLoguin()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtadmin.Clear();
            txtContraAdmin.Clear(); 
        }

        private void btiniciosesion_Click(object sender, EventArgs e)
        {
            if (txtadmin.Text == "admin" && txtContraAdmin.Text== "contraAdmin")
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                this.Close();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtadmin.Clear() ;
                txtContraAdmin.Clear() ;
            }
        }
    }
}
