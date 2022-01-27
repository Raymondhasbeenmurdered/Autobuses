using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class UsuariosPresentacion : Form
    {
        private string idUsuario;
        private bool editarse = false;

        UsuariosEntidades objEntidades = new UsuariosEntidades();
        UsuariosNegocios objNegocios = new UsuariosNegocios();

        public UsuariosPresentacion()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();

            buttonEliminar.Visible = Properties.Settings.Default.Eliminar;
        }

        public void mostrarBuscarTabla(string buscar)
        {
            UsuariosNegocios objNegocios = new UsuariosNegocios();
            tablaUsuarios.DataSource = objNegocios.ListarUsuarios(buscar);
            comboBoxCodigo.DataSource = objNegocios.ListarUsuarios(buscar);
            comboBoxCodigo.ValueMember = "Codigo";
            comboBoxCodigo.DisplayMember = "Codigo";

            if (tablaUsuarios.RowCount > 1) limpiarCajas();
        }

        public void accionesTabla()
        {
            tablaUsuarios.Columns[0].Visible = false;
            tablaUsuarios.Columns[1].Width = 80;
            tablaUsuarios.ClearSelection();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscador.Text);
        }

        public void limpiarCajas()
        {
            txtNombre.Text = "";
            comboBoxCodigo.SelectedIndex = -1;
            txtContraseña.Text = "";
            comboBoxRol.SelectedIndex = -1;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
            editarse = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (editarse)
            {
                try
                {
                    objEntidades.Codigo = comboBoxCodigo.Text;
                    objEntidades.Nombre = txtNombre.Text;
                    objEntidades.Contraseña = txtContraseña.Text;
                    objEntidades.Rol = comboBoxRol.Text;

                    objNegocios.EditarUsuario(objEntidades);

                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                    editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo editar el registro {txtNombre.Text} {ex}");
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!editarse)
            {
                try
                {
                    objEntidades.Nombre = txtNombre.Text;
                    objEntidades.Contraseña = txtContraseña.Text;
                    objEntidades.Rol = comboBoxRol.Text;

                    objNegocios.InsertarUsuario(objEntidades);

                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
        }

        private void tablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaUsuarios.SelectedRows.Count >= 0)
            {
                idUsuario = tablaUsuarios.CurrentRow.Cells[0].Value.ToString();
                editarse = true;
                comboBoxCodigo.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtContraseña.Text = tablaUsuarios.CurrentRow.Cells[3].Value.ToString();
                comboBoxRol.Text = tablaUsuarios.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxCodigo.Text != "")
            {
                objEntidades.ID_Usuario = Convert.ToInt32(tablaUsuarios.CurrentRow.Cells[0].Value.ToString());
                objNegocios.EliminarUsuario(objEntidades);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
