using forms_dentro_do_forms.DAO;
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
        public FrmCursoDisciplina()
        {
            InitializeComponent();
            //lsDisciplinas.Items.AddRange(disciplinaDAO.Listbox());
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

        }
    }
}
