namespace EscoladeNatação
{
    partial class FormCadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtTelefone = new TextBox();
            btnCadastrar = new Button();
            label4 = new Label();
            txtCPF = new TextBox();
            label5 = new Label();
            dtpDataNascimento = new DateTimePicker();
            groupBox1 = new GroupBox();
            lblQuantidadeAlunosCadastrados = new Label();
            textBuscaPorCPF = new GroupBox();
            label6 = new Label();
            txtBuscaPorCPF = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            textBuscaPorCPF.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Aluno(a)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 92);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 152);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(48, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(48, 110);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(321, 23);
            txtEndereco.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(48, 170);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(212, 23);
            txtTelefone.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(242, 393);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 212);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(49, 233);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(211, 23);
            txtCPF.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 278);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 10;
            label5.Text = "Data de Nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(49, 312);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(268, 23);
            dtpDataNascimento.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblQuantidadeAlunosCadastrados);
            groupBox1.Location = new Point(466, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 141);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quantidade Alunos Cadastrados";
            // 
            // lblQuantidadeAlunosCadastrados
            // 
            lblQuantidadeAlunosCadastrados.AutoSize = true;
            lblQuantidadeAlunosCadastrados.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidadeAlunosCadastrados.Location = new Point(85, 58);
            lblQuantidadeAlunosCadastrados.Name = "lblQuantidadeAlunosCadastrados";
            lblQuantidadeAlunosCadastrados.Size = new Size(23, 28);
            lblQuantidadeAlunosCadastrados.TabIndex = 13;
            lblQuantidadeAlunosCadastrados.Text = "0";
            // 
            // textBuscaPorCPF
            // 
            textBuscaPorCPF.Controls.Add(button1);
            textBuscaPorCPF.Controls.Add(txtBuscaPorCPF);
            textBuscaPorCPF.Controls.Add(label6);
            textBuscaPorCPF.Location = new Point(466, 233);
            textBuscaPorCPF.Name = "textBuscaPorCPF";
            textBuscaPorCPF.Size = new Size(200, 139);
            textBuscaPorCPF.TabIndex = 13;
            textBuscaPorCPF.TabStop = false;
            textBuscaPorCPF.Text = "Busca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 27);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 0;
            label6.Text = "CPF";
            // 
            // txtBuscaPorCPF
            // 
            txtBuscaPorCPF.Location = new Point(14, 56);
            txtBuscaPorCPF.Name = "txtBuscaPorCPF";
            txtBuscaPorCPF.Size = new Size(173, 23);
            txtBuscaPorCPF.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(102, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 473);
            Controls.Add(textBuscaPorCPF);
            Controls.Add(groupBox1);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label5);
            Controls.Add(txtCPF);
            Controls.Add(label4);
            Controls.Add(btnCadastrar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastro";
            Text = "FormCadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            textBuscaPorCPF.ResumeLayout(false);
            textBuscaPorCPF.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtTelefone;
        private Button btnCadastrar;
        private Label label4;
        private TextBox txtCPF;
        private Label label5;
        private DateTimePicker dtpDataNascimento;
        private GroupBox groupBox1;
        private Label lblQuantidadeAlunosCadastrados;
        private GroupBox textBuscaPorCPF;
        private Button button1;
        private TextBox txtBuscaPorCPF;
        private Label label6;
    }
}