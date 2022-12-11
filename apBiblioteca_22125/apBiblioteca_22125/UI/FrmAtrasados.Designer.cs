namespace apBiblioteca_22125.UI
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
            this.dgvAtrasados = new System.Windows.Forms.DataGridView();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucaoReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAtrasados.SuspendLayout();
            this.tbAtrasados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtrasados)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAtrasados
            // 
            this.tcAtrasados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAtrasados.Controls.Add(this.tbAtrasados);
            this.tcAtrasados.Location = new System.Drawing.Point(-2, 1);
            this.tcAtrasados.Name = "tcAtrasados";
            this.tcAtrasados.SelectedIndex = 0;
            this.tcAtrasados.Size = new System.Drawing.Size(551, 207);
            this.tcAtrasados.TabIndex = 0;
            // 
            // tbAtrasados
            // 
            this.tbAtrasados.Controls.Add(this.dgvAtrasados);
            this.tbAtrasados.Location = new System.Drawing.Point(4, 22);
            this.tbAtrasados.Name = "tbAtrasados";
            this.tbAtrasados.Padding = new System.Windows.Forms.Padding(3);
            this.tbAtrasados.Size = new System.Drawing.Size(543, 181);
            this.tbAtrasados.TabIndex = 0;
            this.tbAtrasados.Text = "Devoluções atrasadas";
            this.tbAtrasados.UseVisualStyleBackColor = true;
            // 
            // dgvAtrasados
            // 
            this.dgvAtrasados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtrasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtrasados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivro,
            this.codigoLivro,
            this.tituloLivro,
            this.autorLivro,
            this.dataDevolucaoReal});
            this.dgvAtrasados.Location = new System.Drawing.Point(0, 0);
            this.dgvAtrasados.Name = "dgvAtrasados";
            this.dgvAtrasados.Size = new System.Drawing.Size(543, 165);
            this.dgvAtrasados.TabIndex = 0;
            // 
            // idLivro
            // 
            this.idLivro.HeaderText = "Id empréstimo";
            this.idLivro.Name = "idLivro";
            this.idLivro.ReadOnly = true;
            // 
            // codigoLivro
            // 
            this.codigoLivro.HeaderText = "Id Livro";
            this.codigoLivro.Name = "codigoLivro";
            // 
            // tituloLivro
            // 
            this.tituloLivro.HeaderText = "Id leitor";
            this.tituloLivro.Name = "tituloLivro";
            // 
            // autorLivro
            // 
            this.autorLivro.HeaderText = "Data Devolução Prevista";
            this.autorLivro.Name = "autorLivro";
            // 
            // dataDevolucaoReal
            // 
            this.dataDevolucaoReal.HeaderText = "Data de devolução real";
            this.dataDevolucaoReal.Name = "dataDevolucaoReal";
            // 
            // FrmAtrasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 209);
            this.Controls.Add(this.tcAtrasados);
            this.Name = "FrmAtrasados";
            this.Text = "Devoluções Atrasadas";
            this.Load += new System.EventHandler(this.FrmAtrasados_Load);
            this.tcAtrasados.ResumeLayout(false);
            this.tbAtrasados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtrasados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAtrasados;
        private System.Windows.Forms.TabPage tbAtrasados;
        private System.Windows.Forms.DataGridView dgvAtrasados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucaoReal;
    }
}