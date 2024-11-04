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
using Model.Entitidades;
using forms_dentro_do_forms.forms;


namespace forms_dentro_do_forms.forms.Usuario
{
    public partial class FrmLogar : Form
    {
        private Login login;
        public FrmLogar()
        {
            InitializeComponent();
            login = new Login();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login.Usuario = txtLogin.Text;
            login.Senha = txtSenha.Text;
            if (login.Logar())
            {
                 salas p = new salas();
                p.FormClosed += FecharForm;
                this.Hide();
                p.Show();
            }
            else
            {
                MessageBox.Show("Usuário e senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }
    }
}
