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
    public partial class CiudadesPresentacion : Form
    {
        private bool editarse = false;

        CiudadesEntidades objEntidades = new CiudadesEntidades();
        CiudadesNegocios objNegocios = new CiudadesNegocios();

        public CiudadesPresentacion()
        {
            InitializeComponent();
        }

        private void FormCiudades_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();

            buttonEliminar.Visible = Properties.Settings.Default.Eliminar;

            if (Properties.Settings.Default.Rol == "Reader")
            {
                buttonEditar.Visible = false;
                buttonNuevo.Visible = false;
                buttonGuardar.Visible = false;
            }
        }

        public void mostrarBuscarTabla(string buscar)
        {
            CiudadesNegocios objNegocios = new CiudadesNegocios();
            tablaCiudades.DataSource = objNegocios.ListarCiudades(buscar);
            comboBoxCodigo.DataSource = objNegocios.ListarCiudades(buscar);
            comboBoxCodigo.ValueMember = "Codigo";
            comboBoxCodigo.DisplayMember = "Codigo";

            if (tablaCiudades.RowCount > 1) limpiarCajas();
        }

        public void accionesTabla()
        {
            tablaCiudades.Columns[0].Visible = false;
            tablaCiudades.ClearSelection();
        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscador.Text);
        }

        public void limpiarCajas()
        {
            txtNombre.Text = "";
            comboBoxCodigo.SelectedIndex = -1;
            txtRegion.Text = "";
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
                    objEntidades.Region = txtRegion.Text;

                    objNegocios.EditarCiudad(objEntidades);

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
                    objEntidades.Region = txtRegion.Text;

                    objNegocios.InsertarCiudad(objEntidades);

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

        private void tablaCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCiudades.SelectedRows.Count >= 0)
            {
                editarse = true;
                comboBoxCodigo.Text = tablaCiudades.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaCiudades.CurrentRow.Cells[2].Value.ToString();
                txtRegion.Text = tablaCiudades.CurrentRow.Cells[3].Value.ToString();
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
                objEntidades.Codigo = tablaCiudades.CurrentRow.Cells[1].Value.ToString();
                objNegocios.EliminarCiudad(objEntidades);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
