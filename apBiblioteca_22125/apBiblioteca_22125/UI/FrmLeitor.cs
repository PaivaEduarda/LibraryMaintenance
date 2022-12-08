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
                    MessageBox.Show("Leitor alterado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
                MessageBox.Show("Para ocorrer a exclusão é necessário o telefone do leitor!");
            else
            {
                BLL.LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                Leitor x = bll.ListarLeitorPorTelefone(txtTelefone.Text);
                txtIdLeitor.Text = x.IdLeitor + "";
                Leitor leitor = new Leitor(Convert.ToInt32(txtIdLeitor.Text), "", "", "", "");
                try
                {
                    bll.ExcluirLeitor(leitor);
                    MessageBox.Show("Leitor excluido com sucesso!");
                    txtIdLeitor.Text = "";
                    txtNomeLeitor.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtEmail.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
                MessageBox.Show("Para ocorrer a exclusão é necessário o telefone do leitor!");

            else
            {
                try
                {
                    BLL.LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                    Leitor x = bll.ListarLeitorPorTelefone(txtTelefone.Text);

                    txtIdLeitor.Text = x.IdLeitor + "";
                    txtNomeLeitor.Text = x.NomeLeitor;
                    txtEmail.Text = x.EmailLeitor;
                    txtTelefone.Text = x.TelefoneLeitor;
                    txtEndereco.Text = x.EnderecoLeitor;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                dgvLeitor.Rows.Clear();
                DataTable tabela = bll.SelecionarLeitor();
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    if (i != tabela.Rows.Count - 1)
                        dgvLeitor.Rows.Add();
                    dgvLeitor[0, i].Value = tabela.Rows[i][0];
                    dgvLeitor[1, i].Value = tabela.Rows[i][1];
                    dgvLeitor[2, i].Value = tabela.Rows[i][2];
                    dgvLeitor[3, i].Value = tabela.Rows[i][3];
                    dgvLeitor[4, i].Value = tabela.Rows[i][4];

                }

                tcLeitor.SelectTab(tpLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
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
                    MessageBox.Show("Leitor inserido com suceso!");
                    Leitor x = bll.ListarLeitorPorTelefone(txtTelefone.Text);
                    txtIdLeitor.Text = x.IdLeitor + "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }
    }
}
