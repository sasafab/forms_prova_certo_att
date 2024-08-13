﻿using forms_dentro_do_forms.DAO;
using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_dentro_do_forms
{
    public partial class frm_salas : Form
    {
        DataTable dados;
        int LinhaS;
        public frm_salas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

           // dados.Rows.Add(1, "sala 23", 18, 37, true, true);
           // dados.Rows.Add(2, "sala 25", 20, 35, false, false);
           // dados.Rows.Add(3, "sala 13", 0, 38, true, true);

            Grid_salas.DataSource = dados;
        }

        

        private void btn_save_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = new SalasEntidade();
            sala.Id = Convert.ToInt32(num_ID.Text);
            sala.Nome = txt_name.Text;
            sala.NumeroCadeiras = Convert.ToInt32( n_cadeira.Value);
            sala.NumeroComputadores = Convert.ToInt32(n_pc.Value);
            sala.IsLab = check_islab.Checked;
            sala.Disponivel = check_disp.Checked;

            dados.Rows.Add(sala.Linha());

            DAOsalas dao = new DAOsalas();

            dao.Inserir(sala);

            Grid_salas.DataSource = dao.obterSalas();
            LimparDados();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //txt_name.Text = "";
            //txt_id.Text = Convert.ToString(txt_id.Text);
            //txt_id.Text = "";
            //check_disp.Checked = false;           // pra "pegar" um valor eu nao preciso criar ele, basta chamar desse jeito ← ( ↑  a gente ta criando os valores e jogando eles em variaveis, pra pegar os campos do input)
            //check_islab.Checked = false;
            //n_cadeira.Value = 0;
            //n_pc.Value = 0;
            LimparDados();
        }
        private void LimparDados()
        {
            txt_name.Text = "";
            num_ID.Value = 0;
            check_islab.Checked = false;
            n_cadeira.Value = 0;
            n_pc.Value = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow editar = Grid_salas.Rows[LinhaS];
            editar.Cells[0].Value = num_ID.Value;
            editar.Cells[1].Value = txt_name.Text;
            editar.Cells[2].Value = n_pc.Value;
            editar.Cells[3].Value = n_cadeira.Value;
            editar.Cells[4].Value = check_islab.Checked;
            editar.Cells[5].Value = check_disp.Checked;
            
        }

        private void btn_Delet_Click(object sender, EventArgs e)
        {
            Grid_salas.Rows.RemoveAt(LinhaS);

        }

        private void Grid_salas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaS = e.RowIndex;
            num_ID.Value = Convert.ToInt32(Grid_salas.Rows[LinhaS].Cells[0].Value);
            txt_name.Text = Grid_salas.Rows[LinhaS].Cells[1].Value.ToString();
            n_pc.Value = Convert.ToInt32(Grid_salas.Rows[LinhaS].Cells[2].Value);
            n_cadeira.Value = Convert.ToInt32(Grid_salas.Rows[LinhaS].Cells[3].Value);
            check_islab.Checked = Convert.ToBoolean(Grid_salas.Rows[LinhaS].Cells[4].Value);
            check_disp.Checked = Convert.ToBoolean(Grid_salas.Rows[LinhaS].Cells[5].Value);

        }
    }
}
