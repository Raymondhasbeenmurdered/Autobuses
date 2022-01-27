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
    public partial class Menu : Form
    {
        public string usuario;

        public Menu()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Rol != "Admin")
            {
                buttonUsuarios.Hide();
                Properties.Settings.Default.Eliminar = false;
            }

            labelUsuario.Text = Properties.Settings.Default.Usuario + " - " + Properties.Settings.Default.Rol;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonParadas_Click(object sender, EventArgs e)
        {
            selectButton(buttonParadas);
            openChildForm(new ParadasPresentacion());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private Button activeFormButton = null;
        private void selectButton(Button _activeButton)
        {
            if (activeFormButton != null) activeFormButton.BackColor = Color.FromArgb(245, 175, 80);
            activeFormButton = _activeButton;
            _activeButton.BackColor = Color.FromArgb(241, 146, 14);
        }

        private void buttonCiudades_Click(object sender, EventArgs e)
        {
            selectButton(buttonCiudades);
            openChildForm(new CiudadesPresentacion());
        }

        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }  
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            new Login().Visible = true;
            this.Close();
        }

        private void buttonRutas_Click(object sender, EventArgs e)
        {
            selectButton(buttonRutas);
            openChildForm(new RutasPresentacion());
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            selectButton(buttonConfiguracion);
            openChildForm(new Configuracion());
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            selectButton(buttonUsuarios);
            openChildForm(new UsuariosPresentacion());
        }

        private void buttonBoletos_Click(object sender, EventArgs e)
        {
            selectButton(buttonBoletos);
            openChildForm(new BoletosPresentacion());
        }

        private void buttonParadasIntermitentes_Click(object sender, EventArgs e)
        {
            selectButton(buttonIntermitentes);
            openChildForm(new IntermediasPresentacion());
        }

        private void buttonSucursales_Click(object sender, EventArgs e)
        {
            selectButton(buttonSucursales);
            openChildForm(new SucursalesPresentacion());
        }

        private void buttonAutobuses_Click(object sender, EventArgs e)
        {
            selectButton(buttonAutobuses);
            openChildForm(new AutobusesPresentacion());
        }

        private void buttonConductores_Click(object sender, EventArgs e)
        {
            selectButton(buttonConductores);
            openChildForm(new ConductoresPresentacion());
        }

        private void buttonAsistentes_Click(object sender, EventArgs e)
        {
            selectButton(buttonAsistentes);
            openChildForm(new AsistentesPresentacion());
        }
    }
}
