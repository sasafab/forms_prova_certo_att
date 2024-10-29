
namespace forms_dentro_do_forms.forms
{
    partial class FrmProfessor
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gridProfessor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(28, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Cadastrar Professor";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridProfessor
            // 
            this.gridProfessor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessor.Location = new System.Drawing.Point(3, 163);
            this.gridProfessor.Name = "gridProfessor";
            this.gridProfessor.Size = new System.Drawing.Size(477, 287);
            this.gridProfessor.TabIndex = 7;
            this.gridProfessor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfessor_CellContentDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(29, 108);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(427, 33);
            this.txtPesquisar.TabIndex = 12;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridProfessor);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "FrmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}