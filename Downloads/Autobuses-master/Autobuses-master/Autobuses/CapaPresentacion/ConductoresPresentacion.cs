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
    public partial class ConductoresPresentacion : Form
    {

        private bool editarse = false;

        ConductoresEntidades objEntidades = new ConductoresEntidades();
        ConductoresNegocios objNegocios = new ConductoresNegocios();

        public ConductoresPresentacion()
        {
            InitializeComponent();
        }

        private void ConductoresPresentacion_Load(object sender, EventArgs e)
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
        public void mostrarBuscarTabla(string buscar)
        {
            ConductoresNegocios objNegocios = new ConductoresNegocios();
            tablaConductores.DataSource = objNegocios.BuscandoConductores(buscar);
            comboBoxCodigo.DataSource = objNegocios.BuscandoConductores(buscar);
            comboBoxCodigo.ValueMember = "Codigo";
            comboBoxCodigo.DisplayMember = "Codigo";
            comboBoxSexo.ValueMember = "Sexo";
            comboBoxSexo.DisplayMember = "Sexo";

            if (tablaConductores.RowCount > 1) limpiarCajas();
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
            tablaConductores.Columns[0].Visible = false;
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
                    objEntidades.Codigo = Convert.ToString(comboBoxCodigo.Text);
                    objEntidades.Apellidos = Convert.ToString(txtApellidos.Text);
                    objEntidades.Nombre = Convert.ToString(txtNombre.Text);
                    objEntidades.Sexo = Convert.ToString(comboBoxSexo.Text);
                    objEntidades.Cedula = Convert.ToString(txtCedula.Text);
                    objEntidades.F_Nacimiento = Convert.ToString(txtF_Nacimiento.Text);
                    objEntidades.Direccion = Convert.ToString(txtDireccion.Text);
                    objEntidades.Sueldo = Convert.ToDouble(txtSueldo.Text);
                    objEntidades.Telefono = Convert.ToString(txtTelefono.Text);

                    objNegocios.EditandoConductores(objEntidades);

                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                    editarse = false;
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show($"No se pudo editar el registro {txtNombre.Text}");
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxCodigo.Text != "")
            {
                objEntidades.Codigo = tablaConductores.CurrentRow.Cells[1].Value.ToString();
                objNegocios.EliminandoConductores(objEntidades);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
                MessageBox.Show("Seleccione una fila");
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

                    objNegocios.InsertandoConductores(objEntidades);

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

        private void tablaConductores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscador.Text);
        }

        private void tablaConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaConductores.SelectedRows.Count >= 0)
            {
                editarse = true;
                comboBoxCodigo.Text = tablaConductores.CurrentRow.Cells[1].Value.ToString();
                txtApellidos.Text = tablaConductores.CurrentRow.Cells[4].Value.ToString();
                txtNombre.Text = tablaConductores.CurrentRow.Cells[3].Value.ToString();
                comboBoxSexo.Text = tablaConductores.CurrentRow.Cells[8].Value.ToString(); ;
                txtCedula.Text = tablaConductores.CurrentRow.Cells[2].Value.ToString();
                txtF_Nacimiento.Text = tablaConductores.CurrentRow.Cells[6].Value.ToString();
                txtDireccion.Text = tablaConductores.CurrentRow.Cells[7].Value.ToString(); ;
                txtSueldo.Text = tablaConductores.CurrentRow.Cells[9].Value.ToString();
                txtTelefono.Text = tablaConductores.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
