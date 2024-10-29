
namespace forms_dentro_do_forms.forms.Cadastrar
{
    partial class FrmSalasCadastrar
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
            this.chklab = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numPC = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numCadeiras = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDisp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClean.Location = new System.Drawing.Point(35, 387);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(173, 39);
            this.btnClean.TabIndex = 50;
            this.btnClean.Text = "Limpar Campos";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // numId
            // 
            this.numId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numId.Location = new System.Drawing.Point(35, 49);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(68, 26);
            this.numId.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Id";
            // 
            // chklab
            // 
            this.chklab.AutoSize = true;
            this.chklab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklab.Location = new System.Drawing.Point(38, 294);
            this.chklab.Name = "chklab";
            this.chklab.Size = new System.Drawing.Size(109, 24);
            this.chklab.TabIndex = 47;
            this.chklab.Text = "Laboratório";
            this.chklab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nome da Sala";
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSala.Location = new System.Drawing.Point(35, 114);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(293, 26);
            this.txtNomeSala.TabIndex = 43;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(35, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 38);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // numPC
            // 
            this.numPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPC.Location = new System.Drawing.Point(35, 182);
            this.numPC.Name = "numPC";
            this.numPC.Size = new System.Drawing.Size(59, 26);
            this.numPC.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nº de PCs";
            // 
            // numCadeiras
            // 
            this.numCadeiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCadeiras.Location = new System.Drawing.Point(36, 251);
            this.numCadeiras.Name = "numCadeiras";
            this.numCadeiras.Size = new System.Drawing.Size(58, 26);
            this.numCadeiras.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "N° de Cadeiras";
            // 
            // chkDisp
            // 
            this.chkDisp.AutoSize = true;
            this.chkDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisp.Location = new System.Drawing.Point(169, 294);
            this.chkDisp.Name = "chkDisp";
            this.chkDisp.Size = new System.Drawing.Size(100, 24);
            this.chkDisp.TabIndex = 55;
            this.chkDisp.Text = "Disponível";
            this.chkDisp.UseVisualStyleBackColor = true;
            // 
            // FrmSalasCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.chkDisp);
            this.Controls.Add(this.numCadeiras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chklab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeSala);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmSalasCadastrar";
            this.Text = "FrmSalasCadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chklab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCadeiras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDisp;
    }
}