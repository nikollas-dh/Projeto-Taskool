using Projeto_Taskool.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Taskool
{
    public partial class Cadastro : Form
    {
        dbTarefasEntities1 banco = new dbTarefasEntities1 ();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == ""|| txtNovaSenha.Text == ""|| txtEmail.Text =="" || txtConfirmarSenha.Text == ""|| txtNovaSenha.Text == "" || txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else if (txtConfirmarSenha.Text != txtNovaSenha.Text){
                MessageBox.Show("As senhas não são iguais!");
                return;
            }
            string emailFormatado = ValidarEmail();

            Usuario usuario = new Usuario()
            {
                Nome = txtNome.Text,
                Email = emailFormatado,
                Senha = txtNovaSenha.Text,
                Usuario1 = txtUsuario.Text,
                Telefone = txtTelefone.Text,
                Foto = new byte[0]
            };

            banco.Usuario.Add(usuario);
            banco.SaveChanges();

            MessageBox.Show("Usuário criado com sucesso");
            new Login().Show();
        }

        private string ValidarEmail(string emailFormatado)
        {
            return emailFormatado;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
