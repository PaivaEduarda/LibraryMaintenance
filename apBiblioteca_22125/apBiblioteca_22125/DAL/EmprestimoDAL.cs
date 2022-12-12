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
                $"Data Source = regulus.cotuca.unicamp.br; Initial Catalog = {banco};" +
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
        } //seleciona toda a tabela
        public DataTable SelectEmprestimos()  //tabela de dados
        {
            try
            {
                String sql = "SELECT idEmprestimo, idLeitor, idLivro, dataEmprestimo, " +
                             " dataDevolucaoPrevista, dataDevolucaoReal  FROM bibEmprestimo";
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
        } //seleciona toda a tabela
        public DataTable SelectEmprestimosAtrasados()  //tabela de dados
        {
            try
            {
                String sql = "SELECT idEmprestimo, idLeitor, idLivro, " +
                             "DataDevolucaoPrevista, dataDevolucaoReal  FROM bibEmprestimo" +
                             " WHERE dataDevolucaoReal > DataDevolucaoPrevista";
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
        } //seleciona todos os empréstimos atrasados
        public Emprestimo SelectById(int idDesejado)
        {
            try
            {
                String sql = "SELECT idEmprestimo, idLeitor, idLivro, dataEmprestimo, " +
                             "DataDevolucaoPrevista, dataDevolucaoReal  FROM bibEmprestimo" +
                             " WHERE idEmprestimo = @id";
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
                                      Convert.ToInt32(dr["idLivro"]),
                                      Convert.ToDateTime(dr["dataEmprestimo"]),
                                      Convert.ToDateTime(dr["DataDevolucaoPrevista"]),
                                      Convert.ToDateTime(dr["dataDevolucaoReal"])
                                      );
                }
                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        } //seleciona o empréstimo pelo id
        public Emprestimo SelectByIdLivro(int idDesejado)
        {
            try
            {
                String sql = "SELECT idEmprestimo, idLeitor, idLivro, dataEmprestimo, " +
                             "DataDevolucaoPrevista, dataDevolucaoReal" +
                             " FROM bibEmprestimo" +
                             " WHERE idLivro = @id";
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
                                      Convert.ToInt32(dr["idLivro"]),
                                      Convert.ToDateTime(dr["dataEmprestimo"]),
                                      Convert.ToDateTime(dr["DataDevolucaoPrevista"]),
                                      Convert.ToDateTime(dr["dataDevolucaoReal"])
                                      
                                      );
                }
                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        } //seleciona os empréstimos pelo id livro
        public Emprestimo SelectByIdLeitor(int idDesejado)
        {
            try
            {
                Emprestimo emprestimo = null;
                String sql = "SELECT idEmprestimo, idLeitor, idLivro, dataEmprestimo, " +
                             "DataDevolucaoPrevista, dataDevolucaoReal  FROM bibEmprestimo" +
                             " WHERE idLeitor = @id";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
                if (dr.Read()) //se houve um registro retornado
                {
                    emprestimo = new Emprestimo(Convert.ToInt32(dr["idEmprestimo"]),
                                      Convert.ToInt32(dr["idLeitor"]),
                                      Convert.ToInt32(dr["idLivro"]),
                                      Convert.ToDateTime(dr["DataDevolucaoPrevista"]),
                                      Convert.ToDateTime(dr["dataDevolucaoReal"]),
                                      Convert.ToDateTime(dr["dataEmprestimo"]));
                }
                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        } //seleciona os empréstimos pelo idLeitor

        public void InsertEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "INSERT INTO bibEmprestimo " +
                " (idLivro, idLeitor, dataEmprestimo,DataDevolucaoPrevista, dataDevolucaoReal ) " +
               " VALUES (@idLivro,@idLeitor, @dataEmprestimo,  @dataDevolucaoPrevista, @dataDevolucao )";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@dataEmprestimo", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucaoPrevista", qualEmprestimo.DataDevolucaoPrevista);
                cmd.Parameters.AddWithValue("@dataDevolucao", qualEmprestimo.DataDevolucaoReal);

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
        } //inseri um novo empréstimo
        public void DeleteEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "DELETE FROM bibEmprestimo WHERE idEmprestimo = @idEmprestimo ";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idEmprestimo", qualEmprestimo.IdEmprestimo);
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
        } //deleta um empréstimo
        public void UpdateEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "UPDATE bibEmprestimo " +
                " SET DataEmprestimo = @dataEmprestimo, " +
               " DataDevolucaoPrevista = @dataDevolucaoPrevista," +
               " dataDevolucaoReal = @dataDevolucao " +
               " WHERE idEmprestimo = @idEmprestimo ";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idEmprestimo", qualEmprestimo.IdEmprestimo);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@dataEmprestimo", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucao", qualEmprestimo.DataDevolucaoReal);
                cmd.Parameters.AddWithValue("@DataDevolucaoPrevista", qualEmprestimo.DataDevolucaoPrevista);

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
        } //atualiza um empréstimo
    }
}
