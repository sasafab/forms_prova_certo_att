
namespace forms_dentro_do_forms.forms
{
    partial class FrmDisciplinas
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
            this.gridDisciplina = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDisciplina
            // 
            this.gridDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDisciplina.Location = new System.Drawing.Point(4, 176);
            this.gridDisciplina.Name = "gridDisciplina";
            this.gridDisciplina.Size = new System.Drawing.Size(487, 305);
            this.gridDisciplina.TabIndex = 18;
            this.gridDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDisciplina_CellDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(27, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(202, 33);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Adicionar Disciplina";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(27, 126);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(436, 29);
            this.txtPesquisar.TabIndex = 23;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.pesquisar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pesquisar";
            // 
            // FrmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridDisciplina);
            this.MaximizeBox = false;
            this.Name = "FrmDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisciplinas";
            this.Load += new System.EventHandler(this.FrmDisciplinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDisciplina;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label4;
    }
}