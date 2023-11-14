namespace vendasProjeto
{
    partial class TelaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
            pictureBox1 = new PictureBox();
            numeroSuporte = new Label();
            nomeUsuario = new Label();
            nomeEmpresa = new Label();
            Suporte = new Label();
            usuario = new Label();
            empresa = new Label();
            logoRodape = new PictureBox();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            controleDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            button5 = new Button();
            button6 = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoRodape).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.whats;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(193, 927);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 29);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // numeroSuporte
            // 
            numeroSuporte.AutoSize = true;
            numeroSuporte.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numeroSuporte.ImeMode = ImeMode.NoControl;
            numeroSuporte.Location = new Point(233, 918);
            numeroSuporte.Name = "numeroSuporte";
            numeroSuporte.Size = new Size(294, 38);
            numeroSuporte.TabIndex = 21;
            numeroSuporte.Text = "Numero do suporte";
            // 
            // nomeUsuario
            // 
            nomeUsuario.AutoSize = true;
            nomeUsuario.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            nomeUsuario.ImeMode = ImeMode.NoControl;
            nomeUsuario.Location = new Point(193, 863);
            nomeUsuario.Name = "nomeUsuario";
            nomeUsuario.Size = new Size(263, 38);
            nomeUsuario.TabIndex = 20;
            nomeUsuario.Text = "Nome do usuário";
            // 
            // nomeEmpresa
            // 
            nomeEmpresa.AutoSize = true;
            nomeEmpresa.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point);
            nomeEmpresa.ImeMode = ImeMode.NoControl;
            nomeEmpresa.Location = new Point(271, 790);
            nomeEmpresa.Name = "nomeEmpresa";
            nomeEmpresa.Size = new Size(417, 58);
            nomeEmpresa.TabIndex = 19;
            nomeEmpresa.Text = "Nome da empresa";
            // 
            // Suporte
            // 
            Suporte.AutoSize = true;
            Suporte.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Suporte.ImeMode = ImeMode.NoControl;
            Suporte.Location = new Point(50, 918);
            Suporte.Name = "Suporte";
            Suporte.Size = new Size(138, 38);
            Suporte.TabIndex = 18;
            Suporte.Text = "Suporte:";
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            usuario.ImeMode = ImeMode.NoControl;
            usuario.Location = new Point(50, 863);
            usuario.Name = "usuario";
            usuario.Size = new Size(137, 38);
            usuario.TabIndex = 17;
            usuario.Text = "Usuário:";
            // 
            // empresa
            // 
            empresa.AutoSize = true;
            empresa.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point);
            empresa.ImeMode = ImeMode.NoControl;
            empresa.Location = new Point(50, 790);
            empresa.Name = "empresa";
            empresa.Size = new Size(225, 58);
            empresa.TabIndex = 16;
            empresa.Text = "Empresa:";
            // 
            // logoRodape
            // 
            logoRodape.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            logoRodape.Image = Properties.Resources.Logo_sistema;
            logoRodape.ImeMode = ImeMode.NoControl;
            logoRodape.Location = new Point(1124, 863);
            logoRodape.Name = "logoRodape";
            logoRodape.Size = new Size(265, 83);
            logoRodape.TabIndex = 15;
            logoRodape.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, vendasToolStripMenuItem, controleDeEstoqueToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1424, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, produtosToolStripMenuItem, fornecedoresToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(145, 22);
            toolStripMenuItem1.Text = "Produtos";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(145, 22);
            produtosToolStripMenuItem.Text = "Fornecedores";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Clientes";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(56, 20);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            controleDeEstoqueToolStripMenuItem.Size = new Size(126, 20);
            controleDeEstoqueToolStripMenuItem.Text = "Controle de estoque";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(50, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 128);
            panel1.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(217, 217, 217);
            button2.Location = new Point(293, 59);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 5;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Location = new Point(293, 19);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.ForeColor = Color.FromArgb(246, 246, 246);
            textBox2.Location = new Point(84, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.ForeColor = Color.FromArgb(246, 246, 246);
            textBox1.Location = new Point(84, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "333.333.333-33";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 0;
            label1.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 51);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 25;
            label3.Text = "Dados do Cliente";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.CarrinhoCompras;
            pictureBox2.Location = new Point(607, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(684, 354);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(50, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 382);
            panel2.TabIndex = 27;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(152, 152, 253);
            button4.ForeColor = Color.FromArgb(246, 246, 246);
            button4.Location = new Point(110, 259);
            button4.Name = "button4";
            button4.Size = new Size(200, 80);
            button4.TabIndex = 8;
            button4.Text = "Adicionar item";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 217, 217);
            button3.Location = new Point(293, 43);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.TabIndex = 6;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(217, 217, 217);
            textBox6.ForeColor = Color.FromArgb(246, 246, 246);
            textBox6.Location = new Point(110, 200);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(217, 217, 217);
            textBox5.ForeColor = Color.FromArgb(246, 246, 246);
            textBox5.Location = new Point(110, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(43, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(217, 217, 217);
            textBox4.ForeColor = Color.FromArgb(246, 246, 246);
            textBox4.Location = new Point(110, 92);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(217, 217, 217);
            textBox3.ForeColor = Color.FromArgb(246, 246, 246);
            textBox3.Location = new Point(110, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 27);
            textBox3.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 208);
            label7.Name = "label7";
            label7.Size = new Size(50, 19);
            label7.TabIndex = 3;
            label7.Text = "Preço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 154);
            label6.Name = "label6";
            label6.Size = new Size(41, 19);
            label6.TabIndex = 2;
            label6.Text = "QTD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 100);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 1;
            label5.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 51);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 0;
            label4.Text = "Código";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(607, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 176);
            panel3.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 15, 255);
            label10.Location = new Point(276, 70);
            label10.Name = "label10";
            label10.Size = new Size(134, 38);
            label10.TabIndex = 30;
            label10.Text = "1895.50";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(58, 54);
            label9.Name = "label9";
            label9.Size = new Size(147, 58);
            label9.TabIndex = 29;
            label9.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(607, 421);
            label8.Name = "label8";
            label8.Size = new Size(115, 19);
            label8.TabIndex = 1;
            label8.Text = "Total da venda";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 15, 255);
            button5.ForeColor = Color.FromArgb(246, 246, 246);
            button5.Location = new Point(712, 642);
            button5.Name = "button5";
            button5.Size = new Size(200, 80);
            button5.TabIndex = 9;
            button5.Text = "Receber";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.ForeColor = Color.FromArgb(246, 246, 246);
            button6.Location = new Point(997, 642);
            button6.Name = "button6";
            button6.Size = new Size(200, 80);
            button6.TabIndex = 29;
            button6.Text = "Cancelar";
            button6.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 216);
            label11.Name = "label11";
            label11.Size = new Size(138, 19);
            label11.TabIndex = 30;
            label11.Text = "Dados do Produto";
            // 
            // TelaVenda
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1424, 985);
            Controls.Add(label11);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(numeroSuporte);
            Controls.Add(nomeUsuario);
            Controls.Add(nomeEmpresa);
            Controls.Add(Suporte);
            Controls.Add(usuario);
            Controls.Add(empresa);
            Controls.Add(logoRodape);
            Controls.Add(menuStrip1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "TelaVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaVenda";
            WindowState = FormWindowState.Maximized;
            Load += TelaVenda_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoRodape).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label numeroSuporte;
        private Label nomeUsuario;
        private Label nomeEmpresa;
        private Label Suporte;
        private Label usuario;
        private Label empresa;
        private PictureBox logoRodape;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private Label label8;
        private Label label10;
        private Label label9;
        private Button button5;
        private Button button6;
        private Label label11;
    }
}