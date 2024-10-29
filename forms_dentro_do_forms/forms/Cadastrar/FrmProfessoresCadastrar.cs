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

namespace forms_dentro_do_forms.forms.Cadastrar
{
    public partial class FrmProfessoresCadastrar : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        ProfessorDAO dao = new ProfessorDAO();

        public FrmProfessoresCadastrar()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

        }

        private void dtGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }



        

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade d = new ProfessoresEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeProfessor.Text;
            d.Apelido = txtApelido.Text;
           

            dados.Rows.Add(d.Linha());
            dao.Inserir(d);
            MessageBox.Show("Professor Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void LimparDados()
        {
            txtNomeProfessor.Text = "";
            txtApelido.Text = "";
            numId.Value = 0;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimparDados();
        }
    }
}
