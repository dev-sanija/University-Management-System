using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniEventApp.Forms
{
    public partial class frmAdminConsole : Form
    {
        public frmAdminConsole()
        {
            InitializeComponent();
        }

        private void frmAdminConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // safely terminates the whole application when the admin console closes
        }
    }
}
