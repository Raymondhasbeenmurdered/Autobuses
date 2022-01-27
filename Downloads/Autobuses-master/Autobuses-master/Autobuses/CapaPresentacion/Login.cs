using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string nombre;
        public string contraseña;
        public string rol;

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

            nombre = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            Conexion.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Usuarios WHERE Nombre = '{nombre}' AND Contraseña = '{contraseña}'", Conexion);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Properties.Settings.Default.Usuario = dr.GetString(2);
                Properties.Settings.Default.Contraseña = txtContraseña.Text;
                Properties.Settings.Default.Rol = dr.GetString(4);

                Properties.Settings.Default.Save();

                new Menu().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Las credenciales no coinciden");
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario") txtUsuario.Text = "";
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") txtUsuario.Text = "Usuario";
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                if (checkBoxMostrarContraseña.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    txtContraseña.PasswordChar = '*';
                }
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = '\0';
            }

        }

        private void dragBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkBoxMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (checkBoxMostrarContraseña.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                checkBoxMostrarContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtContraseña.PasswordChar = '\0';
            }
            else if (checkBoxMostrarContraseña.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                checkBoxMostrarContraseña.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                
                if (txtContraseña.Text != "Contraseña") txtContraseña.PasswordChar = '*';
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) buttonLogin_Click(sender, e);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Usuario != "" && Properties.Settings.Default.Contraseña != "")
            {
                buttonLogin.TabIndex = 0;

                txtUsuario.Text = Properties.Settings.Default.Usuario;
                txtContraseña.PasswordChar = '*';
                txtContraseña.Text = Properties.Settings.Default.Contraseña;
            }
        }
    }
}
