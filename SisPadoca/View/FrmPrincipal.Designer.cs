namespace SisPadoca
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            movimentaçõesToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            contasToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem1 = new ToolStripMenuItem();
            vendasToolStripMenuItem1 = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            blocoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            navegadorToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            vídeosToolStripMenuItem = new ToolStripMenuItem();
            tutoriaisToolStripMenuItem = new ToolStripMenuItem();
            suporteToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairDoSistemaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            TssDataHora = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, movimentaçõesToolStripMenuItem, relatóriosToolStripMenuItem, ferramentasToolStripMenuItem, ajudaToolStripMenuItem, sairDoSistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, fornecedoresToolStripMenuItem, funcionáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(145, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(145, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(145, 22);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estoqueToolStripMenuItem, vendasToolStripMenuItem, contasToolStripMenuItem });
            movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            movimentaçõesToolStripMenuItem.Size = new Size(104, 20);
            movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(116, 22);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(116, 22);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // contasToolStripMenuItem
            // 
            contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            contasToolStripMenuItem.Size = new Size(116, 22);
            contasToolStripMenuItem.Text = "Contas";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem1, produtosToolStripMenuItem1, fornecedoresToolStripMenuItem1, vendasToolStripMenuItem1 });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(145, 22);
            clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.Size = new Size(145, 22);
            produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // fornecedoresToolStripMenuItem1
            // 
            fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            fornecedoresToolStripMenuItem1.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            // 
            // vendasToolStripMenuItem1
            // 
            vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            vendasToolStripMenuItem1.Size = new Size(145, 22);
            vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, blocoDeNotasToolStripMenuItem, navegadorToolStripMenuItem });
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(152, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            blocoDeNotasToolStripMenuItem.Size = new Size(152, 22);
            blocoDeNotasToolStripMenuItem.Text = "Bloco de notas";
            // 
            // navegadorToolStripMenuItem
            // 
            navegadorToolStripMenuItem.Name = "navegadorToolStripMenuItem";
            navegadorToolStripMenuItem.Size = new Size(152, 22);
            navegadorToolStripMenuItem.Text = "Navegador";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vídeosToolStripMenuItem, tutoriaisToolStripMenuItem, suporteToolStripMenuItem, sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // vídeosToolStripMenuItem
            // 
            vídeosToolStripMenuItem.Name = "vídeosToolStripMenuItem";
            vídeosToolStripMenuItem.Size = new Size(120, 22);
            vídeosToolStripMenuItem.Text = "Vídeos";
            // 
            // tutoriaisToolStripMenuItem
            // 
            tutoriaisToolStripMenuItem.Name = "tutoriaisToolStripMenuItem";
            tutoriaisToolStripMenuItem.Size = new Size(120, 22);
            tutoriaisToolStripMenuItem.Text = "Tutoriais";
            // 
            // suporteToolStripMenuItem
            // 
            suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            suporteToolStripMenuItem.Size = new Size(120, 22);
            suporteToolStripMenuItem.Text = "Suporte";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(120, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            sairDoSistemaToolStripMenuItem.Size = new Size(98, 20);
            sairDoSistemaToolStripMenuItem.Text = "Sair do sistema";
            sairDoSistemaToolStripMenuItem.Click += sairDoSistemaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { TssDataHora });
            statusStrip1.Location = new Point(0, 507);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // TssDataHora
            // 
            TssDataHora.Name = "TssDataHora";
            TssDataHora.Size = new Size(118, 17);
            TssDataHora.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 529);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem contasToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private ToolStripMenuItem vendasToolStripMenuItem1;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private ToolStripMenuItem navegadorToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem vídeosToolStripMenuItem;
        private ToolStripMenuItem tutoriaisToolStripMenuItem;
        private ToolStripMenuItem suporteToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel TssDataHora;
        private System.Windows.Forms.Timer timer1;
    }
}
