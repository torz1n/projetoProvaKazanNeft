using primeiraProva.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmRequest : frmParent
    {
        private Asset selectedAsset;

        public frmRequest(Asset selectedAsset)
        {
            InitializeComponent();
            this.Text = "Emergency Maintenance Management Request";
            this.selectedAsset = selectedAsset;
            label8.Text = selectedAsset.AssetSN;
            label7.Text = selectedAsset.AssetName;
            label9.Text = selectedAsset.DepartmentLocation.Department.Name;

            itensComboBox();

            btnCancelRequest.Text = "Cancel Request";
            btnSendRequest.Text = "Send Request";
        }

        private void itensComboBox()
        {
            comboBoxRequest.DataSource = ctx.Priorities.Select(x => x.Name).ToList();
            comboBoxRequest.SelectedIndex = -1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//Send Request    
        {
            if (comboBoxRequest.Text == string.Empty)
            {
                "Informações inválidas ou não preenchidas!".Information();
                return;
            }
            else if (txtDescriptionOfEmergency.Text == "")
            {
                "Informações inválidas ou não preenchidas!".Information();
                return;
            }
            else if (txtOtherConsiderations.Text == "")
            {
                "Informações inválidas ou não preenchidas!".Information();
                return;
            }

            var verificao = ctx.EmergencyMaintenances.Any(x => x.AssetID == selectedAsset.ID && x.EMEndDate == null);

            if (verificao)
            {
                "Já existe uma solicitação aberta pra esse ativo!".Warning();
                return;
            }


            EmergencyMaintenance emMaintenance = new EmergencyMaintenance();
            emMaintenance.AssetID = selectedAsset.ID;
            emMaintenance.DescriptionEmergency = txtDescriptionOfEmergency.Text;
            emMaintenance.OtherConsiderations = txtOtherConsiderations.Text;
            emMaintenance.EMReportDate = DateTime.Now.Date;
            emMaintenance.EMStartDate = null;
            emMaintenance.EMEndDate = null;
            emMaintenance.EMTechnicianNote = null;
            emMaintenance.PriorityID = ctx.Priorities.ToList().FirstOrDefault(x => x.Name == comboBoxRequest.SelectedItem.ToString()).ID;


            ctx.EmergencyMaintenances.Add(emMaintenance);
            ctx.SaveChanges();

            "Solicitação Cadastrada com Sucesso".Information();
            this.Close();

        }

        private void txtAssetSN_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
