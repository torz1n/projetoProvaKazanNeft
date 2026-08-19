using primeiraProva.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmMaintenanceManagement : frmParent
    {
        public frmMaintenanceManagement()//construtor
        {
            InitializeComponent();
            this.Text = "Emergency Maintenance Management";
            dgvMaintenanceManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //faz com que a datagridview selecione todas as colunas
            dgvMaintenanceManagement.MultiSelect = false; //permite somente a selecao de umas das linhas da datagridview


            var assetsList = ctx.Assets.ToList();
            foreach (var asset in assetsList)
            {
                int numberClosedEMS = asset.EmergencyMaintenances.Where(b => b.EMEndDate != null).Count();
                DateTime? lastClosedEMS = asset.EmergencyMaintenances.Max(b => b.EMEndDate);
                string nameOfDepartment = asset.DepartmentLocation.Department.Name.ToString();

                int numberRow = dgvMaintenanceManagement.Rows.Add(asset.AssetSN, asset.AssetName, lastClosedEMS == null ? 0.ToString() : lastClosedEMS.ToString()/*if ternário*/, numberClosedEMS.ToString());
                

                dgvMaintenanceManagement.Rows[numberRow].Tag = asset;
            }
        }

        private void txtAvailableAssets_Click(object sender, EventArgs e)
        {

        }

        public void btnSendEmergencyMaintenaneRequest_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dgvMaintenanceManagement.SelectedRows[0];//inclui o numero da coluna e pega os valores da linha
            var SelectedAsset = linhaSelecionada.Tag as Asset;

            new frmRequest(SelectedAsset).Show();
        }

        private void dgvMaintenanceManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
