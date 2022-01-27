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
    public partial class AsistentesPresentacion : Form
    {

        private bool editarse = false;

        AsistentesEntidades objEntidades = new AsistentesEntidades();
        AsistentesNegocios objNegocios = new AsistentesNegocios();

        public AsistentesPresentacion()
        {
            InitializeComponent();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            AsistentesNegocios objNegocios = new AsistentesNegocios();
            tablaAsistentes.DataSource = objNegocios.BuscandoAsistentes(buscar);
            comboBoxCodigo.DataSource = objNegocios.BuscandoAsistentes(buscar);
            comboBoxCodigo.ValueMember = "Codigo";
            comboBoxCodigo.DisplayMember = "Codigo";
            comboBoxSexo.ValueMember = "Sexo";
            comboBoxSexo.DisplayMember = "Sexo";

            if (tablaAsistentes.RowCount > 1) limpiarCajas();
        }
        public void limpiarCajas()
        {
            txtApellidos.Text = "";
            txtNombre.Text = "";
            comboBoxCodigo.SelectedIndex = -1;
            comboBoxSexo.SelectedIndex = -1;
            txtCedula.Text = "";
            txtF_Nacimiento.Text = "";
            txtDireccion.Text = "";
            txtSueldo.Text = "";
            txtTelefono.Text = "";
        }

        public void accionesTabla()
        {
            tablaAsistentes.Columns[0].Visible = false;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
            editarse = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!editarse)
            {
                try
                {
                    objEntidades.Apellidos = txtApellidos.Text;
                    objEntidades.Nombre = txtNombre.Text;
                    objEntidades.Sexo = comboBoxSexo.Text;
                    objEntidades.Cedula = txtCedula.Text;
                    objEntidades.F_Nacimiento = txtF_Nacimiento.Text;
                    objEntidades.Direccion = txtDireccion.Text;
                    objEntidades.Sueldo = Convert.ToDouble(txtSueldo.Text);
                    objEntidades.Telefono = txtTelefono.Text;

                    objNegocios.InsertandoAsistentes(objEntidades);

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

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscador.Text);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxCodigo.Text != "")
            {
                objEntidades.Codigo = tablaAsistentes.CurrentRow.Cells[1].Value.ToString();
                objNegocios.EliminandoAsistentes(objEntidades);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (editarse)
            {
                try
                {
                    objEntidades.Codigo = Convert.ToString(comboBoxCodigo.Text);
                    objEntidades.Apellidos = Convert.ToString(txtApellidos.Text);
                    objEntidades.Nombre = Convert.ToString(txtNombre.Text);
                    objEntidades.Sexo = Convert.ToString(comboBoxSexo.Text);
                    objEntidades.Cedula = Convert.ToString(txtCedula.Text);
                    objEntidades.F_Nacimiento = Convert.ToString(txtF_Nacimiento.Text);
                    objEntidades.Direccion = Convert.ToString(txtDireccion.Text);
                    objEntidades.Sueldo = Convert.ToDouble(txtSueldo.Text);
                    objEntidades.Telefono = Convert.ToString(txtTelefono.Text);

                    objNegocios.EditandoAsistentes(objEntidades);

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

        private void AsistentesPresentacion_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            comboBoxCodigo.SelectedIndex = -1;

            buttonEliminar.Visible = Properties.Settings.Default.Eliminar;

            if (Properties.Settings.Default.Rol == "Reader")
            {
                buttonEditar.Visible = false;
                buttonNuevo.Visible = false;
                buttonGuardar.Visible = false;
            }
        }

        private void tablaAsistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaAsistentes.SelectedRows.Count >= 0)
            {
                editarse = true;
                comboBoxCodigo.Text = tablaAsistentes.CurrentRow.Cells[1].Value.ToString();
                txtApellidos.Text = tablaAsistentes.CurrentRow.Cells[4].Value.ToString();
                txtNombre.Text = tablaAsistentes.CurrentRow.Cells[3].Value.ToString();
                comboBoxSexo.Text = tablaAsistentes.CurrentRow.Cells[8].Value.ToString(); ;
                txtCedula.Text = tablaAsistentes.CurrentRow.Cells[2].Value.ToString();
                txtF_Nacimiento.Text = tablaAsistentes.CurrentRow.Cells[6].Value.ToString();
                txtDireccion.Text = tablaAsistentes.CurrentRow.Cells[7].Value.ToString(); ;
                txtSueldo.Text = tablaAsistentes.CurrentRow.Cells[9].Value.ToString();
                txtTelefono.Text = tablaAsistentes.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
