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
    public partial class AutobusesPresentacion : Form
    {

     
        private bool editarse;

        AutobusesEntidades objEntidades = new AutobusesEntidades();
        AutobusesNegocios objNegocios = new AutobusesNegocios();

        public AutobusesPresentacion()
        {
            InitializeComponent();
        }

        private void aja_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            tablaAutobuses.Columns[0].Visible = false;

            buttonEliminar.Visible = Properties.Settings.Default.Eliminar;

            if (Properties.Settings.Default.Rol == "Reader")
            {
                buttonEditar.Visible = false;
                buttonNuevo.Visible = false;
                buttonGuardar.Visible = false;
            }
        }

        public void ListarConductor()
        {
            ConductoresNegocios negocios = new ConductoresNegocios();
            comboBoxConductor.DataSource = negocios.BuscandoConductores("");
            comboBoxConductor.ValueMember = "ID_Conductor";
            comboBoxConductor.DisplayMember = "ID_Conductor";
        }

        public void ListarAsistente()
        {
            AsistentesNegocios negocios = new AsistentesNegocios();
            comboBoxAsistente.DataSource = negocios.BuscandoAsistentes("");
            comboBoxAsistente.ValueMember = "ID_Asistente";
            comboBoxAsistente.DisplayMember = "ID_Asistente";
        }

        public void mostrarBuscarTabla(string buscar)
        {
            AutobusesNegocios objNegocios = new AutobusesNegocios();
            tablaAutobuses.DataSource = objNegocios.ListarAutobuses(buscar);
            comboBoxCodigoAutobus.DataSource = objNegocios.ListarAutobuses(buscar);
            comboBoxCodigoAutobus.ValueMember = "Codigo";
            comboBoxCodigoAutobus.DisplayMember = "Codigo";

            ListarConductor();
            ListarAsistente();

            if (tablaAutobuses.RowCount > 1) limpiarCajas();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (editarse)
            {
                try
                {
                    objEntidades.Codigo = comboBoxCodigoAutobus.Text;
                    objEntidades.Asistente = Convert.ToInt32(comboBoxAsistente.Text);
                    objEntidades.Conductor = Convert.ToInt32(comboBoxConductor.Text);
                    objEntidades.Marca = Convert.ToString(textMarca.Text);
                    objEntidades.Matricula = Convert.ToString(textMatricula.Text);
                    objEntidades.Modelo = Convert.ToString(textModelo.Text);

                    objNegocios.EditandoAutobuses(objEntidades);

                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                    editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo editar el registro {comboBoxCodigoAutobus.Text} {ex}");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBox1.Text);
        }

        public void limpiarCajas()
        {
            textBox1.Text = "";
            comboBoxCodigoAutobus.SelectedIndex = -1;
            comboBoxAsistente.SelectedIndex = -1;
            comboBoxConductor.SelectedIndex = -1;
            textMarca.Text = "";
            textMatricula.Text = "";
            textModelo.Text = "";
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
                    objEntidades.Matricula = textMatricula.Text;
                    objEntidades.Conductor = Convert.ToInt32(comboBoxConductor.Text);
                    objEntidades.Asistente = Convert.ToInt32(comboBoxAsistente.Text);
                    objEntidades.Marca = textMarca.Text;
                    objEntidades.Modelo = textModelo.Text;
                   

                    objNegocios.InsertarAutobuses(objEntidades);

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

        private void tablaAutobuses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaAutobuses.SelectedRows.Count >= 0)
            {
                editarse = true;
                comboBoxCodigoAutobus.Text = tablaAutobuses.CurrentRow.Cells[1].Value.ToString();
                textMatricula.Text = tablaAutobuses.CurrentRow.Cells[2].Value.ToString();
                comboBoxConductor.Text = tablaAutobuses.CurrentRow.Cells[3].Value.ToString();
                comboBoxAsistente.Text = tablaAutobuses.CurrentRow.Cells[4].Value.ToString();
                textMarca.Text = tablaAutobuses.CurrentRow.Cells[5].Value.ToString();
                textModelo.Text = tablaAutobuses.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxCodigoAutobus.Text != "")
            {
                objEntidades.Codigo = tablaAutobuses.CurrentRow.Cells[1].Value.ToString();
                objNegocios.EliminandoAutobuses(objEntidades);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
