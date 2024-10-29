using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace forms_dentro_do_forms.forms.Editar
{
    public partial class FrmEditarProfessores : Form
    {
       
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public FrmEditarProfessores(int ProfessorId)
        {
            InitializeComponent();

            string query = "select Id, Nome, Apelido " +
                "from Professores where Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", ProfessorId));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    LabelCod.Text = Leitura[0].ToString();
                    txtNomeProfessor.Text = Leitura[1].ToString();
                    txtApelido.Text = Leitura[2].ToString();

                }
            }
            Conexao.Close();

        }

        

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string query = "update Professores set Nome = @nome, Apelido = @apelido WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtApelido.Text));
            comando.Parameters.Add(new SqlParameter("@apelido", txtNomeProfessor.Text));
            comando.Parameters.Add(new SqlParameter("@id", LabelCod.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Dados do Professor Atualizados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string query = "Delete from Professores WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id", LabelCod.Text));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Dados do professor Excluídos com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
