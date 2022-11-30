namespace apBiblioteca_22125.UI
{
    partial class FrmDevolucao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDevolucao = new System.Windows.Forms.TabPage();
            this.dataDeDevolucaoPrevista = new System.Windows.Forms.DateTimePicker();
            this.dataDeDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtIdEmprestimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLista = new System.Windows.Forms.TabPage();
            this.dgvDevolucao = new System.Windows.Forms.DataGridView();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbDevolucao.SuspendLayout();
            this.tbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbDevolucao);
            this.tabControl1.Controls.Add(this.tbLista);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 304);
            this.tabControl1.TabIndex = 0;
            // 
            // tbDevolucao
            // 
            this.tbDevolucao.Controls.Add(this.dataDeDevolucaoPrevista);
            this.tbDevolucao.Controls.Add(this.dataDeDevolucao);
            this.tbDevolucao.Controls.Add(this.label3);
            this.tbDevolucao.Controls.Add(this.btnExibir);
            this.tbDevolucao.Controls.Add(this.btnExcluir);
            this.tbDevolucao.Controls.Add(this.btnAlterar);
            this.tbDevolucao.Controls.Add(this.btnNovo);
            this.tbDevolucao.Controls.Add(this.btnProcurar);
            this.tbDevolucao.Controls.Add(this.txtIdLeitor);
            this.tbDevolucao.Controls.Add(this.txtIdLivro);
            this.tbDevolucao.Controls.Add(this.txtIdEmprestimo);
            this.tbDevolucao.Controls.Add(this.label5);
            this.tbDevolucao.Controls.Add(this.label4);
            this.tbDevolucao.Controls.Add(this.label2);
            this.tbDevolucao.Controls.Add(this.label1);
            this.tbDevolucao.Location = new System.Drawing.Point(4, 22);
            this.tbDevolucao.Name = "tbDevolucao";
            this.tbDevolucao.Padding = new System.Windows.Forms.Padding(3);
            this.tbDevolucao.Size = new System.Drawing.Size(425, 278);
            this.tbDevolucao.TabIndex = 0;
            this.tbDevolucao.Text = "Devolução de livros";
            this.tbDevolucao.UseVisualStyleBackColor = true;
            // 
            // dataDeDevolucaoPrevista
            // 
            this.dataDeDevolucaoPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDeDevolucaoPrevista.Location = new System.Drawing.Point(170, 190);
            this.dataDeDevolucaoPrevista.Name = "dataDeDevolucaoPrevista";
            this.dataDeDevolucaoPrevista.Size = new System.Drawing.Size(83, 20);
            this.dataDeDevolucaoPrevista.TabIndex = 18;
            // 
            // dataDeDevolucao
            // 
            this.dataDeDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDeDevolucao.Location = new System.Drawing.Point(170, 157);
            this.dataDeDevolucao.Name = "dataDeDevolucao";
            this.dataDeDevolucao.Size = new System.Drawing.Size(83, 20);
            this.dataDeDevolucao.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data de devolução previsto:";
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(320, 233);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 14;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(216, 233);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(118, 233);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(20, 233);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(307, 35);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(170, 75);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(102, 20);
            this.txtIdLeitor.TabIndex = 8;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(170, 117);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(102, 20);
            this.txtIdLivro.TabIndex = 6;
            // 
            // txtIdEmprestimo
            // 
            this.txtIdEmprestimo.Location = new System.Drawing.Point(170, 37);
            this.txtIdEmprestimo.Name = "txtIdEmprestimo";
            this.txtIdEmprestimo.Size = new System.Drawing.Size(102, 20);
            this.txtIdEmprestimo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Identificação do Leitor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identificação do Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Devolução:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação de Emprestimo: ";
            // 
            // tbLista
            // 
            this.tbLista.Controls.Add(this.dgvDevolucao);
            this.tbLista.Location = new System.Drawing.Point(4, 22);
            this.tbLista.Name = "tbLista";
            this.tbLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbLista.Size = new System.Drawing.Size(425, 278);
            this.tbLista.TabIndex = 1;
            this.tbLista.Text = "Lista";
            this.tbLista.UseVisualStyleBackColor = true;
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.idLivro,
            this.idLeitor,
            this.dataDevolucao});
            this.dgvDevolucao.Location = new System.Drawing.Point(-4, 0);
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.ReadOnly = true;
            this.dgvDevolucao.Size = new System.Drawing.Size(433, 282);
            this.dgvDevolucao.TabIndex = 0;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idEmprestimo.HeaderText = "Id Empréstimo:";
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            this.idEmprestimo.Width = 101;
            // 
            // idLivro
            // 
            this.idLivro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idLivro.HeaderText = "Id Livro:";
            this.idLivro.Name = "idLivro";
            this.idLivro.ReadOnly = true;
            this.idLivro.Width = 70;
            // 
            // idLeitor
            // 
            this.idLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idLeitor.HeaderText = "Id Leitor:";
            this.idLeitor.Name = "idLeitor";
            this.idLeitor.ReadOnly = true;
            this.idLeitor.Width = 73;
            // 
            // dataDevolucao
            // 
            this.dataDevolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDevolucao.HeaderText = "Data de devolução:";
            this.dataDevolucao.Name = "dataDevolucao";
            this.dataDevolucao.ReadOnly = true;
            this.dataDevolucao.Width = 115;
            // 
            // FrmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 305);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDevolucao";
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.FrmDevolucao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbDevolucao.ResumeLayout(false);
            this.tbDevolucao.PerformLayout();
            this.tbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDevolucao;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtIdEmprestimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbLista;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataDeDevolucaoPrevista;
        private System.Windows.Forms.DateTimePicker dataDeDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucao;
    }
}