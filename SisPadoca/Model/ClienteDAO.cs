using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace SisPadoca.Model
{
    public class ClienteDAO
    {
        private readonly Conexao _db = new Conexao();

        public int Inserir(Cliente c)
        {
            const string sql =
                "INSERT INTO clientes (cpf, nome, sexo, data_nasc, celular, " +
                "email, cep, endereco, bairro, cidade, estado, observacoes) VALUES" +
                " (@cpf, @nome, @sexo, @data_nasc, @celular, @email, @cep, " +
                "@endereco, @bairro, @cidade, @estado, @observacoes)";
            return _db.Executar(sql,
                new MySqlParameter("@cpf", c.CPF),
                new MySqlParameter("@nome", c.Nome),
                new MySqlParameter("@sexo", c.Sexo),
                new MySqlParameter("@data_nasc", c.DataNasc),
                new MySqlParameter("@celular", c.Celular),
                new MySqlParameter("@email", c.Email),
                new MySqlParameter("@cep", c.Cep),
                new MySqlParameter("@endereco", c.Endereco),
                new MySqlParameter("@bairro", c.Bairro),
                new MySqlParameter("@cidade", c.Cidade),
                new MySqlParameter("@estado", c.Estado),
                new MySqlParameter("@observacoes", c.Observacoes));
        }

        public DataTable ListarTodos()
        {
            return _db.Consultar("SELECT cpf, nome, cep, celular, email FROM clientes ORDER BY nome");
        }
    }
}
        

