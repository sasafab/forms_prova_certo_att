using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql; //coisa que nao estava antes
using System.Data.SqlClient; //coisa que nao tava antes
using Model.entidades;
using System.Data;

namespace forms_dentro_do_forms.DAO
{
    public class DAOdisciplinas
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;"; //link pegado do connection string (site)
        //sa = como se fosse o root do banco de dados normal (sql)
        private SqlConnection Conexao;

        public DAOdisciplinas()
        {
            Conexao = new SqlConnection(LinhaConexao); //criar sempre uma nova conexao é uma boa pratica (para nao pesar a memoria)

        }

        public void Inserir(DisciplinasEntidade disciplinas)
        {
            Conexao.Open();
            string query = "Insert into Disciplinas (Nome, Sigla, Ativo) Values (@nome, @sigla, @ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);  //usa-se o @ para identificar que algo tem que ser trocado por um tipo de dados (no caso vai trocar a aparição, vai receber as variaveis) 
            SqlParameter parametro1 = new SqlParameter("@nome", disciplinas.Nome);
            SqlParameter parametro2 = new SqlParameter("@sigla", disciplinas.Sigla);
            SqlParameter parametro3 = new SqlParameter("@ativo", disciplinas.Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery(); // na primeiro linha insert eu abro a conexao e o executenonquery ele vai fechar (garantindo que o projeto vai atualizar)
            Conexao.Close();
        }
        // public void Inserir(string nome, string sigla)
        // {

        //  }

        public DataTable obterDisciplinas()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Sigla, Ativo from Disciplinas"; //trocar * pelos bagui ali de baixo
            SqlCommand comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }



            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    DisciplinasEntidade p = new DisciplinasEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Sigla = Leitura[2].ToString();
                    p.Ativo = Convert.ToBoolean(Leitura[3]);
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }

    }
}
