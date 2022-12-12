using System;
using System.Collections.Generic;
using System.Data;
using DTO;

namespace BLL
{
    internal class EmprestimoBLL
    {
        public string banco, usuario, senha;

        DAL.EmprestimoDAL dal = null;

        public EmprestimoBLL(string banco, string usuario, string senha)
        {
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;

        }

        public DataTable SelecionarEmprestimos() //seleciona todos os empréstimos
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                tb = dal.SelectEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }
        public DataTable SelecionarEmprestimosAtrasados() //seleciona todos os empréstimos
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                tb = dal.SelectEmprestimosAtrasados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public void IncluirEmprestimo(Emprestimo emprestimo) //inclui empréstimos
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                dal.InsertEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarEmprestimo(Emprestimo emprestimo) // altera os empréstimos
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                dal.UpdateEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirEmprestimo(Emprestimo emprestimo) //exclui os empréstimos
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                dal.DeleteEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Emprestimo> ListarEmprestimo() //lista os empréstimos
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectListEmprestimo();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public Emprestimo ListarEmprestimoPorIdLeitor(int idLeitor) // lista os empréstimos pelo id do leitor
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectByIdLeitor(idLeitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Emprestimo ListarEmprestimoPorIdLivro(int idLivro) // lista os empréstimos pelo id do livro
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectByIdLivro(idLivro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Emprestimo ListarEmprestimoPorId(int id) // lista os empréstimos pelo id do empréstimo
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

