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

            dgvMaintenanceManagement.DataSource = ctx.Assets.ToList();
            dgvMaintenanceManagement.DataSource = ctx.EmergencyMaintenances.ToList();//preciso disso??

            dgvMaintenanceManagement.Columns["ID"].Visible = false;
            dgvMaintenanceManagement.Columns["EmployeeID"].Visible = false;
            dgvMaintenanceManagement.Columns["AssetGroupID"].Visible = false;
            dgvMaintenanceManagement.Columns["WarrantyDate"].Visible = false;
            dgvMaintenanceManagement.Columns["Description"].Visible = false;
            dgvMaintenanceManagement.Columns["DepartmentLocationID"].Visible = false;


            dgvMaintenanceManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //faz com que a datagridview selecione todas as colunas
            dgvMaintenanceManagement.MultiSelect = false; //permite somente a selecao de umas das linhas da datagridview
        }

        private void txtAvailableAssets_Click(object sender, EventArgs e)
        {

        }

        public void btnSendEmergencyMaintenaneRequest_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dgvMaintenanceManagement.SelectedRows[0];//inclui o numero da coluna e pega os valores da linha

            var asset = ctx.Assets.FirstOrDefault()//definindo uma variavel asset a partir da tabela assets, para navegar entre a tabela deparmwnt
                

            string valorAssetSN= linhaSelecionada.Cells["AssetSN"].Value.ToString();//pega o valores e envia pra outra tela por meio dos parametros
            string valorAssetName = linhaSelecionada.Cells["AssetName"].Value.ToString();
            string valorLastClosed = linhaSelecionada.Cells["LastClosedEM"].Value.ToString();
            string valorNumberOfEMs = linhaSelecionada.Cells["NumberOfEMs"].Value.ToString();

            new frmRequest(valorAssetName,valorLastClosed,valorAssetName, valorAssetSN).Show();
        }

        private void dgvMaintenanceManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
