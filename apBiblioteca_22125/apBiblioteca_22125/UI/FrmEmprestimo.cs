using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;

namespace apBiblioteca_22125.UI
{
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
        {
            InitializeComponent();
        }
        public string banco, usuario, senha;
        private DateTime dataDev;
        private DateTime dataDevPrev;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
            {
                Emprestimo empretimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text),
                                       int.Parse(txtIdLivro.Text),
                                       int.Parse(txtIdLeitor.Text),
                                       dataEmprestimo.Value,
                                       dataDev, dataDevPrev);
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
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
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
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
            {
                try
                {
                    EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    dgvEmprestimo.DataSource = bll.SelecionarEmprestimos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
            {
                Emprestimo emprestimo = new Emprestimo(0, 0, 0, new DateTime(), new DateTime(), new DateTime());
                emprestimo.IdLeitor = int.Parse(txtIdLivro.Text);
                emprestimo.IdLeitor = int.Parse(txtIdLeitor.Text);
                emprestimo.DataEmprestimo = dataEmprestimo.Value;

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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int identificacao = int.Parse(txtIdEmprestimo.Text);
            Emprestimo emprestimo = null;

            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
            {
                try
                {
                    BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    emprestimo = bll.ListarEmprestimoPorId(identificacao);
                    txtIdLivro.Text = emprestimo.IdLivro.ToString();
                    txtIdLeitor.Text = emprestimo.IdLeitor.ToString();
                    dataEmprestimo.Value = emprestimo.DataEmprestimo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
                txtIdEmprestimo.ReadOnly = false;
            }
        }

    }
}
