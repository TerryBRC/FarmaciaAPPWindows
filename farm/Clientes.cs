using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farm.el_porvenir;
namespace farm
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTel.Text;
            string dir = txtDir.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty (dir))
            {
                MessageBox.Show("Campos Requeridos", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
            }
            
        }
    }
}
