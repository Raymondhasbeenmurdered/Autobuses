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
    public partial class ParadasPresentacion : Form
    {
        private bool Editarse = false;

        ParadasEntidades ObjEntidades = new ParadasEntidades();
        ParadasNegocios ObjNegocios = new ParadasNegocios();

        public ParadasPresentacion()
        {
            InitializeComponent();
        }

        private void ParadasPresentacion_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
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
            ParadasNegocios objNegocios = new ParadasNegocios();
            tablaParadas.DataSource = objNegocios.ListarParadas(buscar);
            comboBox1.DataSource = objNegocios.ListarParadas(buscar);
            comboBox1.ValueMember = "Codigo";
            comboBox1.DisplayMember = "Codigo";
            comboBox2.DataSource = objNegocios.ListarParadas(buscar);
            comboBox2.ValueMember = "Ciudad";
            comboBox2.DisplayMember = "Ciudad";

            if (tablaParadas.RowCount > 1) limpiarCajas();
        }

        public void accionesTabla()
        {
            tablaParadas.Columns[0].Visible = false;
            tablaParadas.Columns[1].Width = 90;
            tablaParadas.Columns[2].Width = 80;
            tablaParadas.ClearSelection();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscador.Text);
        }

        public void limpiarCajas()
        { 
            txtBuscador.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
            Editarse = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (Editarse)
            {
                try
                {
                    ObjEntidades.Codigo = comboBox1.Text;
                    ObjEntidades.Ciudad = Convert.ToInt32(comboBox2.Text);
                    ObjEntidades.Nombre = txtNombre.Text;
                    ObjEntidades.Direccion = txtDireccion.Text;

                    ObjNegocios.EditarParadas(ObjEntidades);

                    MessageBox.Show("Se editó el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!Editarse)
            {
                try
                {
                    ObjEntidades.Nombre = txtNombre.Text;
                    ObjEntidades.Direccion = txtDireccion.Text;

                    ObjNegocios.InsertarParadas(ObjEntidades);

                    MessageBox.Show("Se guadó el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
        }

        private void tablaParadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaParadas.SelectedRows.Count >= 0)
            {
                Editarse = true;
                comboBox1.Text = tablaParadas.CurrentRow.Cells[1].Value.ToString();
                comboBox2.Text = tablaParadas.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = tablaParadas.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = tablaParadas.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                ObjEntidades.Codigo = tablaParadas.CurrentRow.Cells[1].Value.ToString();
                ObjNegocios.EliminarParadas(ObjEntidades);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
