using Projeto_Taskool.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Projeto_Taskool
{
    public partial class Cadastro : Form
    {
        dbTarefasEntities1 banco = new dbTarefasEntities1();
        OpenFileDialog arquivo = new OpenFileDialog();
        public Cadastro()
        {
            InitializeComponent();
            dtNascimento.Format = DateTimePickerFormat.Custom;
            dtNascimento.CustomFormat = " ";
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtNovaSenha.Text == "" || txtEmail.Text == "" || txtConfirmarSenha.Text == "" || txtNovaSenha.Text == "" || txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            if (txtConfirmarSenha.Text != txtNovaSenha.Text)
            {
                MessageBox.Show("As senhas não são iguais!");
                return;
            }

            if (ValidarEmail() == false)
            {
                return;
            }


            if (ValidarTelefone() == false)
            {
                return;
            }

            Usuario usuario = new Usuario()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text.ToLower(),
                Senha = txtNovaSenha.Text,
                Usuario1 = txtUsuario.Text,
                Telefone = txtTelefone.Text,
                Foto = ConverterImagemParaByte(pbxFoto.Image),
            };

            banco.Usuario.Add(usuario);
            banco.SaveChanges();

            MessageBox.Show("Usuário criado com sucesso");
            new Login().Show();
        }
        private byte[] ConverterImagemParaByte(Image imagem)
        {
            if (imagem == null)
            {
                return new byte[0];
            }

            using (var ms = new MemoryStream())
            {
                imagem.Save(ms, imagem.RawFormat);
                return ms.ToArray();
            }
        }
        private bool ValidarEmail()
        {
            string emailFormatado = txtEmail.Text;
            if (!emailFormatado.Contains("@email.com"))
            {
                MessageBox.Show("Email inválido,não pode estar vazio e deve conter @email.com:");
                return false;
            }
            return true;
        }

        private bool ValidarTelefone()
        {
            string telefone = txtTelefone.Text.Trim();
            string padraoCelular = @"^(\(\d{2}\)\s?|\d{2}\s?)9\s?\d{4}-?\d{4}$";
            if (Regex.IsMatch(telefone, padraoCelular))
            {
                return true;
            }
            MessageBox.Show("Número de celular inválido! Use o formato (XX) 91234-1234.");
            return false;
        }
        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //string usuarioAleatorio = txtNome.Text + dtNascimento.Value.Year.ToString("yy");
            //txtUsuario.Text = usuarioAleatorio;
            string anoUsuario = dtNascimento.Value.ToString("yy");

            //string primeiroNome = txtNome.Text.Trim().Split(' ')[0].ToLower(); 
            //string ultimoNome = txtNome.Text.Trim().Split(' ')[1].ToUpper(); 

            string[] nomeCompleto = txtNome.Text.Trim().Split(' ');
            string primeiroNome = nomeCompleto[0].ToLower();
            string ultimoNome = nomeCompleto[nomeCompleto.Length - 1].ToUpper();


            string usuarioAleatorio = primeiroNome + "." + ultimoNome + anoUsuario;
            txtUsuario.Text = usuarioAleatorio;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            arquivo.Title = "Selecione um arquivo";
            arquivo.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos (*.*)|*.*";
            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbxFoto.Image = Image.FromFile(arquivo.FileName);
                    pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a imagem: " + ex.Message);
                }
            }
        }

     
       
       
        
    }
}