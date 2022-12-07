﻿using System;
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
            if (txtIdEmprestimo.Text == "" || txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
            {
                Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text),
                                       int.Parse(txtIdLivro.Text),
                                       int.Parse(txtIdLeitor.Text),
                                       dataEmprestimo.Value,
                                       dataDeDevolucao.Value, dataDeDevolucaoPrevista.Value);
                try
                {
                    BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    bll.AlterarEmprestimo(emprestimo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");

            else
            {
                Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), 0, 0, new DateTime(), new DateTime(), new DateTime());
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
        public void ExcluirEmprestimo(int idLeitor, int idLivro)
        {

            Emprestimo emprestimo = new Emprestimo(0, idLeitor, idLivro, new DateTime(), new DateTime(), new DateTime());
            try
            {
                BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                bll.ExcluirEmprestimo(emprestimo);
                MessageBox.Show("Livro Exlcluído com sucesso!");
                txtIdEmprestimo.Text = "";
                txtIdLeitor.Text = "";
                txtIdLivro.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }
        public Boolean livrosAtrasados()
        {
            Emprestimo livro = null;
            EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
            Emprestimo livrosEmprestados = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text));

            if (livrosEmprestados.DataDevolucaoReal > livrosEmprestados.DataDevolucaoPrevista)
                return true;
            else
                return false;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
            {
                Emprestimo empr = null;
                Emprestimo findByLeitor = null;
                Emprestimo findByLivro = null;
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                Emprestimo livrosEmprestados = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text));
                Emprestimo emprestimo = new Emprestimo(0, 0, 0, new DateTime(), new DateTime(), new DateTime());
                Emprestimo livroIdEmprestado = bll.ListarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));

                Boolean livroEmprestado = livrosAtrasados();
                if (livroIdEmprestado != null)
                    MessageBox.Show("Livro já emprestado");
                else
                {
                    if (livroEmprestado == true)
                    {
                        MessageBox.Show("Livro(s) atrasado(s), bloqueado por  5 dias");

                        if (livrosEmprestados.DataDevolucaoReal == livrosEmprestados.DataDevolucaoReal.AddDays(5))
                            livroEmprestado = false;

                    }
                    else
                    {
                        emprestimo.IdLeitor = int.Parse(txtIdLivro.Text);
                        emprestimo.IdLeitor = int.Parse(txtIdLeitor.Text);
                        emprestimo.DataEmprestimo = dataEmprestimo.Value;
                        emprestimo.DataDevolucaoReal = dataDeDevolucao.Value;
                    }


                    try
                    {
                        bll = new EmprestimoBLL(banco, usuario, senha);
                        bll.IncluirEmprestimo(emprestimo);
                        MessageBox.Show("Emprestimo incluido com sucesso!");
                        findByLeitor = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text));
                        findByLeitor = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLivro.Text));
                        if (findByLeitor != null)
                        {
                            empr = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text));
                        }
                        else
                            if (findByLivro != null)
                        {
                            empr = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLivro.Text));
                        }
                        Emprestimo x = empr;
                        txtIdLivro.Text = x.IdLivro + "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Erro : " + ex.Message.ToString());
                    }
                }
            }

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = null;
            Emprestimo findByLeitor = null;
            Emprestimo findByLivro = null;


            if (txtIdLeitor.Text == "" & txtIdLivro.Text == "")
                MessageBox.Show("Erro! Preencha os campos corretamente!");
            else
            {
                try
                {
                    BLL.EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                    findByLeitor = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text));
                    findByLeitor = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLivro.Text));
                    if (findByLeitor != null)
                    {
                        emprestimo = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLeitor.Text));
                    }
                    else
                        if (findByLivro != null)
                    {
                        emprestimo = bll.ListarEmprestimoPorIdLeitor(int.Parse(txtIdLivro.Text));
                    }
                    txtIdLivro.Text = emprestimo.IdLivro.ToString();
                    txtIdLeitor.Text = emprestimo.IdLeitor.ToString();
                    dataEmprestimo.Value = emprestimo.DataEmprestimo;
                    dataDeDevolucao.Value = emprestimo.DataDevolucaoReal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        //BOTÕES DA DEVOLUÇÃO
        private void btnProcurarDev_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                MessageBox.Show("Erro ao preencher os campos");
            else
            {
                int identificacao = int.Parse(txtIdEmprestimo.Text);
                Emprestimo emprestimo = null;
                try
                {
                    if (dataDeDevolucao.Value > dataDeDevolucaoPrevista.Value)
                        MessageBox.Show("Livro atrasado!");
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

        private void btnExcluirDev_Click(object sender, EventArgs e)
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

        private void btnExibirDev_Click(object sender, EventArgs e)
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

        private void btnNovoDev_Click(object sender, EventArgs e)
        {
            if (livrosEmprestados == null && livroIdEmprestado == null)
                MessageBox.Show("Erro de devolução, verifique o id do leitor e o id do livro!");
            else
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
                        ExcluirEmprestimo(int.Parse(txtIdLeitor.Text), int.Parse(txtIdLivro.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Erro : " + ex.Message.ToString());
                    }
                }
            }

        }

        private void btnAlterarDev_Click(object sender, EventArgs e)
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
    }
}
