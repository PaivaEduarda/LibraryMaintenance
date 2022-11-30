using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;

namespace apBiblioteca_22125.UI
{
    public partial class FrmDevolucao : Form
    {
        public string banco, usuario, senha;
        private DateTime dataEmp;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "" || dataDeDevolucao.Value > dataDeDevolucaoPrevista.Value)
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                Emprestimo empretimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text),
                                    int.Parse(txtIdLivro.Text),
                                    int.Parse(txtIdLeitor.Text),
                                    dataEmp,
                                    dataDeDevolucao.Value, dataDeDevolucaoPrevista.Value);
                try
                {
                    BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    bll.AlterarEmprestimo(empretimo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "" || dataDeDevolucao.Value > dataDeDevolucaoPrevista.Value)
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                Emprestimo emprestimo = new Emprestimo(0, 0, 0, new DateTime(), new DateTime(), new DateTime());
                try
                {
                    BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    bll.ExcluirEmprestimo(emprestimo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "" || dataDeDevolucao.Value > dataDeDevolucaoPrevista.Value)
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                try
                {
                    EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    dgvDevolucao.DataSource = bll.SelecionarEmprestimos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "" || dataDeDevolucao.Value > dataDeDevolucaoPrevista.Value)
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                int identificacao = int.Parse(txtIdEmprestimo.Text);
                Emprestimo emprestimo = null;
                try
                {
                    BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    emprestimo = bll.ListarEmprestimoPorId(identificacao);
                    txtIdLivro.Text = emprestimo.IdLivro.ToString();
                    txtIdLeitor.Text = emprestimo.IdLeitor.ToString();
                    dataDeDevolucao.Value = emprestimo.DataDevolucaoReal;
                    dataEmp = emprestimo.DataEmprestimo;
                    dataDeDevolucaoPrevista.Value = emprestimo.DataDevolucaoPrevista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
                txtIdEmprestimo.ReadOnly = false;
            }
        }

        private void FrmDevolucao_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public FrmDevolucao()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "" || dataDeDevolucao.Value > dataDeDevolucaoPrevista.Value)
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                Emprestimo emprestimo = new Emprestimo(0, 0, 0, new DateTime(), new DateTime(), new DateTime());
                emprestimo.IdLeitor = int.Parse(txtIdLivro.Text);
                emprestimo.IdLeitor = int.Parse(txtIdLeitor.Text);
                emprestimo.DataDevolucaoReal = dataDeDevolucao.Value;
                emprestimo.DataDevolucaoPrevista = dataDeDevolucaoPrevista.Value;

                try
                {
                    EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    bll.IncluirEmprestimo(emprestimo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }
    }
}
