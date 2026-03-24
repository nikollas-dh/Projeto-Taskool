using Projeto_Taskool.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

           
            //if (Control.IsKeyLocked(Keys.CapsLock))
            //{
            //    lblCaps.Visible = true;
            //}
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
            

            if (usuario.Foto != null && usuario.Foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(usuario.Foto))
                {
                    pbxFoto.Image = Image.FromStream(ms);
                }
            }

            MessageBox.Show("Olá, " + usuario.Nome);
            new TelaUsuario(usuario).Show();
        }

        private void linkTeclado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("C:\\WINDOWS\\system32\\osk.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o teclado virtual: " + ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lblCaps.Visible = true;
            }
            else {
                lblCaps.Visible = false;

            }
        }
    }
}
