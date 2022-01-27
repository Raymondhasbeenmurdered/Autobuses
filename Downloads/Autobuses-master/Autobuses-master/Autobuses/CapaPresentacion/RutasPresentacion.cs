using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class RutasPresentacion : Form
    {
        private bool editarse = false;

        RutasEntidades objEntidad = new RutasEntidades();
        RutasNegocios objNegocio = new RutasNegocios();

        public RutasPresentacion()
        {
            InitializeComponent();
        }

        private void PresentacionRuta_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");

            buttonEliminar.Visible = Properties.Settings.Default.Eliminar;

            if (Properties.Settings.Default.Rol == "Reader")
            {
                buttonEditar.Visible = false;
                buttonNuevo.Visible = false;
                buttonGuardar.Visible = false;
            }

            accionesTabla();
        }

        public void accionesTabla()
        {
            tablaRutas.Columns[0].Visible = false;

        }

        public void mostrarBuscarTabla(string buscar)
        {
            RutasNegocios objNegocio = new RutasNegocios();
            tablaRutas.DataSource = objNegocio.ListarRuta(buscar);
            comboBoxCodigo.DataSource = objNegocio.ListarRuta(buscar);
            comboBoxCodigo.ValueMember = "Codigo";
            comboBoxCodigo.DisplayMember = "Codigo";

            ListarParadaIntermedia();
            ListarCiudad();
            ListarAutobus();

            if (tablaRutas.RowCount > 1) limpiarCajas();
        }

        public void ListarParadaIntermedia()
        {
            IntermediasNegocios negocios = new IntermediasNegocios();
            comboBoxParadaIntermedia.DataSource = negocios.ListandoIntermedias("");
            comboBoxParadaIntermedia.ValueMember = "Id";
            comboBoxParadaIntermedia.DisplayMember = "Id";
        }

        public void ListarCiudad()
        {
            CiudadesNegocios negocios = new CiudadesNegocios();
            comboBoxCiudad.DataSource = negocios.ListarCiudades("");
            comboBoxCiudad.ValueMember = "ID_Ciudad";
            comboBoxCiudad.DisplayMember = "ID_Ciudad";
        }

        public void ListarAutobus()
        {
            AutobusesNegocios negocios = new AutobusesNegocios();
            comboBoxAutobus.DataSource = negocios.ListarAutobuses("");
            comboBoxAutobus.ValueMember = "ID_Autobus";
            comboBoxAutobus.DisplayMember = "ID_Autobus";
        }

        private void limpiarCajas()
        {
            editarse = false;
            txtNombre.Clear();
            txtPartida.Clear();
            txtDestino.Clear();
            comboBoxParadaIntermedia.SelectedIndex = -1;
            comboBoxCiudad.SelectedIndex = -1;
            comboBoxAutobus.SelectedIndex = -1;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscador.Text);
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (editarse)
            {
                try
                {
                    objEntidad.Codigo = comboBoxCodigo.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Partida = txtPartida.Text;
                    objEntidad.Destino = txtDestino.Text;
                    objEntidad.ParadaINTER = Convert.ToInt32(comboBoxParadaIntermedia.Text);
                    objEntidad.Ciudad = Convert.ToInt32(comboBoxCiudad.Text);
                    objEntidad.Autobus = Convert.ToInt32(comboBoxAutobus.Text);

                    objNegocio.EditandoRutas(objEntidad);

                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    editarse = false;
                    limpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro " + txtNombre.Text + ex);
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!editarse)
            {
                try
                {
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Partida = txtPartida.Text;
                    objEntidad.Destino = txtDestino.Text;
                    objEntidad.ParadaINTER = Convert.ToInt32(comboBoxParadaIntermedia.Text);
                    objEntidad.Ciudad = Convert.ToInt32(comboBoxCiudad.Text);
                    objEntidad.Autobus = Convert.ToInt32(comboBoxAutobus.Text);

                    objNegocio.InsertandoRutas(objEntidad);

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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxCodigo.Text != "")
            {
                objEntidad.Codigo = tablaRutas.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoRutas(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
        private void tablaRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editarse = true;
            comboBoxCodigo.Text = tablaRutas.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = tablaRutas.CurrentRow.Cells[2].Value.ToString();
            txtPartida.Text = tablaRutas.CurrentRow.Cells[3].Value.ToString();
            txtDestino.Text = tablaRutas.CurrentRow.Cells[4].Value.ToString();
            comboBoxParadaIntermedia.Text = tablaRutas.CurrentRow.Cells[5].Value.ToString();
            comboBoxCiudad.Text = tablaRutas.CurrentRow.Cells[6].Value.ToString();
            comboBoxAutobus.Text = tablaRutas.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
