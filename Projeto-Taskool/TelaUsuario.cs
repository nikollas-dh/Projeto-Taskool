using Projeto_Taskool.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Taskool
{
    public partial class TelaUsuario : Form
    {
        dbTarefasEntities1 banco = new dbTarefasEntities1();
        Usuario usuarioLogado;

        public TelaUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("HH:mm");

            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                lblMensagem.Text = "Boa tarde, " + usuarioLogado.Usuario1;
            }
            else if (DateTime.Now.Hour >= 18)
            {
                lblMensagem.Text = "Boa noite, " + usuarioLogado.Usuario1;
            }
            else if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 4)
            {
                lblMensagem.Text = "Boa Madrugada, " + usuarioLogado.Usuario1;
            }
           else if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 12)
            {
                lblMensagem.Text = "Good Dia, " + usuarioLogado.Usuario1;
            }   

            if (usuarioLogado.Foto != null && usuarioLogado.Foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(usuarioLogado.Foto))
                {
                    pbxFoto.Image = Image.FromStream(ms);
                }
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("T");
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                lblMensagem.Text = "Boa tarde, " + usuarioLogado.Usuario1;
            }
            else if (DateTime.Now.Hour >= 18)
            {
                lblMensagem.Text = "Boa noite, " + usuarioLogado.Usuario1;
            }
            else if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 4)
            {
                lblMensagem.Text = "Boa Madrugada, " + usuarioLogado.Usuario1;
            }
           else if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 12)
            {
                lblMensagem.Text = "Good Dia, " + usuarioLogado.Usuario1;
            }
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <18)
            {
                lblMensagem.Text = "Good Afternoon, "+usuarioLogado.Usuario1;
            }
            else if (DateTime.Now.Hour >= 18)
            {
                lblMensagem.Text = "Good Evening, " + usuarioLogado.Usuario1;
            }
           else if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour <4)
            {
                lblMensagem.Text = "Good sun-up, " + usuarioLogado.Usuario1;
            }
           else if (DateTime.Now.Hour  >=4 && DateTime.Now.Hour <12)
            {
                lblMensagem.Text = "Good Morning, " + usuarioLogado.Usuario1;
            }
            
        }

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            caixa.Visible = true;
        }

        private void caixa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
