namespace SistemaLoginSql
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.imgFundoLogin = new System.Windows.Forms.PictureBox();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.boxSenha = new System.Windows.Forms.TextBox();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.txtCadastrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundoLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFundoLogin
            // 
            this.imgFundoLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFundoLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgFundoLogin.Image")));
            this.imgFundoLogin.Location = new System.Drawing.Point(0, 0);
            this.imgFundoLogin.Name = "imgFundoLogin";
            this.imgFundoLogin.Size = new System.Drawing.Size(623, 580);
            this.imgFundoLogin.TabIndex = 8;
            this.imgFundoLogin.TabStop = false;
            this.imgFundoLogin.MouseEnter += new System.EventHandler(this.imgFundoLogin_MouseEnter);
            // 
            // boxNome
            // 
            this.boxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.boxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.boxNome.Location = new System.Drawing.Point(172, 296);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(311, 19);
            this.boxNome.TabIndex = 9;
            // 
            // boxSenha
            // 
            this.boxSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.boxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSenha.Location = new System.Drawing.Point(172, 365);
            this.boxSenha.Name = "boxSenha";
            this.boxSenha.PasswordChar = '*';
            this.boxSenha.Size = new System.Drawing.Size(311, 19);
            this.boxSenha.TabIndex = 10;
            // 
            // imgLogin
            // 
            this.imgLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogin.Image")));
            this.imgLogin.Location = new System.Drawing.Point(212, 459);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(202, 51);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin.TabIndex = 11;
            this.imgLogin.TabStop = false;
            this.imgLogin.Click += new System.EventHandler(this.imgLogin_Click);
            // 
            // txtCadastrar
            // 
            this.txtCadastrar.AutoSize = true;
            this.txtCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.txtCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrar.ForeColor = System.Drawing.Color.Silver;
            this.txtCadastrar.Location = new System.Drawing.Point(387, 420);
            this.txtCadastrar.Name = "txtCadastrar";
            this.txtCadastrar.Size = new System.Drawing.Size(116, 15);
            this.txtCadastrar.TabIndex = 12;
            this.txtCadastrar.Text = "Cadastre-se aqui";
            this.txtCadastrar.Click += new System.EventHandler(this.txtCadastrar_Click);
            this.txtCadastrar.MouseEnter += new System.EventHandler(this.txtCadastrar_MouseEnter);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 580);
            this.Controls.Add(this.txtCadastrar);
            this.Controls.Add(this.imgLogin);
            this.Controls.Add(this.boxSenha);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.imgFundoLogin);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgFundoLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFundoLogin;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.TextBox boxSenha;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.Label txtCadastrar;
    }
}

