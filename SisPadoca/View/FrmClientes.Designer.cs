namespace SisPadoca.View
{
    partial class FrmClientes
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
            BtnFechar = new Button();
            BtnExcluir = new Button();
            BtnNovo = new Button();
            TxbNome = new TextBox();
            LblEmail = new Label();
            MtbCelular = new MaskedTextBox();
            LblCelular = new Label();
            LblEstado = new Label();
            lblCidade = new Label();
            MtbCEP = new MaskedTextBox();
            CmbEstado = new ComboBox();
            DtpDataNasc = new DateTimePicker();
            CmbSexo = new ComboBox();
            TxbEmail = new TextBox();
            LblCEP = new Label();
            LblDataNasc = new Label();
            LblSexo = new Label();
            LblNome = new Label();
            MtbCPF = new MaskedTextBox();
            LblCPF = new Label();
            BtnEditar = new Button();
            TxbCidade = new TextBox();
            dgvClientes = new DataGridView();
            TxbBusca = new TextBox();
            LblBusca = new Label();
            BtnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // BtnFechar
            // 
            BtnFechar.Font = new Font("Tahoma", 12F);
            BtnFechar.Location = new Point(432, 382);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(100, 50);
            BtnFechar.TabIndex = 12;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Font = new Font("Tahoma", 12F);
            BtnExcluir.Location = new Point(432, 447);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(100, 50);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Font = new Font("Tahoma", 12F);
            BtnNovo.Location = new Point(45, 382);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(100, 50);
            BtnNovo.TabIndex = 9;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // TxbNome
            // 
            TxbNome.Font = new Font("Tahoma", 12F);
            TxbNome.Location = new Point(216, 83);
            TxbNome.Name = "TxbNome";
            TxbNome.Size = new Size(316, 27);
            TxbNome.TabIndex = 1;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Tahoma", 12F);
            LblEmail.Location = new Point(45, 225);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(54, 19);
            LblEmail.TabIndex = 80;
            LblEmail.Text = "E-mail";
            // 
            // MtbCelular
            // 
            MtbCelular.Font = new Font("Tahoma", 12F);
            MtbCelular.Location = new Point(384, 167);
            MtbCelular.Mask = "(00) 00000-0000";
            MtbCelular.Name = "MtbCelular";
            MtbCelular.Size = new Size(148, 27);
            MtbCelular.TabIndex = 4;
            MtbCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblCelular
            // 
            LblCelular.AutoSize = true;
            LblCelular.Font = new Font("Tahoma", 12F);
            LblCelular.Location = new Point(384, 139);
            LblCelular.Name = "LblCelular";
            LblCelular.Size = new Size(58, 19);
            LblCelular.TabIndex = 79;
            LblCelular.Text = "Celular";
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Font = new Font("Tahoma", 12F);
            LblEstado.Location = new Point(47, 295);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(56, 19);
            LblEstado.TabIndex = 78;
            LblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Tahoma", 12F);
            lblCidade.Location = new Point(216, 295);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(57, 19);
            lblCidade.TabIndex = 77;
            lblCidade.Text = "Cidade";
            // 
            // MtbCEP
            // 
            MtbCEP.Font = new Font("Tahoma", 12F);
            MtbCEP.Location = new Point(384, 253);
            MtbCEP.Mask = "00000-000";
            MtbCEP.Name = "MtbCEP";
            MtbCEP.Size = new Size(148, 27);
            MtbCEP.TabIndex = 6;
            MtbCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // CmbEstado
            // 
            CmbEstado.Font = new Font("Tahoma", 12F);
            CmbEstado.FormattingEnabled = true;
            CmbEstado.Location = new Point(45, 326);
            CmbEstado.Name = "CmbEstado";
            CmbEstado.Size = new Size(151, 27);
            CmbEstado.TabIndex = 7;
            // 
            // DtpDataNasc
            // 
            DtpDataNasc.Font = new Font("Tahoma", 12F);
            DtpDataNasc.Format = DateTimePickerFormat.Short;
            DtpDataNasc.Location = new Point(216, 167);
            DtpDataNasc.Name = "DtpDataNasc";
            DtpDataNasc.Size = new Size(148, 27);
            DtpDataNasc.TabIndex = 3;
            DtpDataNasc.Value = new DateTime(2026, 9, 15, 20, 30, 46, 0);
            // 
            // CmbSexo
            // 
            CmbSexo.Font = new Font("Tahoma", 12F);
            CmbSexo.FormattingEnabled = true;
            CmbSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            CmbSexo.Location = new Point(48, 167);
            CmbSexo.Name = "CmbSexo";
            CmbSexo.Size = new Size(148, 27);
            CmbSexo.TabIndex = 2;
            CmbSexo.Tag = "sexo";
            // 
            // TxbEmail
            // 
            TxbEmail.Font = new Font("Tahoma", 12F);
            TxbEmail.Location = new Point(45, 253);
            TxbEmail.Name = "TxbEmail";
            TxbEmail.Size = new Size(319, 27);
            TxbEmail.TabIndex = 5;
            // 
            // LblCEP
            // 
            LblCEP.AutoSize = true;
            LblCEP.Font = new Font("Tahoma", 12F);
            LblCEP.Location = new Point(384, 226);
            LblCEP.Name = "LblCEP";
            LblCEP.Size = new Size(37, 19);
            LblCEP.TabIndex = 63;
            LblCEP.Text = "CEP";
            // 
            // LblDataNasc
            // 
            LblDataNasc.AutoSize = true;
            LblDataNasc.Font = new Font("Tahoma", 12F);
            LblDataNasc.Location = new Point(216, 139);
            LblDataNasc.Name = "LblDataNasc";
            LblDataNasc.Size = new Size(148, 19);
            LblDataNasc.TabIndex = 60;
            LblDataNasc.Text = "Data de nascimento";
            // 
            // LblSexo
            // 
            LblSexo.AutoSize = true;
            LblSexo.Font = new Font("Tahoma", 12F);
            LblSexo.Location = new Point(48, 136);
            LblSexo.Name = "LblSexo";
            LblSexo.Size = new Size(43, 19);
            LblSexo.TabIndex = 58;
            LblSexo.Text = "Sexo";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Tahoma", 12F);
            LblNome.Location = new Point(192, 52);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(51, 19);
            LblNome.TabIndex = 56;
            LblNome.Text = "Nome";
            // 
            // MtbCPF
            // 
            MtbCPF.Font = new Font("Tahoma", 12F);
            MtbCPF.Location = new Point(48, 83);
            MtbCPF.Mask = "000\\.000\\.000\\-00";
            MtbCPF.Name = "MtbCPF";
            MtbCPF.Size = new Size(148, 27);
            MtbCPF.TabIndex = 0;
            MtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Font = new Font("Tahoma", 12F);
            LblCPF.Location = new Point(48, 52);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(36, 19);
            LblCPF.TabIndex = 53;
            LblCPF.Text = "CPF";
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Tahoma", 12F);
            BtnEditar.Location = new Point(162, 382);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(100, 50);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += btnSalvar_Click;
            // 
            // TxbCidade
            // 
            TxbCidade.Font = new Font("Tahoma", 12F);
            TxbCidade.Location = new Point(216, 326);
            TxbCidade.Name = "TxbCidade";
            TxbCidade.Size = new Size(316, 27);
            TxbCidade.TabIndex = 8;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(575, 128);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(657, 369);
            dgvClientes.TabIndex = 82;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // TxbBusca
            // 
            TxbBusca.Font = new Font("Tahoma", 12F);
            TxbBusca.Location = new Point(575, 83);
            TxbBusca.Name = "TxbBusca";
            TxbBusca.Size = new Size(479, 27);
            TxbBusca.TabIndex = 83;
            // 
            // LblBusca
            // 
            LblBusca.AutoSize = true;
            LblBusca.Font = new Font("Tahoma", 12F);
            LblBusca.Location = new Point(575, 52);
            LblBusca.Name = "LblBusca";
            LblBusca.Size = new Size(49, 19);
            LblBusca.TabIndex = 84;
            LblBusca.Text = "Busca";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new Font("Tahoma", 12F);
            BtnSalvar.Location = new Point(279, 382);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(100, 50);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += btnSalvar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1244, 499);
            Controls.Add(BtnSalvar);
            Controls.Add(LblBusca);
            Controls.Add(TxbBusca);
            Controls.Add(dgvClientes);
            Controls.Add(BtnFechar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnNovo);
            Controls.Add(TxbNome);
            Controls.Add(LblEmail);
            Controls.Add(MtbCelular);
            Controls.Add(LblCelular);
            Controls.Add(LblEstado);
            Controls.Add(lblCidade);
            Controls.Add(MtbCEP);
            Controls.Add(CmbEstado);
            Controls.Add(DtpDataNasc);
            Controls.Add(CmbSexo);
            Controls.Add(TxbEmail);
            Controls.Add(LblCEP);
            Controls.Add(LblDataNasc);
            Controls.Add(LblSexo);
            Controls.Add(LblNome);
            Controls.Add(MtbCPF);
            Controls.Add(LblCPF);
            Controls.Add(BtnEditar);
            Controls.Add(TxbCidade);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            WindowState = FormWindowState.Maximized;
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFechar;
        private Button BtnExcluir;
        private Button BtnNovo;
        private TextBox TxbNome;
        private Label LblEmail;
        private MaskedTextBox MtbCelular;
        private Label LblCelular;
        private Label LblEstado;
        private Label lblCidade;
        private MaskedTextBox MtbCEP;
        private ComboBox CmbEstado;
        private DateTimePicker DtpDataNasc;
        private ComboBox CmbSexo;
        private TextBox TxbEmail;
        private Label LblCEP;
        private Label LblDataNasc;
        private Label LblSexo;
        private Label LblNome;
        private MaskedTextBox MtbCPF;
        private Label LblCPF;
        private Button BtnEditar;
        private TextBox TxbCidade;
        private DataGridView dgvClientes;
        private TextBox TxbBusca;
        private Label LblBusca;
        private Button BtnSalvar;
    }
}