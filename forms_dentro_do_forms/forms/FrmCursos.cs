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

namespace forms_dentro_do_forms.forms
{
    public partial class FrmCursos : Form
    {
        BindingSource dados;
        public FrmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            cursosGrid.DataSource = dados;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            CursosEntidade cursos = new CursosEntidade();
            cursos.Id = Convert.ToInt32(numID.Value);
            cursos.Nome = txtName.Text;
            cursos.Turno = txtTurno.Text;
            cursos.Ativo = checkActive.Checked;

            dados.Add(cursos);
        }
    }
}
