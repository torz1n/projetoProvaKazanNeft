using primeiraProva.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmManagement : frmParent
    {
        public frmManagement()
        {
            InitializeComponent();
            this.Text = "Emergency Maintenance Management";
            dgvManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //faz com que a datagridview selecione todas as colunas
            dgvManagement.MultiSelect = false; //permite somente a selecao de umas das linhas da datagridview

            //assetSn = assets
            //assetName = Assets
            //emreportdate = tabela EmergencyMaintenances
            //FirstName && lastName = tabela Employees
            //Department Name = Departments

            var assetsList = ctx.Assets.Where(x => x.EmergencyMaintenances.Any(a => a.EMReportDate != null)).ToList(); //só pega os dados de emergencyMaintenances quando a data de report for diferente de nula, porque eu só quero a lista dos assets onde teve um report.
            foreach (var assets in assetsList)
            {
                var departmentName = assets.DepartmentLocation.Department.Name.ToString();
                var fullName = assets.Employee.FirstName + assets.Employee.LastName.ToString();
                var reportDate = assets.EmergencyMaintenances.FirstOrDefault().EMReportDate;
                var assetName = assets.AssetName.ToString();
                var assetSn = assets.AssetSN.ToString();

                
                var addInTable = dgvManagement.Rows.Add(assetSn, assetName, reportDate, fullName, departmentName);

                dgvManagement.Rows[addInTable].Tag = assets;
            }
        }

        private void btnManageRequestManagement_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dgvManagement.SelectedRows[0];
            var selectedEM = linhaSelecionada.Tag as Asset;//linha que foi selecionada e que vai ser salva para o próximo arquivo
            
            if (linhaSelecionada == null)
            {   
                
            }



            new frmDetailsRequestMaintenance(selectedEM).Show();
        }
    }
}
