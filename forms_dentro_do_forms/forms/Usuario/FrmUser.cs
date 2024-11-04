using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using forms_dentro_do_forms.forms.Usuario;
using forms_dentro_do_forms.forms.Editar;
using Model.entidades;

namespace forms_dentro_do_forms.forms
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
             UserEntidade user = new UserEntidade();
            dtgridusuarios.DataSource = user.PreencherGrid();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoUser frm = new NovoUser();
            frm.FormClosed += FecharForm;
            frm.ShowDialog();
        }

        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            UserEntidade u = new UserEntidade();
            dtgridusuarios.DataSource = u.PreencherGrid();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            UserEntidade u = new UserEntidade();
            dtgridusuarios.DataSource = u.Pesquisar(txtPesquisar.Text);
        }

        private void dtgridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtgridusuarios.Rows[e.RowIndex].Cells[0].Value);

                FrmEditarUser editar = new FrmEditarUser(id);

                // Inscreve-se no evento
                editar.FormClosed += FecharForm;
                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }

        private void dtgridusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

