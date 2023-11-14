namespace vendasProjeto
{
    partial class telaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            Logo = new PictureBox();
            nomeEmpresa = new PictureBox();
            usuario = new TextBox();
            senha = new TextBox();
            checkBox1 = new CheckBox();
            BtnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nomeEmpresa).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Logo.Image = Properties.Resources.Logo_sistema;
            Logo.Location = new Point(580, 120);
            Logo.Name = "Logo";
            Logo.Size = new Size(245, 80);
            Logo.SizeMode = PictureBoxSizeMode.CenterImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // nomeEmpresa
            // 
            nomeEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nomeEmpresa.Image = Properties.Resources.Organizações_Tabajara;
            nomeEmpresa.Location = new Point(401, 289);
            nomeEmpresa.Name = "nomeEmpresa";
            nomeEmpresa.Size = new Size(651, 75);
            nomeEmpresa.SizeMode = PictureBoxSizeMode.CenterImage;
            nomeEmpresa.TabIndex = 1;
            nomeEmpresa.TabStop = false;
            // 
            // usuario
            // 
            usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usuario.BackColor = Color.FromArgb(217, 217, 217);
            usuario.CharacterCasing = CharacterCasing.Upper;
            usuario.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point);
            usuario.ForeColor = Color.FromArgb(246, 246, 246);
            usuario.Location = new Point(310, 484);
            usuario.Name = "usuario";
            usuario.PlaceholderText = "Usuário";
            usuario.Size = new Size(820, 36);
            usuario.TabIndex = 2;
            // 
            // senha
            // 
            senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            senha.BackColor = Color.FromArgb(217, 217, 217);
            senha.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point);
            senha.ForeColor = Color.FromArgb(246, 246, 246);
            senha.Location = new Point(310, 568);
            senha.Name = "senha";
            senha.PasswordChar = '*';
            senha.PlaceholderText = "Senha";
            senha.Size = new Size(820, 36);
            senha.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(317, 629);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Lembre-me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnLogin.BackColor = Color.Blue;
            BtnLogin.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(310, 670);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(820, 80);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click_1;
            // 
            // telaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1424, 985);
            Controls.Add(BtnLogin);
            Controls.Add(checkBox1);
            Controls.Add(senha);
            Controls.Add(usuario);
            Controls.Add(nomeEmpresa);
            Controls.Add(Logo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telaLogin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nomeEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private PictureBox nomeEmpresa;
        private TextBox usuario;
        private TextBox senha;
        private CheckBox checkBox1;
        private Button BtnLogin;
    }
}