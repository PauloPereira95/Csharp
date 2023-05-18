using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFuncoes
{
    public partial class FormValidacoes : Form
    {
        public FormValidacoes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (libraryFuncoes.Validacoes.ValidarNome(txtNome.Text)==false)
                MessageBox.Show(" Nome Inválido ! ", "Validações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (libraryFuncoes.Validacoes.ValidarEmail(txtEmail.Text) == false)
                MessageBox.Show("Email Inválido ! ", "Validações", MessageBoxButtons.OK,MessageBoxIcon.Error);
            if (libraryFuncoes.Validacoes.ValidarTelefone(txtTelefone.Text) == false)
                MessageBox.Show("Telefone Inválido ! ", "Validações", MessageBoxButtons.OK,MessageBoxIcon.Error);
            if (libraryFuncoes.Validacoes.ValidarTelemovel(txtTelemovel.Text) == false)
                MessageBox.Show("Telemovel Inválido ! ", "Validações",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
