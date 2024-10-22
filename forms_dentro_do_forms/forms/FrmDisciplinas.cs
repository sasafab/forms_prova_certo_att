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
using forms_dentro_do_forms.forms.Editar;
using Model.entidades;


namespace forms_dentro_do_forms.forms
{
    public partial class FrmDisciplinas : Form
    {
        DataTable dados;
        int LinhaS;
        DAOdisciplinas dao = new DAOdisciplinas();
        public FrmDisciplinas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            // dados.Rows.Add(1, "matemática", "mat", true);
            // dados.Rows.Add(2, "portugues", "port", true);
            //dados.Rows.Add(3, "geografia", "geo", true);

            dados = dao.obterDisciplinas();
            gridDisciplina.DataSource = dados;
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            FrmDisciplinasCadastrar cadastrar = new FrmDisciplinasCadastrar();

            // Inscreve-se no evento
            cadastrar.FormClosed += Fechou_Cadastrar_FormClosed;

            cadastrar.ShowDialog(); // Abre o formulário como um diálogo modal
        }
       


        private void FrmDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //DataGridViewRow editar = gridDisciplina.Rows[LinhaS];
            //editar.Cells[0].Value = numID.Value;
            //editar.Cells[1].Value = txtName.Text;
            //editar.Cells[2].Value = txtSigla.Text;
            //editar.Cells[3].Value = checkActive.Checked;

           

        }

        
        private void btnDel_Click(object sender, EventArgs e)
        {
            gridDisciplina.Rows.RemoveAt(LinhaS);
        }

       

        private void pesquisar_TextChanged(object sender, EventArgs e)
        {
            gridDisciplina.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }

        private void gridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    gridDisciplina.Rows[e.RowIndex].Cells[0].Value);


                frmEditarDisciplina editar = new frmEditarDisciplina(id);

                // Inscreve-se no evento
                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            gridDisciplina.DataSource = dao.obterDisciplinas();
        }
        private void Fechou_Cadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            gridDisciplina.DataSource = dao.obterDisciplinas();
        }



        //private void btnDelAll_Click(object sender, EventArgs e)
        //{
        //  gridDisciplina.Rows.RemoveAt(); //nao terminado
        //}
    }
}
