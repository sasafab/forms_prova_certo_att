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
using Model.Entitidades;

namespace forms_dentro_do_forms.forms.Cadastrar
{
    public partial class FrmSalasCadastrar : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        DAOsalas dao = new DAOsalas();

        public FrmSalasCadastrar()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())
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
            txtNomeSala.Text = "";
            numId.Value = 0;
            numPC.Value = 0;
            numCadeiras.Value = 0;
            chklab.Checked = false;
            chkDisp.Checked = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimparDados();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidade d = new SalasEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.NumeroComputadores = Convert.ToInt32(numPC.Value);
            d.NumeroCadeiras = Convert.ToInt32(numCadeiras.Value);
            d.Nome = txtNomeSala.Text;
            d.IsLab = chklab.Checked;
            d.Disponivel = chkDisp.Checked;

            dados.Rows.Add(d.Linha());
            dao.Inserir(d);
            MessageBox.Show("Sala Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        
    }
}
