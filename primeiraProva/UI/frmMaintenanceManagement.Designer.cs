namespace primeiraProva.UI
{
    partial class frmMaintenanceManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMaintenanceManagement = new System.Windows.Forms.DataGridView();
            this.AssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastClosedEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfEMs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAvailableAssets = new System.Windows.Forms.Label();
            this.btnSendEmergencyMaintenaneRequest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendEmergencyMaintenaneRequest);
            this.panel1.Controls.Add(this.txtAvailableAssets);
            this.panel1.Controls.Add(this.dgvMaintenanceManagement);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            // 
            // dgvMaintenanceManagement
            // 
            this.dgvMaintenanceManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetSN,
            this.AssetName,
            this.LastClosedEM,
            this.NumberOfEMs});
            this.dgvMaintenanceManagement.Location = new System.Drawing.Point(41, 84);
            this.dgvMaintenanceManagement.Name = "dgvMaintenanceManagement";
            this.dgvMaintenanceManagement.RowHeadersWidth = 51;
            this.dgvMaintenanceManagement.RowTemplate.Height = 24;
            this.dgvMaintenanceManagement.Size = new System.Drawing.Size(555, 274);
            this.dgvMaintenanceManagement.TabIndex = 0;
            this.dgvMaintenanceManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaintenanceManagement_CellContentClick);
            // 
            // AssetSN
            // 
            this.AssetSN.HeaderText = "AssetSN";
            this.AssetSN.MinimumWidth = 6;
            this.AssetSN.Name = "AssetSN";
            this.AssetSN.Width = 125;
            // 
            // AssetName
            // 
            this.AssetName.HeaderText = "AssetName";
            this.AssetName.MinimumWidth = 6;
            this.AssetName.Name = "AssetName";
            this.AssetName.Width = 125;
            // 
            // LastClosedEM
            // 
            this.LastClosedEM.HeaderText = "Last Closed EM";
            this.LastClosedEM.MinimumWidth = 6;
            this.LastClosedEM.Name = "LastClosedEM";
            this.LastClosedEM.Width = 125;
            // 
            // NumberOfEMs
            // 
            this.NumberOfEMs.HeaderText = "NumberOfEMs";
            this.NumberOfEMs.MinimumWidth = 6;
            this.NumberOfEMs.Name = "NumberOfEMs";
            this.NumberOfEMs.Width = 125;
            // 
            // txtAvailableAssets
            // 
            this.txtAvailableAssets.AutoSize = true;
            this.txtAvailableAssets.Location = new System.Drawing.Point(38, 48);
            this.txtAvailableAssets.Name = "txtAvailableAssets";
            this.txtAvailableAssets.Size = new System.Drawing.Size(108, 16);
            this.txtAvailableAssets.TabIndex = 1;
            this.txtAvailableAssets.Text = "Avaiable Assets:";
            this.txtAvailableAssets.Click += new System.EventHandler(this.txtAvailableAssets_Click);
            // 
            // btnSendEmergencyMaintenaneRequest
            // 
            this.btnSendEmergencyMaintenaneRequest.Location = new System.Drawing.Point(41, 384);
            this.btnSendEmergencyMaintenaneRequest.Name = "btnSendEmergencyMaintenaneRequest";
            this.btnSendEmergencyMaintenaneRequest.Size = new System.Drawing.Size(258, 25);
            this.btnSendEmergencyMaintenaneRequest.TabIndex = 2;
            this.btnSendEmergencyMaintenaneRequest.Text = "Send Emergency Maintenance Request";
            this.btnSendEmergencyMaintenaneRequest.UseVisualStyleBackColor = true;
            this.btnSendEmergencyMaintenaneRequest.Click += new System.EventHandler(this.btnSendEmergencyMaintenaneRequest_Click);
            // 
            // frmMaintenanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmMaintenanceManagement";
            this.Text = "frmMaintenanceManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaintenanceManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastClosedEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfEMs;
        private System.Windows.Forms.Button btnSendEmergencyMaintenaneRequest;
        private System.Windows.Forms.Label txtAvailableAssets;
    }
}