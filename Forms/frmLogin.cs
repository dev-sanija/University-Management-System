using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniEventApp.Forms;

namespace UniEventApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAdminConsole adminConsole = new frmAdminConsole();            
            adminConsole.Show();
            this.Hide();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
