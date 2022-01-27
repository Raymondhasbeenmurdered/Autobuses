using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (panel3.Width < 50) panel3.Width += 5;
            else if (panel3.Width < 100) panel3.Width += 7;
            else if (panel3.Width < 200) panel3.Width += 10;
            else if (panel3.Width < 300) panel3.Width += 13;
            else if (panel3.Width < 445) panel3.Width += 15;

            if (panel3.Width >= 445)
            {
                timer1.Stop();
                Login login = new Login();
                Thread.Sleep(100);
                login.Show();
                this.Hide();
            }
        }
    }
}
