using System.Data;
using MySql.Data.MySqlClient;

namespace UNIVET.Data
{
    public class Conexao
    {
        // senha do mysql!
        private readonly string _stringConexao = "Server=localhost;Database=univet;Uid=root;Pwd=123456789;";

        public IDbConnection ObterConexao()
        {
            return new MySqlConnection(_stringConexao);
        }
    }
}