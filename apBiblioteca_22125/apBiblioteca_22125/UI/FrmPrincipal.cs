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
using System.Data.SqlClient;



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
                formLivros = new UI.FrmLivro();
                formLivros.banco = txtBanco.Text;
                formLivros.usuario = txtUsuario.Text;
                formLivros.senha = txtSenha.Text;
                try
                {
                    string _conexaoSQLServer =
                    $"Data Source = regulus.cotuca.unicamp,br; Initial Catalog = {txtBanco};" +
                    $"User id = {txtUsuario}; passWord = {txtSenha}";
                    SqlConnection _conexao = new SqlConnection(_conexaoSQLServer);
                    _conexao.Open();
                    formEmprestimo.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formLeitores = new UI.FrmLeitor();
                formLeitores.banco = txtBanco.Text;
                formLeitores.usuario = txtUsuario.Text;
                formLeitores.senha = txtSenha.Text;
                try
                {
                    string _conexaoSQLServer =
                    $"Data Source = regulus.cotuca.unicamp,br; Initial Catalog = {txtBanco};" +
                    $"User id = {txtUsuario}; passWord = {txtSenha}";
                    SqlConnection _conexao = new SqlConnection(_conexaoSQLServer);
                    _conexao.Open();
                    formEmprestimo.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formEmprestimo = new UI.FrmEmprestimo();
                formEmprestimo.banco = txtBanco.Text;
                formEmprestimo.usuario = txtUsuario.Text;
                formEmprestimo.senha = txtSenha.Text;
                try
                {
                    string _conexaoSQLServer =
                    $"Data Source = regulus.cotuca.unicamp,br; Initial Catalog = {txtBanco};" +
                    $"User id = {txtUsuario}; passWord = {txtSenha}";
                    SqlConnection _conexao = new SqlConnection(_conexaoSQLServer);
                    _conexao.Open();
                    formEmprestimo.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
                
            }
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formDevolucao = new UI.FrmDevolucao();
                formDevolucao.banco = txtBanco.Text;
                formDevolucao.usuario = txtUsuario.Text;
                formDevolucao.senha = txtSenha.Text;
                try
                {
                    string _conexaoSQLServer =
                    $"Data Source = regulus.cotuca.unicamp,br; Initial Catalog = {txtBanco};" +
                    $"User id = {txtUsuario}; passWord = {txtSenha}";
                    SqlConnection _conexao = new SqlConnection(_conexaoSQLServer);
                    _conexao.Open();
                    formDevolucao.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
                
            }
        }
    }
}


