using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmLogin : frmParent
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Text = "Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = ctx.Employees.FirstOrDefault(b => b.Username == txtUserLogin.Text && b.Password == z.Text);

            if (user == null)
            {
                "usuario nao encontrado".Question();
                return;
            }

            Hide();
            new frmMaintenanceManagement().Show();
        
        }
    }
}
