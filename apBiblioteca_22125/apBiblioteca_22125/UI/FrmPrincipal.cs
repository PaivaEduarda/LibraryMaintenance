using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;


namespace apBiblioteca_22125
{
    public partial class FrmPrincipal : Form
    {
        UI.FrmLivro formLivros = null;
        UI.FrmLeitor formLeitores = null;
        UI.FrmEmprestimo formEmprestimo = null;
        UI.FrmDevolucao formDevolucao = null;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void simToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                /*formLeitores = new UI.FrmLeitor();
                formLeitores.banco    = txtBanco.Text;
                formLivros.usuario  = txtUsuario.Text;
                formLivros.senha    = txtSenha.Text;
                formLivros.Show();*/
            }
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formLivros = new UI.FrmLivro();
                formLivros.banco = txtBanco.Text;
                formLivros.usuario = txtUsuario.Text;
                formLivros.senha = txtSenha.Text;
                formLivros.Show();
            }
        }
    }
}
