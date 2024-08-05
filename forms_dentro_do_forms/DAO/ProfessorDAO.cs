using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql; //coisa que nao estava antes
using System.Data.SqlClient; //coisa que nao tava antes
using Model.entidades;

namespace forms_dentro_do_forms.DAO
{
    public class ProfessorDAO //lembrar de colocar o public sempre que colocar uma classe nova
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;"; //link pegado do connection string (site)
        //sa = como se fosse o root do banco de dados normal (sql)
        private SqlConnection Conexao;

        public ProfessorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao); //criar sempre uma nova conexao é uma boa pratica (para nao pesar a memoria)
            
        }

        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into Professores (Nome, Apelido) Values (@nome, @apelido)";
            SqlCommand comando = new SqlCommand(query, Conexao);  //usa-se o @ para identificar que algo tem que ser trocado por um tipo de dados (no caso vai trocar a aparição, vai receber as variaveis) 
            SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);
            comando.Parameters.Add(parametro1); //garante que @apelido e @nome sejam trocados pelas informacoes necessárias
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery(); // na primeiro linha insert eu abro a conexao e o executenonquery ele vai fechar (garantindo que o projeto vai atualizar)
            Conexao.Close();
        }
       // public void Inserir(string nome, string sigla)
       // {

      //  }
    }
}
