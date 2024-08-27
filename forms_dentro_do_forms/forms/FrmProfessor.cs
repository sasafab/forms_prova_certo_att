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
using forms_dentro_do_forms.DAO;

namespace forms_dentro_do_forms.forms
{
    public partial class FrmProfessor : Form
    {
        internal static object showdialog;

        DataTable dados;
        DAOsalas dao = new DAOsalas();

        int LinhaS;
        public FrmProfessor()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            

            
            gridProfessor.DataSource = dados;
            //dados = dao.ObterProfessores();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Id = Convert.ToInt32(txtNum.Value);
            professor.Nome = txtName.Text;
            professor.Apelido = txtNickname.Text;

            dados.Rows.Add(professor.Linha());

            ProfessorDAO dao = new ProfessorDAO();

            dao.Inserir(professor);

            gridProfessor.DataSource = dao.ObterProfessores();
            
            LimparDados();

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

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            gridProfessor.Rows.RemoveAt(LinhaS);
        }

        private void gridProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaS = e.RowIndex;
            txtName.Text = gridProfessor.Rows[LinhaS].Cells[1].Value.ToString();
            txtNickname.Text = gridProfessor.Rows[LinhaS].Cells[2].Value.ToString();
            txtNum.Value = Convert.ToInt32(gridProfessor.Rows[LinhaS].Cells[0].Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow editar = gridProfessor.Rows[LinhaS];
            editar.Cells[0].Value = txtNum.Value;
            editar.Cells[1].Value = txtName.Text;
            editar.Cells[2].Value = txtNickname.Text;
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            gridProfessor.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }
    }
}
