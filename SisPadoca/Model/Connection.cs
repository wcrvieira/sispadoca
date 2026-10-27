using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace SisPadoca.Model
{
    public class Conexao
    {
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["MySql"].ConnectionString;

        // Cria uma conexão nova (o pool de conexões do ADO.NET cuida do reaproveitamento)
        public MySqlConnection CriarConexao()
        {
            return new MySqlConnection(_connectionString);
        }

        // Testa se a conexão funciona
        public bool Testar(out string erro)
        {
            try // Executar, se verdadeiro
            {
                using (var conn = CriarConexao())
                {
                    conn.Open();
                    erro = null;
                    return true;
                }
            }
            catch (MySqlException ex) // Se der erro, armazena a descrição
            {
                erro = ex.Message;
                return false;
            }
        }

        // SELECT -> DataTable
        public DataTable Consultar(string sql, params MySqlParameter[] parametros)
        {
            using (var conn = CriarConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                if (parametros != null) cmd.Parameters.AddRange(parametros);
                var dt = new DataTable();
                da.Fill(dt); // abre e fecha a conexão sozinho
                return dt;
            }
        }

        // INSERT / UPDATE / DELETE -> retorna linhas afetadas
        public int Executar(string sql, params MySqlParameter[] parametros)
        {
            using (var conn = CriarConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parametros != null) cmd.Parameters.AddRange(parametros);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Retorna um único valor (COUNT, MAX, LAST_INSERT_ID etc.)
        public object ExecutarEscalar(string sql, params MySqlParameter[] parametros)
        {
            using (var conn = CriarConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parametros != null) cmd.Parameters.AddRange(parametros);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}