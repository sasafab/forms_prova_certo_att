
namespace forms_dentro_do_forms.forms.listbox
{
    partial class FrmCursoDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridCursoDisciplina = new System.Windows.Forms.DataGridView();
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.cbxDisciplina = new System.Windows.Forms.ComboBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCursoDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(391, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Período";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(58, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disciplina";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(397, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridCursoDisciplina
            // 
            this.gridCursoDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCursoDisciplina.Location = new System.Drawing.Point(35, 209);
            this.gridCursoDisciplina.Name = "gridCursoDisciplina";
            this.gridCursoDisciplina.Size = new System.Drawing.Size(525, 216);
            this.gridCursoDisciplina.TabIndex = 5;
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Integral",
            "Noite"});
            this.cbxPeriodo.Location = new System.Drawing.Point(389, 55);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(128, 21);
            this.cbxPeriodo.TabIndex = 6;
            this.cbxPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxCursos_SelectedIndexChanged);
            // 
            // cbxDisciplina
            // 
            this.cbxDisciplina.FormattingEnabled = true;
            this.cbxDisciplina.Items.AddRange(new object[] {
            "Português",
            "Matemática",
            "Análise de Projetos e Sistemas",
            "Banco de dados",
            "Laboratório de Processos Criativos",
            "Artes"});
            this.cbxDisciplina.Location = new System.Drawing.Point(61, 55);
            this.cbxDisciplina.Name = "cbxDisciplina";
            this.cbxDisciplina.Size = new System.Drawing.Size(128, 21);
            this.cbxDisciplina.TabIndex = 7;
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Desenvolvimento de sistemas",
            "Itinerário Formativo",
            "Administração",
            "Informática para Internet",
            "Logística",
            "Serviços Jurídicos"});
            this.cbxCurso.Location = new System.Drawing.Point(228, 55);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(128, 21);
            this.cbxCurso.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(225, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cursos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(40, 170);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(381, 26);
            this.txtPesquisar.TabIndex = 16;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pesquisar";
            // 
            // FrmCursoDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDisciplina);
            this.Controls.Add(this.cbxPeriodo);
            this.Controls.Add(this.gridCursoDisciplina);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCursoDisciplina";
            this.Text = "FrmCursoDisciplina";
            this.Load += new System.EventHandler(this.FrmCursoDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCursoDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridCursoDisciplina;
        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.ComboBox cbxDisciplina;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label4;
    }
}