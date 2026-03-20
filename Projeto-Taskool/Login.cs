using Projeto_Taskool.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Taskool
{
    public partial class Login : Form
    {
        dbTarefasEntities1 banco = new dbTarefasEntities1 ();
        public Login()
        {
            InitializeComponent();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Cadastro().Show();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            var usuario = banco.Usuario.FirstOrDefault(x => x.Email == txtEmail.Text && x.Senha == txtSenha.Text);
            if (usuario == null)
            {
                MessageBox.Show("Dados inválidos");
                return;
            }
            MessageBox.Show("Olá, " + usuario.Nome);
            new TelaUsuario().Show();
        }

        private void linkTeclado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                       
        }
    }
}
