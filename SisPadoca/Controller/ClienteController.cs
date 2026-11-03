using MySql.Data.MySqlClient;
using SisPadoca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SisPadoca.Controller
{
    public class ClienteController
    {
        private readonly ClienteDAO _dao = new ClienteDAO();

        public string Salvar(Cliente c)
        {
            if (string.IsNullOrWhiteSpace(c.CPF) || (c.CPF).Length < 11)
                return "Informe um CPF válido (11 dígitos).";

            if (string.IsNullOrWhiteSpace(c.Nome))
                return "Informe o nome do cliente!";            

            if (string.IsNullOrWhiteSpace(c.Cep) || (c.CPF).Length < 8)
                return "Informe o CEP do cliente!";

            if (string.IsNullOrWhiteSpace(c.Celular))
                return "Informe o celular do cliente!";

            if (string.IsNullOrWhiteSpace(c.Email))
                return "Informe o e-mail do cliente!";

            try
            {
                _dao.Inserir(c);
                return null;
            }
            catch (MySqlException ex) when (ex.Number == 1062)   // using MySql.Data.MySqlClient;
            {
                return "Já existe um cliente com este CPF.";
            }
            catch (Exception ex)
            {
                return "Erro ao salvar: " + ex.Message;
            }
        }

        public string Excluir(string cpf)
        {
            try
            {
                _dao.Excluir(cpf);
                return null;
            }
            catch (Exception ex)
            {
                return "Erro ao excluir: " + ex.Message;
            }
        }

        public string Editar(string cpf)
        {
            try
            {
                _dao.AtualizarCliente(cpf);
                return null;
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar: " + ex.Message;
            }
        }

        public DataTable Listar() => _dao.ListarTodos();

        public DataTable Buscar(string nome) => _dao.BuscarPorNome(nome);
    }
}
