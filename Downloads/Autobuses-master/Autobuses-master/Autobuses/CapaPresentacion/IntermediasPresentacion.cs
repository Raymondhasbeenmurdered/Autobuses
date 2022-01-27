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
    public partial class IntermediasPresentacion : Form
    {
        //private string CodIntermedias;
        private bool editarse = false;

        IntermediasEntidades objEntidades = new IntermediasEntidades();
        IntermediasNegocios objNegocios = new IntermediasNegocios();

        public IntermediasPresentacion()
        {
            InitializeComponent();
        }

        private void IntermediasPresentacion_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            tablaIntermedias.Columns[0].Visible = false;
            //accionesTabla();

            btnEliminar.Visible = Properties.Settings.Default.Eliminar;

            if (Properties.Settings.Default.Rol == "Reader")
            {
                btnEditar.Visible = false;
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
            }
        }

        public void mostrarBuscarTabla(string buscar)
        {
            IntermediasNegocios objNegocios = new IntermediasNegocios();
            tablaIntermedias.DataSource = objNegocios.ListandoIntermedias(buscar);

            cmbCodigo.DataSource = objNegocios.ListandoIntermedias(buscar);
            cmbCodigo.ValueMember = "Codigo";
            cmbCodigo.DisplayMember = "Codigo";

            if (tablaIntermedias.RowCount > 1) LimpiarCajas();
        }

       /* public void accionesTabla()
        {
            tablaIntermedias.Columns[0].Visible = false;
            tablaIntermedias.Columns[1].Width = 30;
            tablaIntermedias.Columns[2].Width = 60;
            tablaIntermedias.Columns[3].Width = 90;
            tablaIntermedias.Columns[4].Width = 30;
        }*/

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            editarse = false;
        }

        public void LimpiarCajas()
        {
            cmbCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTipo.Text = "";
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editarse)
            {
                try
                {
                    objEntidades.Codigo = Convert.ToString(cmbCodigo.Text);
                    objEntidades.Nombre = txtNombre.Text;
                    objEntidades.Direccion = txtDireccion.Text;
                    objEntidades.Tipo = txtTipo.Text;
                    Console.WriteLine(txtDireccion.Text);

                    objNegocios.EditandoIntermedias(objEntidades);

                    MessageBox.Show("Se editó el registro");
                    mostrarBuscarTabla("");
                    LimpiarCajas();
                    editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo editar el registro {txtNombre.Text} {ex}");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!editarse)
            {
                try
                {
                    objEntidades.Nombre = txtNombre.Text;
                    objEntidades.Direccion = txtDireccion.Text;
                    objEntidades.Tipo = txtTipo.Text;

                    objNegocios.InsertandoIntermedias(objEntidades);

                    MessageBox.Show("Se guardó el registro");
                    mostrarBuscarTabla("");
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.Text != "")
            {
                objEntidades.Codigo = Convert.ToString(tablaIntermedias.CurrentRow.Cells[1].Value.ToString());
                objNegocios.EliminandoIntermedias(objEntidades);

                MessageBox.Show("Se eliminó correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void tablaIntermedias_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaIntermedias.SelectedRows.Count > 0)
            {
                editarse = true;
                cmbCodigo.Text = tablaIntermedias.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaIntermedias.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = tablaIntermedias.CurrentRow.Cells[3].Value.ToString();
                txtTipo.Text = tablaIntermedias.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        /*public void ListarCodigos()
        {
            cmbCodigo.DataSource = objNegocios.ListandoIntermedias("");
            cmbCodigo.ValueMember = "Id";
            cmbCodigo.DisplayMember = "CodigoParadaINTER";
        }

        public void ListarIds()
        {
            cmbCodigo.DataSource = objNegocios.ListandoIntermedias("");
            cmbCodigo.ValueMember = "Código";
            cmbCodigo.DisplayMember = "Cod";
        }*/
    }
}
