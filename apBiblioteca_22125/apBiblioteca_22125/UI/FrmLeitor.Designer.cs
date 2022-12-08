namespace apBiblioteca_22125.UI
{
    partial class FrmLeitor
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
            this.tcLeitor = new System.Windows.Forms.TabControl();
            this.tpLeitores = new System.Windows.Forms.TabPage();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.dgvLeitor = new System.Windows.Forms.DataGridView();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcLeitor.SuspendLayout();
            this.tpLeitores.SuspendLayout();
            this.tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // tcLeitor
            // 
            this.tcLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcLeitor.Controls.Add(this.tpLeitores);
            this.tcLeitor.Controls.Add(this.tpLista);
            this.tcLeitor.Location = new System.Drawing.Point(1, 2);
            this.tcLeitor.Name = "tcLeitor";
            this.tcLeitor.SelectedIndex = 0;
            this.tcLeitor.Size = new System.Drawing.Size(554, 265);
            this.tcLeitor.TabIndex = 0;
            // 
            // tpLeitores
            // 
            this.tpLeitores.Controls.Add(this.btnExibir);
            this.tpLeitores.Controls.Add(this.btnExcluir);
            this.tpLeitores.Controls.Add(this.btnAlterar);
            this.tpLeitores.Controls.Add(this.btnNovo);
            this.tpLeitores.Controls.Add(this.btnProcurar);
            this.tpLeitores.Controls.Add(this.txtNomeLeitor);
            this.tpLeitores.Controls.Add(this.txtTelefone);
            this.tpLeitores.Controls.Add(this.txtEmail);
            this.tpLeitores.Controls.Add(this.txtEndereco);
            this.tpLeitores.Controls.Add(this.txtIdLeitor);
            this.tpLeitores.Controls.Add(this.label5);
            this.tpLeitores.Controls.Add(this.label4);
            this.tpLeitores.Controls.Add(this.label3);
            this.tpLeitores.Controls.Add(this.label2);
            this.tpLeitores.Controls.Add(this.label1);
            this.tpLeitores.Location = new System.Drawing.Point(4, 22);
            this.tpLeitores.Name = "tpLeitores";
            this.tpLeitores.Padding = new System.Windows.Forms.Padding(3);
            this.tpLeitores.Size = new System.Drawing.Size(546, 239);
            this.tpLeitores.TabIndex = 0;
            this.tpLeitores.Text = "Leitores";
            this.tpLeitores.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(350, 178);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 15;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(269, 178);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(188, 178);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(107, 178);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(256, 14);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 11;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(84, 43);
            this.txtNomeLeitor.MaxLength = 50;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(278, 20);
            this.txtNomeLeitor.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(84, 69);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(278, 20);
            this.txtTelefone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 97);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(84, 126);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(278, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(84, 12);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.ReadOnly = true;
            this.txtIdLeitor.Size = new System.Drawing.Size(127, 20);
            this.txtIdLeitor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação:";
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.dgvLeitor);
            this.tpLista.Location = new System.Drawing.Point(4, 22);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(546, 239);
            this.tpLista.TabIndex = 1;
            this.tpLista.Text = "Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // dgvLeitor
            // 
            this.dgvLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLeitor,
            this.nomeLeitor,
            this.telefoneLeitor,
            this.EmailLeitor,
            this.enderecoLeitor});
            this.dgvLeitor.Location = new System.Drawing.Point(0, 3);
            this.dgvLeitor.Name = "dgvLeitor";
            this.dgvLeitor.Size = new System.Drawing.Size(543, 236);
            this.dgvLeitor.TabIndex = 0;
            // 
            // idLeitor
            // 
            this.idLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idLeitor.HeaderText = "Identificação leitor:";
            this.idLeitor.Name = "idLeitor";
            this.idLeitor.ReadOnly = true;
            this.idLeitor.Width = 111;
            // 
            // nomeLeitor
            // 
            this.nomeLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeLeitor.HeaderText = "Nome do Leitor:";
            this.nomeLeitor.MaxInputLength = 50;
            this.nomeLeitor.Name = "nomeLeitor";
            this.nomeLeitor.Width = 98;
            // 
            // telefoneLeitor
            // 
            this.telefoneLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefoneLeitor.HeaderText = "Telefone do Leitor:";
            this.telefoneLeitor.MaxInputLength = 20;
            this.telefoneLeitor.Name = "telefoneLeitor";
            this.telefoneLeitor.Width = 85;
            // 
            // EmailLeitor
            // 
            this.EmailLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailLeitor.HeaderText = "Email do Leitor:";
            this.EmailLeitor.MaxInputLength = 50;
            this.EmailLeitor.Name = "EmailLeitor";
            this.EmailLeitor.Width = 96;
            // 
            // enderecoLeitor
            // 
            this.enderecoLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enderecoLeitor.HeaderText = "Endereço do Leitor:";
            this.enderecoLeitor.MaxInputLength = 100;
            this.enderecoLeitor.Name = "enderecoLeitor";
            this.enderecoLeitor.Width = 88;
            // 
            // FrmLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 267);
            this.Controls.Add(this.tcLeitor);
            this.Name = "FrmLeitor";
            this.Text = "Manutenção dos leitores";
            this.tcLeitor.ResumeLayout(false);
            this.tpLeitores.ResumeLayout(false);
            this.tpLeitores.PerformLayout();
            this.tpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLeitor;
        private System.Windows.Forms.TabPage tpLeitores;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.DataGridView dgvLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoLeitor;
    }
}