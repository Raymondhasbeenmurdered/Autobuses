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
    public partial class BoletosPresentacion : Form
    {
        //private string codBoletos;
        private bool editarse = false;

        BoletosEntidades objEntidades = new BoletosEntidades();
        BoletosNegocios objNegocios = new BoletosNegocios();

        public BoletosPresentacion()
        {
            InitializeComponent();
        }

        private void BoletosPresentacionLoad(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            tablaBoletos.Columns[0].Visible = false;
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
            BoletosNegocios objNegocios = new BoletosNegocios();
            tablaBoletos.DataSource = objNegocios.ListandoBoletos(buscar);

            cmbCodigo.DataSource = objNegocios.ListandoBoletos(buscar);
            cmbCodigo.ValueMember = "Codigo";
            cmbCodigo.DisplayMember = "Codigo";

            ListarRuta();

            if (tablaBoletos.RowCount > 1) LimpiarCajas();
        }

        private void ListarRuta()
        {
            RutasNegocios negocios = new RutasNegocios();
            cmbID.DataSource = negocios.ListarRuta("");
            cmbID.ValueMember = "ID_Ruta";
            cmbID.DisplayMember = "ID_Ruta";
        }

        /* public void accionesTabla()
         {
             tablaBoletos.Columns[0].Visible = false;
             tablaBoletos.Columns[1].Width = 30;
             tablaBoletos.Columns[2].Width = 60;
             tablaBoletos.Columns[3].Width = 90;
             tablaBoletos.Columns[4].Width = 30;
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
            cmbID.Text = "";
            txtPrecio.Text = "";
            txtFecha.Text = "";
            txtHora.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editarse)
            {
                try
                {
                    objEntidades.Codigo = Convert.ToString(cmbCodigo.Text);
                    objEntidades.Ruta = Convert.ToInt32(cmbID.Text);
                    objEntidades.Precio = Convert.ToDouble(txtPrecio.Text);
                    objEntidades.Fecha = Convert.ToString(txtFecha.Text);
                    objEntidades.Hora = TimeSpan.Parse(txtHora.Text);

                    objNegocios.EditandoBoletos(objEntidades);

                    MessageBox.Show("Se editó el registro");
                    mostrarBuscarTabla("");
                    LimpiarCajas();
                    editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo editar el registro {txtPrecio.Text} {ex}");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!editarse)
            {
                try
                {
                    objEntidades.Ruta = Convert.ToInt32(cmbID.Text);
                    objEntidades.Precio = Convert.ToDouble(txtPrecio.Text);

                    objNegocios.InsertandoBoletos(objEntidades);

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
                objEntidades.Codigo = Convert.ToString(tablaBoletos.CurrentRow.Cells[1].Value.ToString());
                objNegocios.EliminandoBoletos(objEntidades);

                MessageBox.Show("Se eliminó correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void tablaBoletos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaBoletos.SelectedRows.Count > 0)
            {
                editarse = true;
                cmbCodigo.Text = tablaBoletos.CurrentRow.Cells[1].Value.ToString();
                cmbID.Text = tablaBoletos.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = tablaBoletos.CurrentRow.Cells[3].Value.ToString();
                txtFecha.Text = tablaBoletos.CurrentRow.Cells[4].Value.ToString();
                txtHora.Text = tablaBoletos.CurrentRow.Cells[5].Value.ToString();
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
