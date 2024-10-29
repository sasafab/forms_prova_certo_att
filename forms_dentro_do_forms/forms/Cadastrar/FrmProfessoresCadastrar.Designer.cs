
namespace forms_dentro_do_forms.forms.Cadastrar
{
    partial class FrmProfessoresCadastrar
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
            this.btnClean = new System.Windows.Forms.Button();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClean.Location = new System.Drawing.Point(45, 325);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(173, 39);
            this.btnClean.TabIndex = 50;
            this.btnClean.Text = "Limpar Campos";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // numId
            // 
            this.numId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numId.Location = new System.Drawing.Point(45, 59);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(99, 26);
            this.numId.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Apelido";
            // 
            // txtApelido
            // 
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.Location = new System.Drawing.Point(45, 187);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(109, 26);
            this.txtApelido.TabIndex = 44;
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProfessor.Location = new System.Drawing.Point(45, 124);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(266, 26);
            this.txtNomeProfessor.TabIndex = 43;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(45, 267);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 38);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmProfessoresCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmProfessoresCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProfessoresCadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Button btnSalvar;
    }
}