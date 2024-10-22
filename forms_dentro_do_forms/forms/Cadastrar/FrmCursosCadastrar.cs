using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using forms_dentro_do_forms.DAO;
using Model.entidades;

namespace forms_dentro_do_forms.forms.Cadastrar
{
    public partial class FrmCursosCadastrar : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        DAOcursos dao = new DAOcursos();

        public FrmCursosCadastrar()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

        }

        private void dtGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }



        private void LimparDados()
        {
            txtNomeCurso.Text = "";
            txtSigla.Text = "";
            txtTurno.Text = "";
            numId.Value = 0;
            chkAtivo.Checked = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimparDados();
        }
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CursosEntidade d = new CursosEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeCurso.Text;
            d.Sigla = txtSigla.Text;
            d.Turno = txtTurno.Text;
            d.Ativo = chkAtivo.Checked;

            dados.Rows.Add(d.Linha());
            dao.Inserir(d);
            MessageBox.Show("Curso Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtTurno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
