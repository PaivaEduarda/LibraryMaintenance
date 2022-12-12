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
            } //caso o campo seja vazio
            else
            {

                Livro livro = new Livro(0, "", "", "");
                livro.CodigoLivro = txtCodigoLivro.Text;
                livro.TituloLivro = txtTituloLivro.Text;
                livro.AutorLivro = txtAutorLivro.Text; //recebe os dados digitados no text box
                try
                {
                    LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    bll.IncluirLivro(livro);
                    MessageBox.Show("Livro incluido com sucesso"); 
         
                    Livro x = bll.ListarLivroPorCodigo(txtCodigoLivro.Text);
                    txtIdLivro.Text = x.IdLivro + ""; //adiciona o id do livro
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } // inclui um novo livro
      
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtTituloLivro.Text == "" || txtCodigoLivro.Text == "" || txtAutorLivro.Text == "")
            {
                MessageBox.Show("Erro preencha os campos");
            } //caso o campo seja vazio
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
                    MessageBox.Show("Livro alterado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } //altera os dados do livro

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ( txtCodigoLivro.Text == "")
            {
                MessageBox.Show("Erro preencha os campos");
            } //tem que colocar o código para excluir
            else
            {
                Livro livro = new Livro(Convert.ToInt32(txtIdLivro.Text), txtCodigoLivro.Text, "", "");
                try
                {
                    BLL.LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    bll.ExcluirLivro(livro);
                    txtAutorLivro.Text = "";
                    txtCodigoLivro.Text = "";
                    txtIdLivro.Text = "";
                    txtTituloLivro.Text = ""; //esvazia o text box

                    MessageBox.Show("Livro Excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            } 
        } //exclui os dados do livro

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoLivro.Text;
            Livro livro = null;
            if ( txtCodigoLivro.Text == "" )
            {
                MessageBox.Show("Erro preencha os campos");
            } //tem que digitar o código para procurar
            else
            {
                try
                {
                    BLL.LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    livro = bll.ListarLivroPorCodigo(codigo);
                    txtIdLivro.Text = livro.IdLivro+" ";
                    txtCodigoLivro.Text = livro.CodigoLivro;
                    txtTituloLivro.Text = livro.TituloLivro;
                    txtAutorLivro.Text = livro.AutorLivro; //procura e preenche os campos com os dados encontrados a partir do código
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } //procura os dados do leitor a partir do código

      

        private void btnExibir_Click(object sender, EventArgs e)
        {
                try
                {
                    LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    dgvLivro.Rows.Clear();
                    DataTable tabela = bll.SelecionarLivros();
                    for(int i = 0; i < tabela.Rows.Count; i++)
                    {
                        if (i != tabela.Rows.Count - 1)
                            dgvLivro.Rows.Add();
                        dgvLivro[0, i].Value = tabela.Rows[i][0];
                        dgvLivro[1, i].Value = tabela.Rows[i][1];
                        dgvLivro[2, i].Value = tabela.Rows[i][2];
                        dgvLivro[3, i].Value = tabela.Rows[i][3];
                    }

                    tbLivro.SelectTab(tpLista);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
        } //exibe os dados

        public FrmLivro()
        {
            InitializeComponent();
        }
    }
}
