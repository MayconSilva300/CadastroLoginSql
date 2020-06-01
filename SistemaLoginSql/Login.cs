using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaLoginSql
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void imgLogin_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(boxNome.Text, boxSenha.Text);

            if (controle.tem) { MessageBox.Show("Logado com sucesso", "Entrendo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else { MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


        private void txtCadastrar_MouseEnter(object sender, EventArgs e)
        {
            txtCadastrar.ForeColor = Color.White;
        }

        private void imgFundoLogin_MouseEnter(object sender, EventArgs e)
        {
            txtCadastrar.ForeColor = Color.Silver;
        }

        private void txtCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrar = new Cadastrar();
            cadastrar.Show();
        }
    }
}
