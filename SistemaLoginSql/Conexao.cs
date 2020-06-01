using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginSql
{
    public class Conexao
    {
        // public static SqlConnection GetConnection()
        // {
        // objeto que recebe a string de conexão
        // SqlConnection connection = new SqlConnection(@"Data Source=NOTEBOOKMAYCON\SQLEXPRESS;Initial Catalog=DBCliente;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        // retorna a conexão com o BD
        //return connection;
        //}

        SqlConnection con = new SqlConnection();

        //Construção da conexão com o banco de dados
        public Conexao()
        {
            con.ConnectionString = @"Data Source=NOTEBOOKMAYCON\SQLEXPRESS;Initial Catalog=DBUsuario;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        //Confere se o banco está fechado e depois conecta com banco de dados
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        //Confere se o banco está aberto e depois desconecta com o banco de dados
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}