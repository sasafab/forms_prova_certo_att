using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.entidades;
using System.Data;


namespace forms_dentro_do_forms.DAO
{
    public class CursoDisciplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public CursoDisciplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao); //criar sempre uma nova conexao é uma boa pratica (para nao pesar a memoria)

        }

        public void Inserir(cursoDisciplinaEntidade cursos)
        {
            Conexao.Open();
            string query = "Insert into Cursos (CursoId, Periodo, DisciplinaId) Values (@CursoId, @DisciplinaId, @Periodo)";
            SqlCommand comando = new SqlCommand(query, Conexao);  //usa-se o @ para identificar que algo tem que ser trocado por um tipo de dados (no caso vai trocar a aparição, vai receber as variaveis) 
            SqlParameter parametro1 = new SqlParameter("@CursoId", cursos.CursoId);
            SqlParameter parametro2 = new SqlParameter("@Periodo", cursos.Periodo);
            SqlParameter parametro3 = new SqlParameter("@DisciplinaId", cursos.DisciplinaId);
            //SqlParameter parametro4 = new SqlParameter("@NomeCurso", cursos.NomeCurso);
            //SqlParameter parametro5 = new SqlParameter("@NomeDisciplina", cursos.NomeDisciplina);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        /*public DataTable PreencherComboBox()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Turno, Ativo from Cursos";
            SqlCommand comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }



            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursosEntidade p = new CursosEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Ativo = Convert.ToBoolean(Leitura[3]);
                    p.Nome = Leitura[1].ToString();
                    p.Turno = Leitura[2].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }


        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = "";

            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT Id, Nome, Turno, Ativo from Cursos";
            }
            else
            {
                query = "SELECT Id, Nome, Turno, Ativo from Salas Where Nome like '%" + pesquisa + "%'";
            }

            SqlCommand comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }



            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursosEntidade p = new CursosEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Ativo = Convert.ToBoolean(Leitura[3]);
                    p.Nome = Leitura[1].ToString();
                    p.Turno = Leitura[2].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }*/
    }
}
