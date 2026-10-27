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
                DataNasc = Convert.ToDateTime(DtpDataNasc.Text.Trim()),                
                Celular = MtbCelular.Text,
                Email = TxbEmail.Text.Trim(),
                Cep = MtbCEP.Text.Trim(),
                Endereco = TxbEndereco.Text.Trim(),
                Bairro = TxbBairro.Text.Trim(),
                Cidade = TxbCidade.Text.Trim(),
                Estado = CmbEstado.Text.Trim(),
                Observacoes = TxbObservacoes.Text.Trim()
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
            BtnCancelar.Enabled = true;
            BtnCancelar.Text = "Salvar";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // teste
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
