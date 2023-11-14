namespace vendasProjeto
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            menuStrip1 = new MenuStrip();
            cadastrToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            controleDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            btnCliente = new PictureBox();
            btnPdv = new PictureBox();
            btnProdutos = new PictureBox();
            btnRelatorios = new PictureBox();
            btnFinanceiro = new PictureBox();
            listaEstoque = new PictureBox();
            logoRodape = new PictureBox();
            empresa = new Label();
            usuario = new Label();
            Suporte = new Label();
            nomeEmpresa = new Label();
            nomeUsuario = new Label();
            numeroSuporte = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRelatorios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFinanceiro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoRodape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrToolStripMenuItem, vendasToolStripMenuItem, controleDeEstoqueToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // cadastrToolStripMenuItem
            // 
            cadastrToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, fornecedoresToolStripMenuItem, clientesToolStripMenuItem });
            resources.ApplyResources(cadastrToolStripMenuItem, "cadastrToolStripMenuItem");
            cadastrToolStripMenuItem.Name = "cadastrToolStripMenuItem";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            resources.ApplyResources(produtosToolStripMenuItem, "produtosToolStripMenuItem");
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            resources.ApplyResources(fornecedoresToolStripMenuItem, "fornecedoresToolStripMenuItem");
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            resources.ApplyResources(clientesToolStripMenuItem, "clientesToolStripMenuItem");
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            resources.ApplyResources(vendasToolStripMenuItem, "vendasToolStripMenuItem");
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            resources.ApplyResources(controleDeEstoqueToolStripMenuItem, "controleDeEstoqueToolStripMenuItem");
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            resources.ApplyResources(relatóriosToolStripMenuItem, "relatóriosToolStripMenuItem");
            // 
            // btnCliente
            // 
            btnCliente.Image = Properties.Resources.Clientes;
            resources.ApplyResources(btnCliente, "btnCliente");
            btnCliente.Name = "btnCliente";
            btnCliente.TabStop = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnPdv
            // 
            btnPdv.Image = Properties.Resources.PDV;
            resources.ApplyResources(btnPdv, "btnPdv");
            btnPdv.Name = "btnPdv";
            btnPdv.TabStop = false;
            btnPdv.Click += btnPdv_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Image = Properties.Resources.Produtos;
            resources.ApplyResources(btnProdutos, "btnProdutos");
            btnProdutos.Name = "btnProdutos";
            btnProdutos.TabStop = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.Image = Properties.Resources.Relatorios;
            resources.ApplyResources(btnRelatorios, "btnRelatorios");
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.TabStop = false;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnFinanceiro
            // 
            btnFinanceiro.Image = Properties.Resources.Financeiro;
            resources.ApplyResources(btnFinanceiro, "btnFinanceiro");
            btnFinanceiro.Name = "btnFinanceiro";
            btnFinanceiro.TabStop = false;
            btnFinanceiro.Click += btnFinanceiro_Click;
            // 
            // listaEstoque
            // 
            resources.ApplyResources(listaEstoque, "listaEstoque");
            listaEstoque.Image = Properties.Resources.Tabelaprodutos;
            listaEstoque.Name = "listaEstoque";
            listaEstoque.TabStop = false;
            listaEstoque.Click += listaEstoque_Click;
            // 
            // logoRodape
            // 
            resources.ApplyResources(logoRodape, "logoRodape");
            logoRodape.Image = Properties.Resources.Logo_sistema;
            logoRodape.Name = "logoRodape";
            logoRodape.TabStop = false;
            // 
            // empresa
            // 
            resources.ApplyResources(empresa, "empresa");
            empresa.Name = "empresa";
            // 
            // usuario
            // 
            resources.ApplyResources(usuario, "usuario");
            usuario.Name = "usuario";
            // 
            // Suporte
            // 
            resources.ApplyResources(Suporte, "Suporte");
            Suporte.Name = "Suporte";
            // 
            // nomeEmpresa
            // 
            resources.ApplyResources(nomeEmpresa, "nomeEmpresa");
            nomeEmpresa.Name = "nomeEmpresa";
            // 
            // nomeUsuario
            // 
            resources.ApplyResources(nomeUsuario, "nomeUsuario");
            nomeUsuario.Name = "nomeUsuario";
            // 
            // numeroSuporte
            // 
            resources.ApplyResources(numeroSuporte, "numeroSuporte");
            numeroSuporte.Name = "numeroSuporte";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.whats;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // TelaInicial
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            Controls.Add(pictureBox1);
            Controls.Add(numeroSuporte);
            Controls.Add(nomeUsuario);
            Controls.Add(nomeEmpresa);
            Controls.Add(Suporte);
            Controls.Add(usuario);
            Controls.Add(empresa);
            Controls.Add(logoRodape);
            Controls.Add(listaEstoque);
            Controls.Add(btnFinanceiro);
            Controls.Add(btnRelatorios);
            Controls.Add(btnProdutos);
            Controls.Add(btnPdv);
            Controls.Add(btnCliente);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "TelaInicial";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRelatorios).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFinanceiro).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoRodape).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private PictureBox btnCliente;
        private PictureBox btnPdv;
        private PictureBox btnProdutos;
        private PictureBox btnRelatorios;
        private PictureBox btnFinanceiro;
        private PictureBox listaEstoque;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private PictureBox logoRodape;
        private Label empresa;
        private Label usuario;
        private Label Suporte;
        private Label nomeEmpresa;
        private Label nomeUsuario;
        private Label numeroSuporte;
        private PictureBox pictureBox1;
    }
}