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
using Model.entidades;
using System.Data.SqlClient;

namespace forms_dentro_do_forms.forms.Editar
{
    //arrumar tudo aq
    public partial class FrmEditarSalas : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public FrmEditarSalas(int salaid)
        {
            InitializeComponent();
            string query = "select Id, Nome, Sigla, Turno, Ativo " +
                "from Cursos where Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", salaid));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    LabelCod.Text = Leitura[0].ToString();
                    txtNomeCursos.Text = Leitura[1].ToString();
                    txtTurno.Text = Leitura[2].ToString();
                    txtSiglaCurso.Text = Leitura[3].ToString();
                    chkAtivo.Checked = Convert.ToBoolean(Leitura[4]);

                }
            }
            Conexao.Close();

        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string query = "update Cursos set Nome = @nome, Sigla = @sigla, Turno = @turno, Ativo = @ativo WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSiglaCurso.Text));
            comando.Parameters.Add(new SqlParameter("@turno", txtTurno.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNomeCursos.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));
            comando.Parameters.Add(new SqlParameter("@id", LabelCod.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Disciplina Atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "update Cursos set Nome = @nome, Sigla = @sigla, Turno = @turno,  Ativo = @ativo WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSiglaCurso.Text));
            comando.Parameters.Add(new SqlParameter("@turno", txtTurno.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNomeCursos.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));
            comando.Parameters.Add(new SqlParameter("@id", LabelCod.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Curso Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string query = "Delete from Cursos WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id", LabelCod.Text));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Curso Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
