using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginSql
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            //Comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from Cliente where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String login)
        {
            //Comandos para inserir
            return mensagem;
        }

    }
}
