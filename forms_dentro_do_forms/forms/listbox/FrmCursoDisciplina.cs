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


namespace forms_dentro_do_forms.forms.listbox
{
    public partial class FrmCursoDisciplina : Form
    {

        DAOdisciplinas disciplinaDAO = new DAOdisciplinas();
        DAOcursos cursoDAO = new DAOcursos();
        CursoDisciplinaDAO cdDAO = new CursoDisciplinaDAO();
        private void AtualizarGrid(DataTable dados)
        {
            gridCursoDisciplina.DataSource = dados;
        }
        public FrmCursoDisciplina()
        {
            InitializeComponent();
            //lsDisciplinas.Items.AddRange(disciplinaDAO.Listbox());

            cbxDisciplina.DataSource = disciplinaDAO.PreencherComboBox();
            cbxDisciplina.DisplayMember = "Nome";
            cbxDisciplina.ValueMember = "Id";

            cbxPeriodo.DataSource = cursoDAO.PreencherComboBox();
            cbxPeriodo.DisplayMember = "Nome";
            cbxPeriodo.ValueMember = "Id";

            AtualizarGrid(cdDAO.ObterCursoDisciplina());
        }

        private void cbxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmCursoDisciplina_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CursoDisciplinaDAO cursoDisciplinaDao = new CursoDisciplinaDAO();

            cursoDisciplinaEntidade entidade = new cursoDisciplinaEntidade();
            entidade.CursoId = Convert.ToInt32(cbxPeriodo.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(cbxDisciplina.SelectedValue);
            entidade.Periodo = cbxPeriodo.SelectedItem.ToString();

            cursoDisciplinaDao.Inserir(entidade);
            AtualizarGrid(cdDAO.ObterCursoDisciplina());
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            gridCursoDisciplina.DataSource = cdDAO.PesquisarCursoDisciplina(txtPesquisar.Text);
        }
    }
}
