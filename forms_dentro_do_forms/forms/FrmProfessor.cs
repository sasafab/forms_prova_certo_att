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


namespace forms_dentro_do_forms.forms
{
    public partial class FrmProfessor : Form
    {
        internal static object showdialog;

        BindingSource dados;
        public FrmProfessor()
        {
            InitializeComponent();
            dados = new BindingSource();
            gridProfessor.DataSource = dados;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Id = Convert.ToInt32(txtNum.Value);
            professor.Nome = txtName.Text;
            professor.Apelido = txtNickname.Text;

            dados.Add(professor);
            LimparDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            LimparDados();
        }
        private void LimparDados()
        {
            txtName.Text = "";
            txtNickname.Text = "";
            txtNum.Value = 0;
        }
    }
}
