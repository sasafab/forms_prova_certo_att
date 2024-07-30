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
            string query = "Insert into Professores";
        }
       // public void Inserir(string nome, string sigla)
       // {

      //  }
    }
}
