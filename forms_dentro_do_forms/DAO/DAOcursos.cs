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
            string query = "Insert into Cursos (Nome, Turno) Values (@nome, @turno)";
            SqlCommand comando = new SqlCommand(query, Conexao);  //usa-se o @ para identificar que algo tem que ser trocado por um tipo de dados (no caso vai trocar a aparição, vai receber as variaveis) 
            SqlParameter parametro1 = new SqlParameter("@nome", cursos.Nome);
            SqlParameter parametro2 = new SqlParameter("@turno", cursos.Turno);
            comando.Parameters.Add(parametro1); 
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery(); 
            Conexao.Close();
        }

        public DataTable obterCursos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Turno from Cursos";
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
                    dt.Rows.Add(p.Linha());
                }
            }

            return dt;
        }
    }
}
