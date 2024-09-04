using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using farm.el_porvenir;
namespace farm
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void HabilitarControles(bool v)
        {
            btnNuevo.Enabled = !v;
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            txtTel.Enabled = v;
            txtDir.Enabled = v;
            btnEliminar.Enabled = v;
            btnGuardar.Enabled = v;
            btnCancelar.Enabled = v;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTel.Clear();
            txtDir.Clear();
            lblId.Text = "";
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos obligatorios están vacíos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtTel.Text) || string.IsNullOrEmpty(txtDir.Text))
            {
                MessageBox.Show("Campos Requeridos", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear o buscar el cliente en la base de datos
            Cliente c;

            int id;

            if (int.TryParse(lblId.Text, out id) && id > 0)
            {
                // Si el ID es válido y mayor a 0, buscar el cliente existente
                c = unitOfWorkCliente.GetObjectByKey<Cliente>(id);
                if (c == null)
                {
                    MessageBox.Show("Cliente no encontrado", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // Si el ID no es válido o es 0, crear un nuevo cliente
                c = new Cliente(unitOfWorkCliente);
            }

            // Asignar los valores a las propiedades del cliente
            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.Telefono = int.Parse(txtTel.Text);
            c.Direccion = txtDir.Text;

            // Guardar los cambios
            c.Save();
            unitOfWorkCliente.CommitChanges();

            // Limpiar los controles del formulario
            Limpiar();

            // Mostrar un mensaje de éxito
            string mensaje = (id > 0) ? "Actualización Exitosa" : "Guardado Exitoso";
            MessageBox.Show(mensaje, "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar la colección de clientes para reflejar los cambios
            xpCollectionCliente.Reload();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            HabilitarControles(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
            Limpiar();
        }

        private void gridViewClientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (e.RowHandle >= 0)
            {
                HabilitarControles(true);
                // Obtén los valores de las columnas que quieres cargar en los TextBox
                string id = gridViewClientes.GetRowCellValue(e.RowHandle, "Id_cliente").ToString();
                string nombre = gridViewClientes.GetRowCellValue(e.RowHandle, "Nombre").ToString();
                string apellido = gridViewClientes.GetRowCellValue(e.RowHandle, "Apellido").ToString();
                string tel = gridViewClientes.GetRowCellValue(e.RowHandle, "Telefono").ToString();
                string dire = gridViewClientes.GetRowCellValue(e.RowHandle, "Direccion").ToString();
                // Asigna los valores a los TextBox
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                txtTel.Text = tel;
                txtDir.Text = dire;
                lblId.Text = id;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente c = (Cliente)gridViewClientes.GetFocusedRow();
            if (c != null)
            {
                DialogResult r = MessageBox.Show("¿Desea Eliminar Registro?","Información del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    unitOfWorkCliente.Delete(c);
                    unitOfWorkCliente.CommitChanges();
                    xpCollectionCliente.Reload();
                    Limpiar();
                    HabilitarControles(false);
                }
            }
            else
            {
                MessageBox.Show("Seleccionar un Registro", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
