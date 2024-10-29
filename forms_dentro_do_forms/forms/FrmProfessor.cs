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
using forms_dentro_do_forms.forms.Cadastrar;
using forms_dentro_do_forms.forms.Editar;

namespace forms_dentro_do_forms.forms
{
    public partial class FrmProfessor : Form
    {
        internal static object showdialog;

        DataTable dados;
        ProfessorDAO dao = new ProfessorDAO();

        int LinhaS;
        public FrmProfessor()
        {
            InitializeComponent();
            dao.ObterProfessores();
            dados = new DataTable();

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }



            dados = dao.ObterProfessores();
            gridProfessor.DataSource = dados;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            FrmProfessoresCadastrar cadastrar = new FrmProfessoresCadastrar();

            // Inscreve-se no evento
            cadastrar.FormClosed += Fechou_Cadastrar_FormClosed;

            cadastrar.ShowDialog(); // Abre o formulário como um diálogo modal

        }


        
       

        private void pesquisar_TextChanged(object sender, EventArgs e)
        {
            gridProfessor.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }

       

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            gridProfessor.DataSource = dao.ObterProfessores();
        }
        private void Fechou_Cadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            gridProfessor.DataSource = dao.ObterProfessores();
        }

        

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            gridProfessor.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }

        private void gridProfessor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    gridProfessor.Rows[e.RowIndex].Cells[0].Value);


                FrmEditarProfessores editar = new FrmEditarProfessores(id);

                // Inscreve-se no evento
                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }
    }
}
