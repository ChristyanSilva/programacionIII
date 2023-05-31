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
    public partial class FormLogAdmin : Form
    {
        public FormLogAdmin()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasenia.Clear(); 
        }

        private void btiniciosesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContrasenia.Text== "contraAdmin")
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                this.Hide();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtUsuario.Clear() ;
                txtContrasenia.Clear() ;
            }
        }
    }
}
