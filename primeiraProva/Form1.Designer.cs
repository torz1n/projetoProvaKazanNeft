namespace primeiraProva
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.tituloUserLogin = new System.Windows.Forms.Label();
            this.tituloSenhaLogin = new System.Windows.Forms.Label();
            this.botaoCancelarLogin = new System.Windows.Forms.Button();
            this.botaoConfirmarLogin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(158, 123);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(313, 20);
            this.txtUsuarioLogin.TabIndex = 0;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(158, 197);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(313, 20);
            this.txtSenhaLogin.TabIndex = 1;
            this.txtSenhaLogin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tituloUserLogin
            // 
            this.tituloUserLogin.AutoSize = true;
            this.tituloUserLogin.Location = new System.Drawing.Point(158, 104);
            this.tituloUserLogin.Name = "tituloUserLogin";
            this.tituloUserLogin.Size = new System.Drawing.Size(89, 13);
            this.tituloUserLogin.TabIndex = 2;
            this.tituloUserLogin.Text = "Nome de Usuário";
            // 
            // tituloSenhaLogin
            // 
            this.tituloSenhaLogin.AutoSize = true;
            this.tituloSenhaLogin.Location = new System.Drawing.Point(158, 181);
            this.tituloSenhaLogin.Name = "tituloSenhaLogin";
            this.tituloSenhaLogin.Size = new System.Drawing.Size(38, 13);
            this.tituloSenhaLogin.TabIndex = 3;
            this.tituloSenhaLogin.Text = "Senha";
            // 
            // botaoCancelarLogin
            // 
            this.botaoCancelarLogin.BackColor = System.Drawing.Color.Red;
            this.botaoCancelarLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoCancelarLogin.Location = new System.Drawing.Point(315, 244);
            this.botaoCancelarLogin.Name = "botaoCancelarLogin";
            this.botaoCancelarLogin.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelarLogin.TabIndex = 4;
            this.botaoCancelarLogin.Text = "Cancelar";
            this.botaoCancelarLogin.UseVisualStyleBackColor = false;
            // 
            // botaoConfirmarLogin
            // 
            this.botaoConfirmarLogin.Location = new System.Drawing.Point(224, 244);
            this.botaoConfirmarLogin.Name = "botaoConfirmarLogin";
            this.botaoConfirmarLogin.Size = new System.Drawing.Size(75, 23);
            this.botaoConfirmarLogin.TabIndex = 5;
            this.botaoConfirmarLogin.Text = "Confirmar";
            this.botaoConfirmarLogin.UseVisualStyleBackColor = true;
            this.botaoConfirmarLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 343);
            this.Controls.Add(this.botaoConfirmarLogin);
            this.Controls.Add(this.botaoCancelarLogin);
            this.Controls.Add(this.tituloSenhaLogin);
            this.Controls.Add(this.tituloUserLogin);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Label tituloUserLogin;
        private System.Windows.Forms.Label tituloSenhaLogin;
        private System.Windows.Forms.Button botaoCancelarLogin;
        private System.Windows.Forms.Button botaoConfirmarLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

