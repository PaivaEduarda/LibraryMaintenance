using System;
using System.Collections.Generic;
using System.Data;
using DTO;

namespace BLL
{
    internal class LeitorBLL
    {
        public string banco, usuario, senha;

        DAL.LeitorDAL dal = null;

        public LeitorBLL(string banco, string usuario, string senha)
        {
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;

        }

        public DataTable SelecionarLeitor()
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                tb = dal.SelectLeitores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        } //seleciona os leitores

        public void IncluirLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                dal.InsertLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //inclui os leitores

        public void AlterarLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                dal.UpdateLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //altera os leitores

        public void ExcluirLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                dal.DeleteLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //exclui os leitores
        public List<Leitor> ListarLeitor()
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectListLeitor();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        } //lista os leitores

        public Leitor ListarLeitorPorId(int id)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //lista os leitores pelo id
        public Leitor ListarLeitorPorTelefone( string telefone)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectByTelefone(telefone);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //lista os leitores pelo telefone

    }
}

