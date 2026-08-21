using primeiraProva.Models;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmDetailsRequestMaintenance : frmParent
    {
        public frmDetailsRequestMaintenance(Asset selectedEM)//pegando o parametro que eu passei lá no outro form
        {
            InitializeComponent();

            this.Text = "Emergency Maintenance Request Details";
            if (selectedEM == null)
            {
                "Foi selecionada uma linha vazia!".Warning();
                return;
            }
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
            
            //só ta pegando a data mais atual de 2019!! nao pega a de 2017!!!!!!!!!!!!!!!!!!!


            //se a startDate for vazia
            if (!dtpStart.Checked)
            {
                btnSubmitDetails.Enabled = false;
            }

            var techNote = selectedEM.EmergencyMaintenances.FirstOrDefault().EMTechnicianNote;
            richTextBox1.Text = techNote;
            if (richTextBox1.Text == string.Empty);
            { 
                dtpCompleted.Enabled = false;
            }

            var partName = ctx.Parts.Select(x => x.Name).ToList();//selectedEM.EmergencyMaintenances.FirstOrDefault().ChangedParts.FirstOrDefault().Part.Name.ToString();
            comboBoxPartNameDetails.DataSource = partName;
            if (partName == null)
            {
                comboBoxPartNameDetails.Text = string.Empty;
            }

            //amount dando problema!
            var amount = ctx.ChangedParts.Select(x => x.Amount).ToList();
            numericUpDown4.Text = amount.ToString();

            if (dtpStart.Value < selectedEM.EmergencyMaintenances.FirstOrDefault().EMReportDate)
            {
                btnSubmitDetails.Enabled = false;
            }
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
            var adicionarLinhas = dgvDetails.Rows.Add(comboBoxPartNameDetails.Text, numericUpDown4.Text, linkLabel1.Text);
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.ColumnIndex != -1)
            {
                var removerLinha = dgvDetails.Rows[e.RowIndex];
                dgvDetails.Rows.Remove(removerLinha);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitDetails_Click(object sender, EventArgs e)
        {
            "Documento Enviado!".Information();
            //mexer no tabela changedparts do banco de dados, para enviar o que foi alterado
        }

        private void btnCancelDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
