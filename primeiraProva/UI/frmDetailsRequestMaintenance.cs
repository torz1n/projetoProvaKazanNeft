using primeiraProva.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmDetailsRequestMaintenance : frmParent
    {
        public frmDetailsRequestMaintenance(Asset selectedEM)
        {
            InitializeComponent();

            this.Text = "Emergency Maintenance Request Details";

            label4.Text = selectedEM.AssetSN;
            label5.Text = selectedEM.AssetName;
            label6.Text = selectedEM.DepartmentLocation.Department.Name.ToString();

            /*
             start date = emergency maintenances
             completed on = emergency maintenances
             technician note = emergency maintenances
            partname = changedparts - parts - name
            amount = changedparts
            action = link pra remover o que esta gravado na linha
             */
            var startDate = ctx.EmergencyMaintenances.FirstOrDefault(x => x.AssetID == selectedEM.ID);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToListDetails_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
