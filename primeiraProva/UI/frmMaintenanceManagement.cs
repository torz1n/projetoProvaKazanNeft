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
                // asset.EmergencyMaintenances = ctx.EmergencyMaintenances.where(b => b.asset.id == AssetID)
                int numberClosedEMS = asset.EmergencyMaintenances.Where(b => b.EMEndDate != null).Count();
                DateTime? lastClosedEMS = asset.EmergencyMaintenances.Max(b => b.EMEndDate);
                string nameOfDepartment = asset.DepartmentLocation.Department.Name.ToString();

                int numberRow = dgvMaintenanceManagement.Rows.Add(asset.AssetSN, asset.AssetName, lastClosedEMS == null ? 0.ToString() : lastClosedEMS.ToString()/*if ternário*/, numberClosedEMS.ToString());
                

                dgvMaintenanceManagement.Rows[numberRow].Tag = asset;
            }

            //dgvMaintenanceManagement.Columns["ID"].Visible = false;
            //dgvMaintenanceManagement.Columns["EmployeeID"].Visible = false;
            //dgvMaintenanceManagement.Columns["AssetGroupID"].Visible = false;
            //dgvMaintenanceManagement.Columns["WarrantyDate"].Visible = false;
            //dgvMaintenanceManagement.Columns["Description"].Visible = false;
            //dgvMaintenanceManagement.Columns["DepartmentLocationID"].Visible = false;

            //dgvMaintenanceManagement.DataSource = ctx.EmergencyMaintenances.ToList();//????
        }

        private void txtAvailableAssets_Click(object sender, EventArgs e)
        {

        }

        public void btnSendEmergencyMaintenaneRequest_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dgvMaintenanceManagement.SelectedRows[0];//inclui o numero da coluna e pega os valores da linha
            var SelectedAsset = linhaSelecionada.Tag as Asset;

            //string valorAssetSN = linhaSelecionada.Cells["AssetSN"].Value.ToString();//pega o valores e envia pra outra tela por meio dos parametros
            //string valorAssetName = linhaSelecionada.Cells["AssetName"].Value.ToString();
            //string valorLastClosed = linhaSelecionada.Cells["LastClosedEM"].Value.ToString();
            //string valorNumberOfEMs = linhaSelecionada.Cells["NumberOfEMs"].Value.ToString();

            new frmRequest(SelectedAsset).Show();
        }

        private void dgvMaintenanceManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
