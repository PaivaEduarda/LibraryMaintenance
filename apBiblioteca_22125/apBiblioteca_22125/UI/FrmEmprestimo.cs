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


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ( txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos id livro para alterar o empréstimo"); // é necessário preencher os campos Id livro para alterar o empréstimo
            else
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                Emprestimo x = bll.ListarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));
                txtIdEmprestimo.Text = x.IdEmprestimo + ""; //adiciona o id do empréstimo na tela

                Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text),
                                       int.Parse(txtIdLivro.Text),
                                       int.Parse(txtIdLeitor.Text),
                                       dataEmprestimo.Value.Date , dataDeDevolucaoPrevista.Value.Date
                                       , dataDeDevolucao.Value.Date);
                try
                {
                    bll.AlterarEmprestimo(emprestimo);
                    MessageBox.Show("Emprestimo alterado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } //altera os empréstimos

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");

            else
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                Emprestimo x = bll.ListarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));
                txtIdEmprestimo.Text = x.IdEmprestimo + "";

                Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), 0, 0, new DateTime(), new DateTime(), new DateTime());
                try
                {
                    bll.ExcluirEmprestimo(emprestimo);
                    MessageBox.Show("Emprestimo excluído com sucesso!");
                    txtIdEmprestimo.Text = "";
                    txtIdLeitor.Text = "";
                    txtIdLivro.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } //exclui empréstimos
        public void ExcluirEmprestimo(int idEmprestimo)
        {

            if (txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");

            else
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                Emprestimo x = bll.ListarEmprestimoPorId(idEmprestimo);
                txtIdDevEmprestimo.Text = x.IdEmprestimo + "";

                Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), 0, 0, new DateTime(), new DateTime(), new DateTime()); 
                try
                {
                    bll.ExcluirEmprestimo(emprestimo);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } //exclui empréstimo
        private void btnExibir_Click(object sender, EventArgs e)
        {

            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                dgvEmprestimo.Rows.Clear();
                DataTable tabela = bll.SelecionarEmprestimos();
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    if (i != tabela.Rows.Count - 1)
                        dgvEmprestimo.Rows.Add();
                    dgvEmprestimo[0, i].Value = tabela.Rows[i][0];
                    dgvEmprestimo[1, i].Value = tabela.Rows[i][1];
                    dgvEmprestimo[2, i].Value = tabela.Rows[i][2];
                    dgvEmprestimo[3, i].Value = tabela.Rows[i][3];
                    dgvEmprestimo[4, i].Value = tabela.Rows[i][4];
                    dgvEmprestimo[5, i].Value = tabela.Rows[i][5];

                }
                tcEmprestimoseDevolucoes.SelectTab(listatb);
            } //exibe todos os empréstimos em data grid view
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                Emprestimo livrosEmprestados = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text));
                Emprestimo emprestimo = new Emprestimo(0, 0, 0, new DateTime(), new DateTime(), new DateTime());
                Emprestimo livroIdEmprestado = bll.ListarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));
                emprestimo.IdLivro = int.Parse(txtIdLivro.Text);
                emprestimo.IdLeitor = int.Parse(txtIdLeitor.Text);
                emprestimo.DataEmprestimo = dataEmprestimo.Value.Date;
                emprestimo.DataDevolucaoPrevista = dataDeDevolucaoPrevista.Value.Date;
                emprestimo.DataDevolucaoReal = dataDeDevolucao.Value.Date;
               


                try
                {
                    bll = new EmprestimoBLL(banco, usuario, senha);
                    Emprestimo emprestimos = bll.ListarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));
                    if (emprestimos == null) //se não retornar algum empréstimo com esse livro
                    {
                        bll.IncluirEmprestimo(emprestimo);
                        MessageBox.Show("Emprestimo incluido com sucesso!");
                        Emprestimo x = bll.ListarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));
                        txtIdEmprestimo.Text = x.IdEmprestimo + "";
                    }
                    else
                        MessageBox.Show("Livro Emprestado!"); //se não o livro está emprestado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
                
            }

        } //adiciona um novo empréstimo

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
            Emprestimo x = bll.ListarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));
            if (x == null)
                MessageBox.Show("Empréstimo inexistente!"); //para devolver um livro, ele tem que estar emprestado
            else
            {
                txtIdEmprestimo.Text = x.IdEmprestimo + "";
                Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), int.Parse(txtIdLeitor.Text), int.Parse(txtIdLivro.Text), dataEmprestimo.Value.Date, dataDeDevolucaoPrevista.Value.Date, dataDeDevolucao.Value.Date);


                if (txtIdLeitor.Text == "" & txtIdLivro.Text == "")
                    MessageBox.Show("Erro! Preencha os campos corretamente!");
                else
                {
                    try
                    {
                        if (bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text)) != null)//ele procura por leitor, se existir um empréstimo com esse leitor
                        {
                            emprestimo = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text));
                        }
                        else
                            if (bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLivro.Text)) != null) //se não tiver com o id do leitor, se não, tentar com o id livro
                        {
                            emprestimo = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLivro.Text));
                        }
                        else
                            MessageBox.Show("Empréstimo inexistente");
                        txtIdLivro.Text = emprestimo.IdLivro + "";
                        txtIdLeitor.Text = emprestimo.IdLeitor + "";
                        dataEmprestimo.Value = emprestimo.DataEmprestimo;
                        dataDeDevolucaoPrevista.Value = emprestimo.DataDevolucaoPrevista;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Erro : " + ex.Message.ToString());
                    }
                }
            }
        }

        //BOTÕES DA DEVOLUÇÃO
        private void btnProcurarDev_Click(object sender, EventArgs e)
        {
            if (txtIdDevEmprestimo.Text == "")
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                try
                {
                    BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);

                    Emprestimo x = bll.ListarEmprestimoPorId(int.Parse(txtIdDevEmprestimo.Text));
                    dataDeDevolucaoPrevista.Value = x.DataDevolucaoPrevista;
                    dataEmprestimo.Value = x.DataEmprestimo;

                    if (dataDeDevolucao.Value.Date > dataDeDevolucaoPrevista.Value.Date)
                        MessageBox.Show("Livro atrasado!"); //se a data de devolução for maior que a data prevista, então o livro está atrasado

                   
                    Emprestimo emprestimo = bll.ListarEmprestimoPorId(int.Parse(txtIdDevEmprestimo.Text));
                   
                    txtIdDevLivro.Text = emprestimo.IdLivro.ToString();
                    txtIdDevLeitor.Text = emprestimo.IdLeitor.ToString();
                    dataDeDevolucao.Value = emprestimo.DataDevolucaoReal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } //procura uma devolução 

        private void btnExcluirDev_Click(object sender, EventArgs e)
        {
            if (txtIdDevLeitor.Text == "" || txtIdDevLivro.Text == "")
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdDevEmprestimo.Text), 0, 0, new DateTime(), new DateTime(), new DateTime());
                try
                {
                    BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    bll.ExcluirEmprestimo(emprestimo);
                    MessageBox.Show("Devolução deletada com sucesso!");
                    txtIdDevEmprestimo.Text = "";
                    txtIdDevLeitor.Text = "";
                    txtIdDevLivro.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } //exclui devolucao

        private void btnExibirDev_Click(object sender, EventArgs e)
        {
                try
                {
                    EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    dgvEmprestimo.Rows.Clear();
                    DataTable tabela = bll.SelecionarEmprestimos();
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        if (i != tabela.Rows.Count - 1)
                            dgvEmprestimo.Rows.Add();
                        dgvEmprestimo[0, i].Value = tabela.Rows[i][0];
                        dgvEmprestimo[1, i].Value = tabela.Rows[i][1];
                        dgvEmprestimo[2, i].Value = tabela.Rows[i][2];
                        dgvEmprestimo[3, i].Value = tabela.Rows[i][3];
                        dgvEmprestimo[4, i].Value = tabela.Rows[i][4];
                        dgvEmprestimo[5, i].Value = tabela.Rows[i][5];
                    }
                    tcEmprestimoseDevolucoes.SelectTab(listatb);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
         
        } //exibe todas as devoluções no dataGridView

        private void btnNovoDev_Click(object sender, EventArgs e)
        {
            if (txtIdDevEmprestimo.Text == "" || txtIdDevLeitor.Text == "" || txtIdDevLivro.Text == "")
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                Emprestimo emprestimo = new Emprestimo(0, 0, 0, new DateTime(), new DateTime(), new DateTime());
                emprestimo.IdEmprestimo = int.Parse(txtIdDevEmprestimo.Text);
                emprestimo.IdLivro = int.Parse(txtIdDevLivro.Text);
                emprestimo.IdLeitor = int.Parse(txtIdDevLeitor.Text);
                emprestimo.DataDevolucaoReal = dataDeDevolucao.Value.Date;
                emprestimo.DataDevolucaoPrevista = dataDeDevolucaoPrevista.Value.Date;
                emprestimo.DataEmprestimo = dataEmprestimo.Value.Date;
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);

                if (bll.ListarEmprestimoPorIdLivro(int.Parse(txtIdDevLivro.Text)) == null && bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdDevLeitor.Text)) == null)
                    MessageBox.Show("Erro de devolução, verifique o id do leitor e o id do livro!");
                else
                {
                    if (dataDeDevolucao.Value.Date < dataEmprestimo.Value.Date)
                        MessageBox.Show("Erro, preencha os campos corretamente!");
                    else
                    {
                        if (dataDeDevolucao.Value > dataDeDevolucaoPrevista.Value)
                            MessageBox.Show("Livro atrasado!!!!!"); //data de devolução maior que a prevista, a devolução está atrasada
                        try
                        {
                            bll.IncluirEmprestimo(emprestimo);
                            MessageBox.Show("Devolução concluído com sucesso!");
                            ExcluirEmprestimo(int.Parse(txtIdDevEmprestimo.Text)); //exclui um empréstimo
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" Erro : " + ex.Message.ToString());
                        }
                    }
                }
            }

        } //adiciona uma nova devolução

        private void btnAlterarDev_Click(object sender, EventArgs e)
        {
            if (txtIdDevLeitor.Text == "" || txtIdDevLivro.Text == "" || txtIdDevEmprestimo.Text == "")
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                Emprestimo x = bll.ListarEmprestimoPorId(int.Parse(txtIdDevEmprestimo.Text));
                dataDeDevolucaoPrevista.Value = x.DataDevolucaoPrevista ;
                dataEmprestimo.Value = x.DataEmprestimo;
                if (dataDeDevolucao.Value > dataDeDevolucaoPrevista.Value)
                    MessageBox.Show("Devolução atrasada");
                Emprestimo empretimo = new Emprestimo(int.Parse(txtIdDevEmprestimo.Text),
                                    int.Parse(txtIdDevLivro.Text),
                                    int.Parse(txtIdDevLeitor.Text),
                                    dataEmprestimo.Value,
                                    dataDeDevolucao.Value, dataDeDevolucaoPrevista.Value);
                try
                {
                    bll.AlterarEmprestimo(empretimo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        } //altera as devoluções
    }
}
