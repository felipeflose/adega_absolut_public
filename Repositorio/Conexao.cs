using System.Data;
using MySql.Data.MySqlClient;

namespace AppWeb.Repositorio
{
    public class Conexao : IConexao
    {
        public IDbConnection AbrirConexao()
        {
           using(MySqlConnection conn = new MySqlConnection("Server=adega.mysql.database.azure.com; Port=3306; Database=adega; Uid=uninove@adega; Pwd='uni9@2020';"))
           {
               conn.Open();
               return conn;
           }
        }
    }
}