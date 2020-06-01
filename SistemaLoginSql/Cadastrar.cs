using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaLoginSql
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Preencher todos os campos");
            }
            else
            {
                Cadastro cad = new Cadastro(txtNome.Text, txtSenha.Text, txtEmail.Text);
                var login = new Login();
                login.Show();
                Hide();
            }
        }
    }
}
