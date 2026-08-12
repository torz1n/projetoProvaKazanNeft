namespace primeiraProva.UI
{
    partial class frmManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManagement = new System.Windows.Forms.DataGridView();
            this.btnManageRequestManagement = new System.Windows.Forms.Button();
            this.AssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Assets Requesting EM:";
            // 
            // dgvManagement
            // 
            this.dgvManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetSN,
            this.AssetName,
            this.RequestDate,
            this.EmployeeFullName,
            this.Department});
            this.dgvManagement.Location = new System.Drawing.Point(46, 89);
            this.dgvManagement.Name = "dgvManagement";
            this.dgvManagement.RowHeadersWidth = 51;
            this.dgvManagement.RowTemplate.Height = 24;
            this.dgvManagement.Size = new System.Drawing.Size(678, 294);
            this.dgvManagement.TabIndex = 1;
            // 
            // btnManageRequestManagement
            // 
            this.btnManageRequestManagement.Location = new System.Drawing.Point(46, 401);
            this.btnManageRequestManagement.Name = "btnManageRequestManagement";
            this.btnManageRequestManagement.Size = new System.Drawing.Size(203, 26);
            this.btnManageRequestManagement.TabIndex = 2;
            this.btnManageRequestManagement.Text = "Manage Request";
            this.btnManageRequestManagement.UseVisualStyleBackColor = true;
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
            // RequestDate
            // 
            this.RequestDate.HeaderText = "RequestDate";
            this.RequestDate.MinimumWidth = 6;
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.Width = 125;
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.HeaderText = "EmployeeFullName";
            this.EmployeeFullName.MinimumWidth = 6;
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.Width = 125;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.Width = 125;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageRequestManagement);
            this.Controls.Add(this.dgvManagement);
            this.Controls.Add(this.label1);
            this.Name = "frmManagement";
            this.Text = "frmManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManagement;
        private System.Windows.Forms.Button btnManageRequestManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
    }
}