using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace farm
{
    
    public partial class medicamentos : Form
    {
        
        public medicamentos()
        {
            InitializeComponent();

        }
        private void habilitar (bool v)
        {
            btnNuevo.Enabled = v;
            btnGuardar.Enabled = v;
            btnSalir.Enabled = v;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar el TextBox
            //txtNombreProducto.Clear();


    }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
