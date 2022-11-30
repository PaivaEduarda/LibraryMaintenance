using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace apBiblioteca_22125.UI
{
    public partial class FrmLivro : Form
    {
        public string banco, usuario, senha;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtTituloLivro.Text == "" || txtCodigoLivro.Text == "" || txtAutorLivro.Text == "")
            {
                MessageBox.Show("Erro preencha os campos");
            }
            else
            {

                Livro livro = new Livro(0, "", "", "");
                livro.CodigoLivro = txtCodigoLivro.Text;
                livro.TituloLivro = txtTituloLivro.Text;
                livro.AutorLivro = txtAutorLivro.Text;
                try
                {
                    LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    bll.IncluirLivro(livro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtTituloLivro.Text == "" || txtCodigoLivro.Text == "" || txtAutorLivro.Text == "")
            {
                MessageBox.Show("Erro preencha os campos");
            }
            else
            {
                Livro livro = new Livro(int.Parse(txtIdLivro.Text),
                                    txtCodigoLivro.Text,
                                    txtTituloLivro.Text,
                                    txtAutorLivro.Text);
                try
                {
                    BLL.LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    bll.AlterarLivro(livro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtTituloLivro.Text == "" || txtCodigoLivro.Text == "" || txtAutorLivro.Text == "")
            {
                MessageBox.Show("Erro preencha os campos");
            }
            else
            {
                Livro livro = new Livro(Convert.ToInt32(txtIdLivro.Text), "", "", "");
                try
                {
                    BLL.LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    bll.ExcluirLivro(livro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            } 
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string codigo = txtIdLivro.Text;
            Livro livro = null;
            if (txtTituloLivro.Text == "" || txtCodigoLivro.Text == "" || txtAutorLivro.Text == "")
            {
                MessageBox.Show("Erro preencha os campos");
            }
            else
            {
                try
                {
                    BLL.LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    livro = bll.ListarLivroPorCodigo(codigo);
                    txtCodigoLivro.Text = livro.CodigoLivro;
                    txtTituloLivro.Text = livro.TituloLivro;
                    txtAutorLivro.Text = livro.AutorLivro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
                txtIdLivro.ReadOnly = false;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (txtTituloLivro.Text == "" || txtCodigoLivro.Text == "" || txtAutorLivro.Text == "")
            {
                MessageBox.Show("Erro preencha os campos");
            }
            else
            {
                try
                {
                    LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    dgvLivro.DataSource = bll.SelecionarLivros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        public FrmLivro()
        {
            InitializeComponent();
        }
    }
}
