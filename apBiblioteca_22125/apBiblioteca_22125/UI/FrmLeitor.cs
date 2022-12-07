using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;

namespace apBiblioteca_22125.UI
{
    public partial class FrmLeitor : Form
    {
        public FrmLeitor()
        {
            InitializeComponent();
        }
        public string banco, usuario, senha;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNomeLeitor.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Erro! Preencha os campos!");
            else
            {
                Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text),
                                       txtNomeLeitor.Text,
                                       txtTelefone.Text,
                                       txtEmail.Text,
                                       txtEndereco.Text);
                try
                {
                    BLL.LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                    bll.AlterarLeitor(leitor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNomeLeitor.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Erro! Preencha os campos!");
            else
            {
                Leitor leitor = new Leitor(Convert.ToInt32(txtIdLeitor.Text), "", "", "", "");
                try
                {
                    BLL.LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                    bll.ExcluirLeitor(leitor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int idLeitor = int.Parse(txtIdLeitor.Text);
            Leitor leitor = null;
            if (txtNomeLeitor.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Erro! Preencha os campos!");
            else
            {
                try
                {
                    BLL.LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                    leitor = bll.ListarLeitorPorId(idLeitor);
                    txtNomeLeitor.Text = leitor.NomeLeitor;
                    txtEmail.Text = leitor.EmailLeitor;
                    txtTelefone.Text = leitor.TelefoneLeitor;
                    txtEndereco.Text = leitor.EnderecoLeitor;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
                txtIdLeitor.ReadOnly = false;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (txtNomeLeitor.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Erro! Preencha os campos!");
            else
            {
                try
                {
                    LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    listaLivro.DataSource = bll.SelecionarLivros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            if (txtNomeLeitor.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Erro! Preencha os campos!");
            else
            {
                Leitor leitor = new Leitor(0, "", "", "", "");
                leitor.NomeLeitor = txtNomeLeitor.Text;
                leitor.TelefoneLeitor = txtTelefone.Text;
                leitor.EmailLeitor = txtEmail.Text;
                leitor.EnderecoLeitor = txtEndereco.Text;
                try
                {
                    LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                    bll.IncluirLeitor(leitor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }
    }
}
