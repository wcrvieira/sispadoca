using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

namespace SisPadoca.Model
{
    public class ClienteDAO
    {
        private readonly Conexao _db = new Conexao();

        public int Inserir(Cliente c)
        {
            const string sql =
                "INSERT INTO clientes (cpf, nome, sexo, data_nasc, celular, " +
                "email, cep, cidade, estado) VALUES" +
                " (@cpf, @nome, @sexo, @data_nasc, @celular, @email, @cep, " +
                "@cidade, @estado)";
            return _db.Executar(sql,
                new MySqlParameter("@cpf", c.CPF),
                new MySqlParameter("@nome", c.Nome),
                new MySqlParameter("@sexo", c.Sexo),
                new MySqlParameter("@data_nasc", c.Data_Nasc),
                new MySqlParameter("@celular", c.Celular),
                new MySqlParameter("@email", c.Email),
                new MySqlParameter("@cep", c.Cep),
                new MySqlParameter("@cidade", c.Cidade),
                new MySqlParameter("@estado", c.Estado));                
        }

        public int AtualizarCliente(Cliente c)
        {
            const string sql =
                "UPDATE clientes SET nome=@nome, email=@email, celular=@celular WHERE" +
                "cpf=@cpf";

                return _db.Executar(sql,
                    new MySqlParameter("@nome", c.Nome),
                    new MySqlParameter("@email", c.Email),
                    new MySqlParameter("@celular", c.Celular),
                    new MySqlParameter("@cpf", c.CPF));
        }

        public int Excluir(string cpf)
        {
            return _db.Executar(
                "DELETE FROM clientes WHERE cpf=@cpf", 
                new MySqlParameter("@cpf", cpf));
        }

        public DataTable ListarTodos()
        {
            return _db.Consultar("SELECT cpf, nome, sexo, data_nasc, celular, email," +
                "               cep, estado, cidade FROM clientes ORDER BY nome");
        }

        public DataTable BuscarPorNome(string nome)
        {
            return _db.Consultar(
                "SELECT cpf, nome, sexo, email, telefone FROM clientes WHERE" +
                "nome LIKE @nome", new MySqlParameter("@nome", "%" + nome + "%"));
        }

        internal void AtualizarCliente(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
        

