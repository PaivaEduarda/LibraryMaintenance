﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
using BLL;
using DAL;

namespace DAL
{
    public class EmprestimoDAL
    {
        string _conexaoSQLServer = "";
        SqlConnection _conexao = null;

        public EmprestimoDAL(string banco, string usuario, string senha)
        {
            _conexaoSQLServer =
                "Data Source = regulus.cotuca.unicamp,br; Initial Catalog = {banco};" +
                $"User id = {usuario}; passWord = {senha}";
        }
        public List<Emprestimo> SelectListEmprestimo()    // retorna uma lista de Livros, ou seja, um objeto da classe List<Livro> com os
                                                          // livros selecionados;
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand command =
                    new SqlCommand("Select * from bibEmprestimo", conn))
                    {
                        conn.Open();
                        List<Emprestimo> listaEmprestimo = new List<Emprestimo>();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo(
                                (int)dr["idEmprestimo"],
                                (int)dr["idLeitor"],
                                (int)dr["idLivro"],

                                (DateTime)dr["nomeLeitor"],
                                (DateTime)dr["emailLeitor"],
                                (DateTime)dr["telefoneLeitor"]
                                );
                                listaEmprestimo.Add(emprestimo);
                            }
                        }
                        return listaEmprestimo;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar estoque " + ex.Message);
            }
        }
        public DataTable SelectEmprestimos()  //tabela de dados
        {
            try
            {
                String sql = "SELECT idEmprestimo, idLeitor, idLivro, dataEmprestimo, " +
                             "dataEmprestimoPrevista, dataDevolucaoReal FROM bibEmprestimo";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Emprestimo SelectById(int idDesejado)
        {
            try
            {
                String sql = "SELECT idEmprestimo, idLeitor, idLivro, dataEmprestimo, " +
                             "dataEmprestimoPrevista, dataDevolucaoReal FROM bibEmprestimo" +
                             " WHERE idEmpretimo = @id";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Emprestimo emprestimo = null;
                if (dr.Read()) //se houve um registro retornado
                {
                    emprestimo = new Emprestimo(Convert.ToInt32(dr["idEmprestimo"]),
                                      Convert.ToInt32(dr["idLeitor"]),
                                      Convert.ToInt32(dr["idELivro"]),
                                      Convert.ToDateTime(dr["dataEmprestimoPrevista"]),
                                      Convert.ToDateTime(dr["dataDevolucaoReal"]),
                                      Convert.ToDateTime(dr["dataEmprestimo"]));
                }
                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "INSERT INTO bibEmprestimo " +
                " (idLeitor, idLivro, dataEmprestimo,dataEmprestimoPrevista,dataDevolucaoReal) " +
               " VALUES (@codigo,@titulo, @autor) ";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@codigo", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@titulo", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@autor", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@autor", qualEmprestimo.DataDevolucaoReal);
                cmd.Parameters.AddWithValue("@autor", qualEmprestimo.DataEmprestimoPrevista);

                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }
        public void DeleteEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "DELETE FROM bibEmpretimo WHERE idEmprestimo = @idEmprestimo ";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdEmprestimo);
                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }

        }
        public void UpdateEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "UPDATE bibEmprestimo " +
                " SET DataEmprestimo= @DataEmprestimo ," +
               " DataEmprestimoPrevista=@DataEmprestimoPrevista," +
               " DataDevolucaoReal=@DataDevolucaoReal " +
               " WHERE idEmprestimo = @idEmprestimo ";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@dataEmprestimo", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucaoReal", qualEmprestimo.DataDevolucaoReal);
                cmd.Parameters.AddWithValue("@dataEmprestimoPrevista", qualEmprestimo.DataEmprestimoPrevista);

                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }
        //public void UpdateDevolucaoPrevisto(Emprestimo qualEmprestimo)
        //{
        //    try
        //    {
        //        String sql = "UPDATE bibEmprestimo " +
        //        " SET DataEmprestimoPrevista= @DataEmprestimoPrevista ," +
        //       " DataEmprestimo=@DataEmprestimo," +
        //       " DataDevolucaoReal=@DataDevolucaoReal " +
        //       " WHERE idEmprestimo = @idEmprestimo ";
        //        _conexao = new SqlConnection(_conexaoSQLServer);
        //        SqlCommand cmd = new SqlCommand(sql, _conexao);
        //        cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
        //        cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
        //        cmd.Parameters.AddWithValue("@dataEmprestimo", qualEmprestimo.DataEmprestimo);
        //        cmd.Parameters.AddWithValue("@dataDevolucaoReal", qualEmprestimo.DataDevolucaoReal);
        //        cmd.Parameters.AddWithValue("@dataEmprestimoPrevista", qualEmprestimo.DataEmprestimoPrevista);

        //        _conexao.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        _conexao.Close();
        //    }
        //}
        //public void UpdateDevolucaoReal(Emprestimo qualEmprestimo)
        //{
        //    try
        //    {
        //        String sql = "UPDATE bibEmprestimo " +
        //        " SET DataDevolucaoReal= @DataDevolucaoReal ," +
        //       " DataEmprestimo=@DataEmprestimo," +
        //       " DataEmprestimoPrevista=@DataEmprestimoPrevista " +
        //       " WHERE idEmprestimo = @idEmprestimo ";
        //        _conexao = new SqlConnection(_conexaoSQLServer);
        //        SqlCommand cmd = new SqlCommand(sql, _conexao);
        //        cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
        //        cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
        //        cmd.Parameters.AddWithValue("@dataEmprestimo", qualEmprestimo.DataEmprestimo);
        //        cmd.Parameters.AddWithValue("@dataDevolucaoReal", qualEmprestimo.DataDevolucaoReal);
        //        cmd.Parameters.AddWithValue("@dataEmprestimoPrevista", qualEmprestimo.DataEmprestimoPrevista);

        //        _conexao.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        _conexao.Close();
        //    }
        //}
    }
}
