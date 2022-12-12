using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
using BLL;
using DAL;

namespace DAL
{
    public class LeitorDAL
    {
        string _conexaoSQLServer = "";
        SqlConnection _conexao = null;

        public LeitorDAL(string banco, string usuario, string senha)
        {
            _conexaoSQLServer =
            $"Data Source = regulus.cotuca.unicamp.br; Initial Catalog = {banco};" +
            $"User id = {usuario}; passWord = {senha}";
        }

        public List<Leitor> SelectListLeitor()    // retorna uma lista de Livros, ou seja, um objeto da classe List<Livro> com os
                                                  // livros selecionados;
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand command =
                    new SqlCommand("Select * from bibLeitor", conn))
                    {
                        conn.Open();
                        List<Leitor> listaLeitores = new List<Leitor>();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Leitor leitor = new Leitor(
                                (int)dr["idLeitor"],
                                dr["nomeLeitor"] + "",
                                dr["emailLeitor"] + "",
                                dr["telefoneLeitor"] + "",
                                dr["enderecoLeitor"] + ""
                                );
                                listaLeitores.Add(leitor);
                            }
                        }
                        return listaLeitores;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar estoque " + ex.Message);
            }
        } //seleciona todos os dados tabela
        public DataTable SelectLeitores()  //tabela de dados
        {
            try
            {
                String sql = "SELECT idLeitor,nomeLeitor,telefoneLeitor,emailLeitor, enderecoLeitor FROM bibLeitor";
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

        } //seleciona todos os dados da tabela

        public Leitor SelectById(int idDesejado)
        {
            try
            {
                String sql = "SELECT idLeitor, nomeLeitor, telefoneLeitor, emailLeitor, enderecoLeitor " +
                             " FROM bibLeitor WHERE idLeitor = @id";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Leitor leitor = null;
                if (dr.Read()) //se houve um registro retornado
                {
                    leitor = new Leitor(Convert.ToInt32(dr["idLeitor"]),
                                      dr["nomeLeitor"].ToString(),
                                      dr["telefoneLeitor"].ToString(),
                                      dr["emailLeitor"].ToString(),
                                      dr["enderecoLeitor"].ToString());

                }
                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        } //seleciona todos os dados a partir do id do leitor
        public Leitor SelectByTelefone(String telefone)
        {
            try
            {
                String sql = "SELECT idLeitor, nomeLeitor, telefoneLeitor, emailLeitor, enderecoLeitor " +
                             " FROM bibLeitor WHERE telefoneLeitor = @telefone";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Leitor leitor = null;
                if (dr.Read()) //se houve um registro retornado
                {
                    leitor = new Leitor(Convert.ToInt32(dr["idLeitor"]),
                                      dr["nomeLeitor"].ToString(),
                                      dr["telefoneLeitor"].ToString(),
                                      dr["emailLeitor"].ToString(),
                                      dr["enderecoLeitor"].ToString());

                }
                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        } //seleciona todos os dados a partir do telefone do leitor


        public void InsertLeitor(Leitor qualLeitor)
        {
            try
            {
                String sql = "INSERT INTO bibLeitor " +
                " (nomeLeitor, telefoneLeitor, emailLeitor, enderecoLeitor) " +
               " VALUES (@nome,@telefone, @email, @endereco) ";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@telefone", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);

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
        } //inserir o leitor 
        public void DeleteLeitor(Leitor qualLeitor)
        {
            try
            {
                String sql = "DELETE FROM bibLeitor WHERE idLeitor = @idLeitor ";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLeitor", qualLeitor.IdLeitor);
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

        } //deletar os leitores
        public void UpdateLeitor(Leitor qualLeitor)
        {
            try
            {
                String sql = "UPDATE bibLeitor " +
                " SET nomeLeitor= @leitor ," +
               " telefoneLeitor=@telefone," +
               " emailLeitor=@email," +
               " enderecoLeitor=@endereco " +
               " WHERE idLeitor = @idLeitor ";
                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLeitor", qualLeitor.IdLeitor);
                cmd.Parameters.AddWithValue("@leitor", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@telefone", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);

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
        } //atualiza os dados do leitor
    }
}


