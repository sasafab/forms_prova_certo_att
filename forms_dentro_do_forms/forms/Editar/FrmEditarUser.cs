using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.entidades;

namespace forms_dentro_do_forms.forms.Editar
{
    public partial class FrmEditarUser : Form
    {
        public FrmEditarUser(int Id)
        {
            InitializeComponent();
            UserEntidade usuarios = new UserEntidade();
            usuarios.PesquisarPorId(Id);
            txtId.Text = usuarios.Id.ToString();
            txtLogin.Text = usuarios.Login;
            txtSenha.Text = usuarios.Senha;
            chkAtivo.Checked = usuarios.Ativo;
            usuarios = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UserEntidade usuarios = new UserEntidade();
            usuarios.Id = Convert.ToInt32(txtId.Text);
            usuarios.Login = txtLogin.Text;
            usuarios.Senha = txtSenha.Text;
            usuarios.Ativo = chkAtivo.Checked;
            usuarios.Editar();
            usuarios = null;
            this.Close();

        }

        

        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            UserEntidade usuarios = new UserEntidade();
            usuarios.Id = Convert.ToInt32(txtId.Text);
            usuarios.Excluir();
            this.Close();
        }
    }
}
