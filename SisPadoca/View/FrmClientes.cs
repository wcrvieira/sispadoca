using MySql.Data.MySqlClient;
using SisPadoca.Controller;
using SisPadoca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisPadoca.View
{
    public partial class FrmClientes : Form
    {
        private readonly ClienteController _controller = new ClienteController();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            string erro;
            if (!new Conexao().Testar(out erro))
            {
                MessageBox.Show("Falha na conexão:\n" + erro, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dgvClientes.DataSource = _controller.Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente()
            {
                CPF = MtbCPF.Text.Trim(),
                Nome = TxbNome.Text.Trim(),
                Sexo = CmbSexo.Text.Trim(),
                Data_Nasc = Convert.ToDateTime(DtpDataNasc.Text.Trim()),
                Celular = MtbCelular.Text,
                Email = TxbEmail.Text.Trim(),
                Cep = MtbCEP.Text.Trim(),                
                Cidade = TxbCidade.Text.Trim(),
                Estado = CmbEstado.Text.Trim()
            };

            string erro = _controller.Salvar(cliente);

            if (erro != null)
            {
                MessageBox.Show(erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CarregarGrid();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // teste
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox or ComboBox
                    or DateTimePicker or MaskedTextBox)
                {
                    ctrl.Enabled = true;
                }
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox or ComboBox
                    or DateTimePicker or MaskedTextBox)
                {
                    ctrl.Text = null;
                }
            }

            MtbCPF.Focus();
            BtnExcluir.Enabled = false;
            BtnEditar.Enabled = false;
            BtnSalvar.Enabled = true;            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MtbCPF.Text)) return;

            if (MessageBox.Show("Excluir este cliente?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            string erro = _controller.Excluir(MtbCPF.Text);
            if (erro != null)
            {
                MessageBox.Show(erro);
                return;
            }

            CarregarGrid();
            //LimparCampos();

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var linha = dgvClientes.Rows[e.RowIndex];

            if (linha != null)
            {
                MtbCPF.Text = linha.Cells["cpf"].Value?.ToString() ?? "";
                TxbNome.Text = linha.Cells["nome"].Value?.ToString() ?? "";
                CmbSexo.SelectedItem = linha.Cells["sexo"].Value?.ToString();

                if (linha.Cells["data_nasc"].Value != null && linha.Cells["data_nasc"].Value != DBNull.Value)
                    DtpDataNasc.Value = Convert.ToDateTime(linha.Cells["data_nasc"].Value);

                MtbCelular.Text = linha.Cells["celular"].Value?.ToString() ?? "";
                TxbEmail.Text = linha.Cells["email"].Value?.ToString() ?? "";
                MtbCEP.Text = linha.Cells["cep"].Value?.ToString() ?? "";
                TxbCidade.Text = linha.Cells["cidade"].Value?.ToString() ?? "";
                CmbEstado.Text = linha.Cells["estado"].Value?.ToString() ?? "";                
            }
        }
    }
}
