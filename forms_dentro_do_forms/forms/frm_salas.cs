using forms_dentro_do_forms.DAO;
using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using forms_dentro_do_forms.forms.Cadastrar;
using forms_dentro_do_forms.forms.Editar;


namespace forms_dentro_do_forms
{
    public partial class frm_salas : Form
    {
        DataTable dados;
        int LinhaS;
        DAOsalas dao = new DAOsalas();
        public frm_salas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            // dados.Rows.Add(1, "sala 23", 18, 37, true, true);
            // dados.Rows.Add(2, "sala 25", 20, 35, false, false);
            // dados.Rows.Add(3, "sala 13", 0, 38, true, true);

            dados = dao.obterSalas();
            Grid_salas.DataSource = dados;
        }

        

        private void btn_save_Click(object sender, EventArgs e)
        {
            FrmSalasCadastrar cadastrar = new FrmSalasCadastrar();

            // Inscreve-se no evento
            cadastrar.FormClosed += Fechou_Cadastrar_FormClosed;

            cadastrar.ShowDialog(); // Abre o formulário como um diálogo modal
        }

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Grid_salas.DataSource = dao.obterSalas();
        }
        private void Fechou_Cadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Grid_salas.DataSource = dao.obterSalas();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Grid_salas.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }

        private void Grid_salas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    Grid_salas.Rows[e.RowIndex].Cells[0].Value);


                FrmEditarSalas editar = new FrmEditarSalas(id);

                // Inscreve-se no evento
                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }

        
    }
}
