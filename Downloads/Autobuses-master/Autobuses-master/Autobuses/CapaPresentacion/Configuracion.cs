using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        public bool eliminar = false;

        private void checkBoxEliminar_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Eliminar = checkBoxEliminar.Checked;
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Rol != "Admin") checkBoxEliminar.Enabled = false;
            else checkBoxEliminar.Checked = Properties.Settings.Default.Eliminar;
        }
    }
}
