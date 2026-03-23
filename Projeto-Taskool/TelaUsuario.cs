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
    public partial class TelaUsuario : Form
    {
        dbTarefasEntities1 banco = new dbTarefasEntities1();

        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
        }
    }
}
