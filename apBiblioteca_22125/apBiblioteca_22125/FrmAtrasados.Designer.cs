namespace apBiblioteca_22125
{
    partial class FrmAtrasados
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
            this.tcAtrasados = new System.Windows.Forms.TabControl();
            this.tbAtrasados = new System.Windows.Forms.TabPage();
            this.tbLeitoresAtrasados = new System.Windows.Forms.TabPage();
            this.dgvLeitoresAtrasados = new System.Windows.Forms.DataGridView();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLivroAtrasado = new System.Windows.Forms.DataGridView();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAtrasados.SuspendLayout();
            this.tbAtrasados.SuspendLayout();
            this.tbLeitoresAtrasados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitoresAtrasados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivroAtrasado)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAtrasados
            // 
            this.tcAtrasados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAtrasados.Controls.Add(this.tbAtrasados);
            this.tcAtrasados.Controls.Add(this.tbLeitoresAtrasados);
            this.tcAtrasados.Location = new System.Drawing.Point(-2, 1);
            this.tcAtrasados.Name = "tcAtrasados";
            this.tcAtrasados.SelectedIndex = 0;
            this.tcAtrasados.Size = new System.Drawing.Size(551, 448);
            this.tcAtrasados.TabIndex = 0;
            // 
            // tbAtrasados
            // 
            this.tbAtrasados.Controls.Add(this.dgvLivroAtrasado);
            this.tbAtrasados.Location = new System.Drawing.Point(4, 22);
            this.tbAtrasados.Name = "tbAtrasados";
            this.tbAtrasados.Padding = new System.Windows.Forms.Padding(3);
            this.tbAtrasados.Size = new System.Drawing.Size(543, 422);
            this.tbAtrasados.TabIndex = 0;
            this.tbAtrasados.Text = "Livros Atrasados";
            this.tbAtrasados.UseVisualStyleBackColor = true;
            // 
            // tbLeitoresAtrasados
            // 
            this.tbLeitoresAtrasados.Controls.Add(this.dgvLeitoresAtrasados);
            this.tbLeitoresAtrasados.Location = new System.Drawing.Point(4, 22);
            this.tbLeitoresAtrasados.Name = "tbLeitoresAtrasados";
            this.tbLeitoresAtrasados.Padding = new System.Windows.Forms.Padding(3);
            this.tbLeitoresAtrasados.Size = new System.Drawing.Size(543, 422);
            this.tbLeitoresAtrasados.TabIndex = 1;
            this.tbLeitoresAtrasados.Text = "Leitores com livros atrasados";
            this.tbLeitoresAtrasados.UseVisualStyleBackColor = true;
            // 
            // dgvLeitoresAtrasados
            // 
            this.dgvLeitoresAtrasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitoresAtrasados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLeitor,
            this.nomeLeitor,
            this.telefoneLeitor,
            this.emailLeitor,
            this.enderecoLeitor});
            this.dgvLeitoresAtrasados.Location = new System.Drawing.Point(-4, 3);
            this.dgvLeitoresAtrasados.Name = "dgvLeitoresAtrasados";
            this.dgvLeitoresAtrasados.Size = new System.Drawing.Size(800, 423);
            this.dgvLeitoresAtrasados.TabIndex = 0;
            // 
            // idLeitor
            // 
            this.idLeitor.HeaderText = "Id leitor";
            this.idLeitor.Name = "idLeitor";
            this.idLeitor.ReadOnly = true;
            // 
            // nomeLeitor
            // 
            this.nomeLeitor.HeaderText = "Nome Leitor";
            this.nomeLeitor.Name = "nomeLeitor";
            // 
            // telefoneLeitor
            // 
            this.telefoneLeitor.HeaderText = "Telefone Leitor";
            this.telefoneLeitor.Name = "telefoneLeitor";
            // 
            // emailLeitor
            // 
            this.emailLeitor.HeaderText = "Emaiil Leitor";
            this.emailLeitor.Name = "emailLeitor";
            // 
            // enderecoLeitor
            // 
            this.enderecoLeitor.HeaderText = "Endereço Leitor";
            this.enderecoLeitor.Name = "enderecoLeitor";
            // 
            // dgvLivroAtrasado
            // 
            this.dgvLivroAtrasado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLivroAtrasado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivroAtrasado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivro,
            this.codigoLivro,
            this.tituloLivro,
            this.autorLivro});
            this.dgvLivroAtrasado.Location = new System.Drawing.Point(0, 0);
            this.dgvLivroAtrasado.Name = "dgvLivroAtrasado";
            this.dgvLivroAtrasado.Size = new System.Drawing.Size(396, 342);
            this.dgvLivroAtrasado.TabIndex = 0;
            // 
            // idLivro
            // 
            this.idLivro.HeaderText = "Id livro";
            this.idLivro.Name = "idLivro";
            this.idLivro.ReadOnly = true;
            // 
            // codigoLivro
            // 
            this.codigoLivro.HeaderText = "Código livro";
            this.codigoLivro.Name = "codigoLivro";
            // 
            // tituloLivro
            // 
            this.tituloLivro.HeaderText = "Titulo livro";
            this.tituloLivro.Name = "tituloLivro";
            // 
            // autorLivro
            // 
            this.autorLivro.HeaderText = "Autor livro";
            this.autorLivro.Name = "autorLivro";
            // 
            // FrmAtrasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.tcAtrasados);
            this.Name = "FrmAtrasados";
            this.Text = "FrmAtrasados";
            this.tcAtrasados.ResumeLayout(false);
            this.tbAtrasados.ResumeLayout(false);
            this.tbLeitoresAtrasados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitoresAtrasados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivroAtrasado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAtrasados;
        private System.Windows.Forms.TabPage tbAtrasados;
        private System.Windows.Forms.TabPage tbLeitoresAtrasados;
        private System.Windows.Forms.DataGridView dgvLeitoresAtrasados;
        private System.Windows.Forms.DataGridView dgvLivroAtrasado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoLeitor;
    }
}