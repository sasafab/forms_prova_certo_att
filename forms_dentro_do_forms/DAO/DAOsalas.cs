using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.entidades;
using System.Data;
using Model.Entitidades;

namespace forms_dentro_do_forms.DAO
{
    public class DAOsalas
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public DAOsalas()
        {
            Conexao = new SqlConnection(LinhaConexao); 

        }

        public void Inserir(SalasEntidade salas)
        {
            Conexao.Open();
            string query = "Insert into Salas (Nome, NumeroComputadores, NumeroCadeiras, IsLab, Disponivel) Values (@nome, @numerocomputadores, @numerocadeiras, @islab, @disponivel)";
            SqlCommand comando = new SqlCommand(query, Conexao);  
            SqlParameter parametro1 = new SqlParameter("@nome", salas.Nome);
            SqlParameter parametro2 = new SqlParameter("@numerocomputadores", salas.NumeroComputadores);
            SqlParameter parametro3 = new SqlParameter("@numerocadeiras", salas.NumeroCadeiras);
            SqlParameter parametro4 = new SqlParameter("@islab", salas.IsLab);
            SqlParameter parametro5 = new SqlParameter("@disponivel", salas.Disponivel);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable obterSalas()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, NumeroComputadores, NumeroCadeiras, IsLab, Disponivel from Salas";
            SqlCommand comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }



            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    SalasEntidade p = new SalasEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.NumeroComputadores = Convert.ToInt32( Leitura[2]);
                    p.NumeroCadeiras = Convert.ToInt32( Leitura[3]);
                    p.IsLab = Convert.ToBoolean( Leitura[4]);
                    dt.Rows.Add(p.Linha());
                }
            }

            return dt;
        }
    }
}
