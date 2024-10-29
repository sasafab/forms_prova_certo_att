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
using forms_dentro_do_forms.forms.Editar;

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
            string query = "select Id, Nome, NumeroComputadores, NumeroCadeiras, IsLab, Disponivel " +
                "from Salas where Id = @id";

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
                    txtNomeSala.Text = Leitura[1].ToString();
                    numPC.Text = Leitura[2].ToString();
                    numCadeiras.Text = Leitura[3].ToString();
                    chklab.Checked = Convert.ToBoolean(Leitura[4]);
                    chkDisp.Checked = Convert.ToBoolean(Leitura[5]);

                }
            }
            Conexao.Close();

        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string query = "update Salas set Nome = @nome, NumeroComputadores = @numpc, NumeroCadeiras = @numcadeiras, IsLab = @islab, Disponivel = @disponivel WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@disponivel", LabelCod.Text));

            comando.Parameters.Add(new SqlParameter("@nome", txtNomeSala.Text));
            comando.Parameters.Add(new SqlParameter("@numpc", numPC.Text));
            comando.Parameters.Add(new SqlParameter("@numcadeiras", numCadeiras.Text));
            comando.Parameters.Add(new SqlParameter("@islab", chklab.Checked));
            comando.Parameters.Add(new SqlParameter("@disponivel", chkDisp.Checked));
            

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Sala Atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "update Salas set Nome = @nome, Sigla = @sigla, Turno = @turno,  Ativo = @ativo WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@disponivel", LabelCod.Text));

            comando.Parameters.Add(new SqlParameter("@nome", txtNomeSala.Text));
            comando.Parameters.Add(new SqlParameter("@numpc", numPC.Text));
            comando.Parameters.Add(new SqlParameter("@numcadeiras", numCadeiras.Text));
            comando.Parameters.Add(new SqlParameter("@islab", chklab.Checked));
            comando.Parameters.Add(new SqlParameter("@disponivel", chkDisp.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Sala Atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            string query = "Delete from Salas WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id", LabelCod.Text));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Sala Excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
