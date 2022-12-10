namespace apBiblioteca_22125.UI
{
    partial class FrmEmprestimo
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
            this.tcEmprestimoseDevolucoes = new System.Windows.Forms.TabControl();
            this.tbEmprestimos = new System.Windows.Forms.TabPage();
            this.dataDeDevolucaoPrevista = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.txtIdEmprestimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDev = new System.Windows.Forms.TabPage();
            this.dataDeDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btnExibirDev = new System.Windows.Forms.Button();
            this.btnExcluirDev = new System.Windows.Forms.Button();
            this.btnAlterarDev = new System.Windows.Forms.Button();
            this.btnNovoDev = new System.Windows.Forms.Button();
            this.btnProcurarDev = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listatb = new System.Windows.Forms.TabPage();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolPrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcEmprestimoseDevolucoes.SuspendLayout();
            this.tbEmprestimos.SuspendLayout();
            this.tbDev.SuspendLayout();
            this.listatb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEmprestimoseDevolucoes
            // 
            this.tcEmprestimoseDevolucoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcEmprestimoseDevolucoes.Controls.Add(this.tbEmprestimos);
            this.tcEmprestimoseDevolucoes.Controls.Add(this.tbDev);
            this.tcEmprestimoseDevolucoes.Controls.Add(this.listatb);
            this.tcEmprestimoseDevolucoes.Location = new System.Drawing.Point(1, 2);
            this.tcEmprestimoseDevolucoes.Name = "tcEmprestimoseDevolucoes";
            this.tcEmprestimoseDevolucoes.SelectedIndex = 0;
            this.tcEmprestimoseDevolucoes.Size = new System.Drawing.Size(588, 366);
            this.tcEmprestimoseDevolucoes.TabIndex = 0;
            // 
            // tbEmprestimos
            // 
            this.tbEmprestimos.Controls.Add(this.dataDeDevolucaoPrevista);
            this.tbEmprestimos.Controls.Add(this.label5);
            this.tbEmprestimos.Controls.Add(this.dataEmprestimo);
            this.tbEmprestimos.Controls.Add(this.btnAlterar);
            this.tbEmprestimos.Controls.Add(this.btnExcluir);
            this.tbEmprestimos.Controls.Add(this.btnExibir);
            this.tbEmprestimos.Controls.Add(this.btnNovo);
            this.tbEmprestimos.Controls.Add(this.btnProcurar);
            this.tbEmprestimos.Controls.Add(this.txtIdLivro);
            this.tbEmprestimos.Controls.Add(this.txtIdLeitor);
            this.tbEmprestimos.Controls.Add(this.txtIdEmprestimo);
            this.tbEmprestimos.Controls.Add(this.label4);
            this.tbEmprestimos.Controls.Add(this.label3);
            this.tbEmprestimos.Controls.Add(this.label2);
            this.tbEmprestimos.Controls.Add(this.label1);
            this.tbEmprestimos.Location = new System.Drawing.Point(4, 22);
            this.tbEmprestimos.Name = "tbEmprestimos";
            this.tbEmprestimos.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmprestimos.Size = new System.Drawing.Size(580, 340);
            this.tbEmprestimos.TabIndex = 0;
            this.tbEmprestimos.Text = "Empréstimos";
            this.tbEmprestimos.UseVisualStyleBackColor = true;
            // 
            // dataDeDevolucaoPrevista
            // 
            this.dataDeDevolucaoPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDeDevolucaoPrevista.Location = new System.Drawing.Point(300, 145);
            this.dataDeDevolucaoPrevista.Name = "dataDeDevolucaoPrevista";
            this.dataDeDevolucaoPrevista.Size = new System.Drawing.Size(83, 20);
            this.dataDeDevolucaoPrevista.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Data de devolução prevista:";
            // 
            // dataEmprestimo
            // 
            this.dataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataEmprestimo.Location = new System.Drawing.Point(300, 119);
            this.dataEmprestimo.Name = "dataEmprestimo";
            this.dataEmprestimo.Size = new System.Drawing.Size(83, 20);
            this.dataEmprestimo.TabIndex = 19;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(197, 199);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(300, 199);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(403, 199);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 13;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(94, 199);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(416, 36);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 11;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(300, 91);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(79, 20);
            this.txtIdLivro.TabIndex = 8;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(300, 62);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(79, 20);
            this.txtIdLeitor.TabIndex = 7;
            // 
            // txtIdEmprestimo
            // 
            this.txtIdEmprestimo.Location = new System.Drawing.Point(300, 36);
            this.txtIdEmprestimo.Name = "txtIdEmprestimo";
            this.txtIdEmprestimo.ReadOnly = true;
            this.txtIdEmprestimo.Size = new System.Drawing.Size(79, 20);
            this.txtIdEmprestimo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identificação do leitor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificação do livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de empréstimo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação do empréstimo:";
            // 
            // tbDev
            // 
            this.tbDev.Controls.Add(this.dataDeDevolucao);
            this.tbDev.Controls.Add(this.btnExibirDev);
            this.tbDev.Controls.Add(this.btnExcluirDev);
            this.tbDev.Controls.Add(this.btnAlterarDev);
            this.tbDev.Controls.Add(this.btnNovoDev);
            this.tbDev.Controls.Add(this.btnProcurarDev);
            this.tbDev.Controls.Add(this.textBox1);
            this.tbDev.Controls.Add(this.textBox2);
            this.tbDev.Controls.Add(this.textBox3);
            this.tbDev.Controls.Add(this.label6);
            this.tbDev.Controls.Add(this.label7);
            this.tbDev.Controls.Add(this.label8);
            this.tbDev.Controls.Add(this.label9);
            this.tbDev.Location = new System.Drawing.Point(4, 22);
            this.tbDev.Name = "tbDev";
            this.tbDev.Padding = new System.Windows.Forms.Padding(3);
            this.tbDev.Size = new System.Drawing.Size(580, 340);
            this.tbDev.TabIndex = 1;
            this.tbDev.Text = "Devolução";
            this.tbDev.UseVisualStyleBackColor = true;
            // 
            // dataDeDevolucao
            // 
            this.dataDeDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDeDevolucao.Location = new System.Drawing.Point(271, 146);
            this.dataDeDevolucao.Name = "dataDeDevolucao";
            this.dataDeDevolucao.Size = new System.Drawing.Size(102, 20);
            this.dataDeDevolucao.TabIndex = 32;
            // 
            // btnExibirDev
            // 
            this.btnExibirDev.Location = new System.Drawing.Point(402, 222);
            this.btnExibirDev.Name = "btnExibirDev";
            this.btnExibirDev.Size = new System.Drawing.Size(75, 23);
            this.btnExibirDev.TabIndex = 30;
            this.btnExibirDev.Text = "Exibir";
            this.btnExibirDev.UseVisualStyleBackColor = true;
            this.btnExibirDev.Click += new System.EventHandler(this.btnExibirDev_Click);
            // 
            // btnExcluirDev
            // 
            this.btnExcluirDev.Location = new System.Drawing.Point(298, 222);
            this.btnExcluirDev.Name = "btnExcluirDev";
            this.btnExcluirDev.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirDev.TabIndex = 29;
            this.btnExcluirDev.Text = "Excluir";
            this.btnExcluirDev.UseVisualStyleBackColor = true;
            this.btnExcluirDev.Click += new System.EventHandler(this.btnExcluirDev_Click);
            // 
            // btnAlterarDev
            // 
            this.btnAlterarDev.Location = new System.Drawing.Point(200, 222);
            this.btnAlterarDev.Name = "btnAlterarDev";
            this.btnAlterarDev.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarDev.TabIndex = 28;
            this.btnAlterarDev.Text = "Alterar";
            this.btnAlterarDev.UseVisualStyleBackColor = true;
            this.btnAlterarDev.Click += new System.EventHandler(this.btnAlterarDev_Click);
            // 
            // btnNovoDev
            // 
            this.btnNovoDev.Location = new System.Drawing.Point(102, 222);
            this.btnNovoDev.Name = "btnNovoDev";
            this.btnNovoDev.Size = new System.Drawing.Size(75, 23);
            this.btnNovoDev.TabIndex = 27;
            this.btnNovoDev.Text = "Novo";
            this.btnNovoDev.UseVisualStyleBackColor = true;
            this.btnNovoDev.Click += new System.EventHandler(this.btnNovoDev_Click);
            // 
            // btnProcurarDev
            // 
            this.btnProcurarDev.Location = new System.Drawing.Point(408, 38);
            this.btnProcurarDev.Name = "btnProcurarDev";
            this.btnProcurarDev.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarDev.TabIndex = 26;
            this.btnProcurarDev.Text = "Procurar";
            this.btnProcurarDev.UseVisualStyleBackColor = true;
            this.btnProcurarDev.Click += new System.EventHandler(this.btnProcurarDev_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Identificação do Leitor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Identificação do Livro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data de Devolução:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Identificação de Emprestimo: ";
            // 
            // listatb
            // 
            this.listatb.Controls.Add(this.dgvEmprestimo);
            this.listatb.Location = new System.Drawing.Point(4, 22);
            this.listatb.Name = "listatb";
            this.listatb.Padding = new System.Windows.Forms.Padding(3);
            this.listatb.Size = new System.Drawing.Size(580, 340);
            this.listatb.TabIndex = 2;
            this.listatb.Text = "Lista";
            this.listatb.UseVisualStyleBackColor = true;
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.dataDevolucao,
            this.dataDevolPrev,
            this.idLeitor,
            this.idLivro,
            this.dataEmp});
            this.dgvEmprestimo.Location = new System.Drawing.Point(0, 0);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.Size = new System.Drawing.Size(681, 340);
            this.dgvEmprestimo.TabIndex = 1;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idEmprestimo.HeaderText = "Id Emprestimo:";
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            this.idEmprestimo.Width = 93;
            // 
            // dataDevolucao
            // 
            this.dataDevolucao.HeaderText = "Data de devolução";
            this.dataDevolucao.Name = "dataDevolucao";
            // 
            // dataDevolPrev
            // 
            this.dataDevolPrev.HeaderText = "Data de devolução prevista";
            this.dataDevolPrev.Name = "dataDevolPrev";
            // 
            // idLeitor
            // 
            this.idLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idLeitor.HeaderText = "Id Leitor";
            this.idLeitor.Name = "idLeitor";
            this.idLeitor.Width = 65;
            // 
            // idLivro
            // 
            this.idLivro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idLivro.HeaderText = "Id Livro";
            this.idLivro.Name = "idLivro";
            this.idLivro.Width = 62;
            // 
            // dataEmp
            // 
            this.dataEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataEmp.HeaderText = "Data de empréstimo:";
            this.dataEmp.Name = "dataEmp";
            this.dataEmp.Width = 118;
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 292);
            this.Controls.Add(this.tcEmprestimoseDevolucoes);
            this.Name = "FrmEmprestimo";
            this.Text = "Empréstimos";
            this.tcEmprestimoseDevolucoes.ResumeLayout(false);
            this.tbEmprestimos.ResumeLayout(false);
            this.tbEmprestimos.PerformLayout();
            this.tbDev.ResumeLayout(false);
            this.tbDev.PerformLayout();
            this.listatb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEmprestimoseDevolucoes;
        private System.Windows.Forms.TabPage tbEmprestimos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbDev;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.TextBox txtIdEmprestimo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DateTimePicker dataEmprestimo;
        private System.Windows.Forms.TabPage listatb;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmp;
        private System.Windows.Forms.DateTimePicker dataDeDevolucaoPrevista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataDeDevolucao;
        private System.Windows.Forms.Button btnExibirDev;
        private System.Windows.Forms.Button btnExcluirDev;
        private System.Windows.Forms.Button btnAlterarDev;
        private System.Windows.Forms.Button btnNovoDev;
        private System.Windows.Forms.Button btnProcurarDev;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}