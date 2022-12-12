using System;
using System.Collections.Generic;
using System.Data;
using DTO;
namespace BLL
{
    public class LivroBLL
    {
        public string banco, usuario, senha;

        DAL.LivroDAL dal = null;

        public LivroBLL(string banco, string usuario, string senha)
        {
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;

        }

        public DataTable SelecionarLivros() //seleciona todos os livros 
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                tb = dal.SelectLivros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public void IncluirLivro(Livro livro) //inclui os livros 
        {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                dal.InsertLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarLivro(Livro livro)//altera  os livros 
        {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                dal.UpdateLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLivro(Livro livro) //exclui os livros 
        {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                dal.DeleteLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            public List<Livro> ListarLivros() //lista todos os livros 
        {
                try
                {
                    dal = new DAL.LivroDAL(banco, usuario, senha);
                    return dal.SelectListLivros();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
            
            public Livro ListarLivroPorId(int id) //lista os livros por id
        {
                try
                {
                    dal = new DAL.LivroDAL(banco, usuario, senha);
                    return dal.SelectById(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public Livro ListarLivroPorCodigo(string codigo) //Lista os livros por código
            {
                try
                {
                    dal = new DAL.LivroDAL(banco, usuario, senha);
                    return dal.SelectLivroByCodigo(codigo);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }

