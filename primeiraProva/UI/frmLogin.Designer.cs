namespace primeiraProva.UI
{
    partial class frmLogin
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
            this.btnOkLogin = new System.Windows.Forms.Button();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.z);
            this.panel1.Controls.Add(this.txtUserLogin);
            this.panel1.Controls.Add(this.btnCancelLogin);
            this.panel1.Controls.Add(this.btnOkLogin);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            // 
            // btnOkLogin
            // 
            this.btnOkLogin.Location = new System.Drawing.Point(291, 395);
            this.btnOkLogin.Name = "btnOkLogin";
            this.btnOkLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOkLogin.Size = new System.Drawing.Size(75, 23);
            this.btnOkLogin.TabIndex = 0;
            this.btnOkLogin.Text = "Ok";
            this.btnOkLogin.UseVisualStyleBackColor = true;
            this.btnOkLogin.Click += new System.EventHandler(this.btnOkLogin_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Location = new System.Drawing.Point(436, 395);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLogin.TabIndex = 1;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Location = new System.Drawing.Point(242, 221);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(310, 22);
            this.txtUserLogin.TabIndex = 2;
            // 
            // z
            // 
            this.z.Location = new System.Drawing.Point(242, 290);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(310, 22);
            this.z.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox z;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnOkLogin;
    }
}