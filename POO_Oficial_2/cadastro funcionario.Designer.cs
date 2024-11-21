namespace POO_Oficial_2
{
    partial class cadastro_funcionario
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
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.cmbCargoFuncionario = new System.Windows.Forms.ComboBox();
            this.txtSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.btnAdicionarFuncionario = new System.Windows.Forms.Button();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(101, 55);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(133, 26);
            this.txtNomeFuncionario.TabIndex = 0;
            // 
            // cmbCargoFuncionario
            // 
            this.cmbCargoFuncionario.FormattingEnabled = true;
            this.cmbCargoFuncionario.Location = new System.Drawing.Point(113, 93);
            this.cmbCargoFuncionario.Name = "cmbCargoFuncionario";
            this.cmbCargoFuncionario.Size = new System.Drawing.Size(121, 28);
            this.cmbCargoFuncionario.TabIndex = 1;
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(125, 138);
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(109, 26);
            this.txtSalarioFuncionario.TabIndex = 2;
            // 
            // btnAdicionarFuncionario
            // 
            this.btnAdicionarFuncionario.Location = new System.Drawing.Point(43, 189);
            this.btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            this.btnAdicionarFuncionario.Size = new System.Drawing.Size(197, 29);
            this.btnAdicionarFuncionario.TabIndex = 3;
            this.btnAdicionarFuncionario.Text = "Adicionar Funcionário";
            this.btnAdicionarFuncionario.UseVisualStyleBackColor = true;
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.ItemHeight = 20;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(43, 238);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(713, 184);
            this.listBoxFuncionarios.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "CARGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "SALÁRIO";
            // 
            // cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFuncionarios);
            this.Controls.Add(this.btnAdicionarFuncionario);
            this.Controls.Add(this.txtSalarioFuncionario);
            this.Controls.Add(this.cmbCargoFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Name = "cadastro_funcionario";
            this.Text = "cadastro_funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.ComboBox cmbCargoFuncionario;
        private System.Windows.Forms.TextBox txtSalarioFuncionario;
        private System.Windows.Forms.Button btnAdicionarFuncionario;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}