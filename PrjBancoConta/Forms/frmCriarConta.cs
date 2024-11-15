using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjBancoConta.Forms
{
    public partial class frmCriarConta : Form
    {
     
        public frmCriarConta()
        {
            InitializeComponent();
        }


        private void frmCriarConta_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
            DateTime dataCriacao = DateTime.Now;

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, digite a mesma senha nas duas caixas.", "Erro de senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Interrompe o cadastro se as senhas não coincidirem
            }

            // Validação: Verificar se o nome de usuário foi preenchido
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de nome de usuário.", "Erro de nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




        }

    }
}
