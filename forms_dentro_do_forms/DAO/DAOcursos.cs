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
    public class DAOcursos
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public DAOcursos()
        {
            Conexao = new SqlConnection(LinhaConexao); //criar sempre uma nova conexao é uma boa pratica (para nao pesar a memoria)

        }

        public void Inserir(CursosEntidade cursos)
        {
            Conexao.Open();
            string query = "Insert into Cursos (Nome, Turno, Ativo, Sigla) Values (@nome, @turno, @ativo, @sigla)";
            SqlCommand comando = new SqlCommand(query, Conexao);  //usa-se o @ para identificar que algo tem que ser trocado por um tipo de dados (no caso vai trocar a aparição, vai receber as variaveis) 
            SqlParameter parametro1 = new SqlParameter("@nome", cursos.Nome);
            SqlParameter parametro2 = new SqlParameter("@turno", cursos.Turno);
            SqlParameter parametro3 = new SqlParameter("@ativo", cursos.Ativo);
            SqlParameter parametro4 = new SqlParameter("@sigla", cursos.Sigla);

            comando.Parameters.Add(parametro1); 
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.ExecuteNonQuery(); 
            Conexao.Close();
        }

        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Cursos";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Lida com erros, se necessário
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }
        public DataTable obterCursos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Turno, Ativo, Sigla from Cursos";
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
                    p.Nome = Leitura[1].ToString();
                    p.Turno = Leitura[2].ToString();
                    p.Ativo = Convert.ToBoolean(Leitura[3]);
                    p.Sigla = Leitura[4].ToString();
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
                query = "SELECT Id, Nome, Turno, Ativo, Sigla from Cursos";
            }
            else
            {
                query = "SELECT Id, Nome, Turno, Ativo, Sigla from Cursos Where Nome like '%"+ pesquisa +"%'";
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
                    p.Sigla = Leitura[4].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}
