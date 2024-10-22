using forms_dentro_do_forms.DAO;
using Model.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_dentro_do_forms.forms.Cadastrar
{
    public partial class FrmDisciplinasCadastrar : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        DAOdisciplinas dao = new DAOdisciplinas();

        public FrmDisciplinasCadastrar()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

        }

        private void dtGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }

    

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            DisciplinasEntidade d = new DisciplinasEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeDisciplina.Text;
            d.Sigla = txtSigla.Text;
            d.Ativo = chkAtivo.Checked;

            dados.Rows.Add(d.Linha());
            dao.Inserir(d);
            MessageBox.Show("Disciplina Cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
