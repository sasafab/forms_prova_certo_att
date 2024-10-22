using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Model.entidades
{
    class UserEntidade
    {
        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public void Inserir()
        {
            Conexao.Open();

            string query = "Insert into Usuarios (Login, Senha, Ativo) Values (@login, @senha, @ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao); 
            SqlParameter parametro1 = new SqlParameter("@login", Nome);
            SqlParameter parametro2 = new SqlParameter("@senha", Senha);
            SqlParameter parametro3 = new SqlParameter("@ativo", Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery(); 
            Conexao.Close();
        }
    }
}
