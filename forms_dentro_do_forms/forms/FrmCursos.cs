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

namespace forms_dentro_do_forms.forms
{
    public partial class FrmCursos : Form
    {
        DataTable dados;
        int LinhaS;
        DAOcursos dao = new DAOcursos();
        public FrmCursos()
        {
            InitializeComponent();
            dados = new DataTable();
            cursosGrid.DataSource = dados;

            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

           // dados.Rows.Add(1, "Desenvolvimento de Sistemas", "Integral", true);
           // dados.Rows.Add(2, "Itinerário Formativo", "Manhã", true);
           // dados.Rows.Add(3, "Administração", "Integral", true);

            cursosGrid.DataSource = dados;
        }

        private void LimparDados()
        {
            txtName.Text = "";
            txtTurno.Text = "";
            numID.Value = 0;
            checkActive.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CursosEntidade cursos = new CursosEntidade();
            cursos.Id = Convert.ToInt32(numID.Value);
            cursos.Nome = txtName.Text;
            cursos.Turno = txtTurno.Text;
            cursos.Ativo = checkActive.Checked;

            dados.Rows.Add(cursos.Linha());

            DAOcursos dao = new DAOcursos();

            dao.Inserir(cursos);

            cursosGrid.DataSource = dao.obterCursos();

            LimparDados();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            cursosGrid.Rows.RemoveAt(LinhaS);

        }

        private void cursosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaS = e.RowIndex;
            txtName.Text = cursosGrid.Rows[LinhaS].Cells[1].Value.ToString();
            txtTurno.Text = cursosGrid.Rows[LinhaS].Cells[2].Value.ToString();
            numID.Value = Convert.ToInt32(cursosGrid.Rows[LinhaS].Cells[0].Value);
            checkActive.Checked = Convert.ToBoolean(cursosGrid.Rows[LinhaS].Cells[3].Value);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow editar = cursosGrid.Rows[LinhaS];
            editar.Cells[0].Value = numID.Value;
            editar.Cells[1].Value = txtName.Text;
            editar.Cells[2].Value = txtTurno.Text;
            editar.Cells[3].Value = checkActive.Checked;
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cursosGrid.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }
    }
}
