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
using forms_dentro_do_forms.forms.Cadastrar;
using Model.entidades;
using forms_dentro_do_forms.forms.Editar;


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

            dados = dao.obterCursos();
            cursosGrid.DataSource = dados;
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmCursosCadastrar c = new FrmCursosCadastrar();
            c.FormClosed += Fechou_Cadastrar_FormClosed;
            c.ShowDialog();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            cursosGrid.Rows.RemoveAt(LinhaS);

        }

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cursosGrid.DataSource = dao.obterCursos();
        }
        private void Fechou_Cadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cursosGrid.DataSource = dao.obterCursos();
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cursosGrid.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }

      

        private void cursosGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    cursosGrid.Rows[e.RowIndex].Cells[0].Value);


                FrmEditarCursos editar = new FrmEditarCursos(id);

                // Inscreve-se no evento
                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }
    }
}
