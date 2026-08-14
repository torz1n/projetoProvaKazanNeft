using System;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmMaintenanceManagement : frmParent
    {
        public frmMaintenanceManagement()
        {
            InitializeComponent();
            this.Text = "Emergency Maintenance Management";

            dgvMaintenanceManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaintenanceManagement.MultiSelect = false;
        }

        private void txtAvailableAssets_Click(object sender, EventArgs e)
        {

        }

        private void btnSendEmergencyMaintenaneRequest_Click(object sender, EventArgs e)
        {
            new frmRequest().Show();
        }
    }
}
