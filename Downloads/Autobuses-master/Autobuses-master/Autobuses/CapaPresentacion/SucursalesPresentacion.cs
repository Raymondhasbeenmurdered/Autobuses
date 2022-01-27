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
    public partial class SucursalesPresentacion : Form
    {
        private bool Editarse = false;

        SucursalesEntidades ObjEntidades = new SucursalesEntidades();
        SucursalesNegocios ObjNegocios = new SucursalesNegocios();

        public SucursalesPresentacion()
        {
            InitializeComponent();
        }

        private void SucursalesPresentacion_Load(object sender, EventArgs e)
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
            SucursalesNegocios objNegocios = new SucursalesNegocios();
            tablaSucursales.DataSource = objNegocios.ListarSucursales(buscar);
            comboBox1.DataSource = objNegocios.ListarSucursales(buscar);
            comboBox1.ValueMember = "Codigo";
            comboBox1.DisplayMember = "Codigo";
            comboBox2.DataSource = objNegocios.ListarSucursales(buscar);
            comboBox2.ValueMember = "Ciudad";
            comboBox2.DisplayMember = "Ciudad";

            if (tablaSucursales.RowCount > 1) limpiarCajas();
        }

        public void accionesTabla()
        {
            tablaSucursales.Columns[0].Visible = false;
            tablaSucursales.Columns[1].Width = 90;
            tablaSucursales.Columns[2].Width = 90;

            tablaSucursales.ClearSelection();
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
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
            Editarse = false;
        }

        private void tablaSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaSucursales.SelectedRows.Count >= 0)
            {
                Editarse = true;
                comboBox1.Text = tablaSucursales.CurrentRow.Cells[1].Value.ToString();
                comboBox2.Text = tablaSucursales.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = tablaSucursales.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!Editarse)
            {
                try
                {
                    ObjEntidades.Ciudad = Convert.ToInt32(comboBox2.Text);
                    ObjEntidades.Direccion = txtDireccion.Text;

                    ObjNegocios.InsertarSucursales(ObjEntidades);

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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (Editarse)
            {
                try
                {
                    ObjEntidades.Codigo = comboBox1.Text;
                    ObjEntidades.Ciudad = Convert.ToInt32(comboBox2.Text);
                    ObjEntidades.Direccion = txtDireccion.Text;

                    ObjNegocios.EditarSucursales(ObjEntidades);

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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                ObjEntidades.Codigo = tablaSucursales.CurrentRow.Cells[1].Value.ToString();
                ObjNegocios.EliminarSucursales(ObjEntidades);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
