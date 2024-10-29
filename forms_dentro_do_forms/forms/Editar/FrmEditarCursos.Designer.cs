
namespace forms_dentro_do_forms.forms.Editar
{
    partial class FrmEditarCursos
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiglaCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtNomeCursos = new System.Windows.Forms.TextBox();
            this.LabelCod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sigla";
            // 
            // txtSiglaCurso
            // 
            this.txtSiglaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiglaCurso.Location = new System.Drawing.Point(40, 241);
            this.txtSiglaCurso.Multiline = true;
            this.txtSiglaCurso.Name = "txtSiglaCurso";
            this.txtSiglaCurso.Size = new System.Drawing.Size(277, 31);
            this.txtSiglaCurso.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(200, 367);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 43);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(48, 366);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 44);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.Location = new System.Drawing.Point(43, 299);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(63, 24);
            this.chkAtivo.TabIndex = 11;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNomeCursos
            // 
            this.txtNomeCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCursos.Location = new System.Drawing.Point(40, 92);
            this.txtNomeCursos.Multiline = true;
            this.txtNomeCursos.Name = "txtNomeCursos";
            this.txtNomeCursos.Size = new System.Drawing.Size(277, 31);
            this.txtNomeCursos.TabIndex = 10;
            // 
            // LabelCod
            // 
            this.LabelCod.AutoSize = true;
            this.LabelCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCod.Location = new System.Drawing.Point(39, 29);
            this.LabelCod.Name = "LabelCod";
            this.LabelCod.Size = new System.Drawing.Size(59, 20);
            this.LabelCod.TabIndex = 9;
            this.LabelCod.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Turno";
            // 
            // txtTurno
            // 
            this.txtTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurno.Location = new System.Drawing.Point(42, 168);
            this.txtTurno.Multiline = true;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(181, 32);
            this.txtTurno.TabIndex = 51;
            // 
            // FrmEditarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSiglaCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtNomeCursos);
            this.Controls.Add(this.LabelCod);
            this.Name = "FrmEditarCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarCursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiglaCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtNomeCursos;
        private System.Windows.Forms.Label LabelCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurno;
    }
}