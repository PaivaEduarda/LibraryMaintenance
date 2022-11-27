﻿using System;
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

        public DataTable SelecionarLivros()
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

        public void IncluirLivro(Livro livro)
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

        public void AlterarLivro(Livro livro)
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

        public void ExcluirLivro(Livro livro)
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
            public List<Livro> ListarLivros()
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
            
            public Livro ListarLivroPorId(int id)
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

            public Livro ListarLivroPorCodigo(string codigo)
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

