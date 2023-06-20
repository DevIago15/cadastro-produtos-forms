using Projeto_Oak.Model.DAO;
using Projeto_Oak.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Oak.Model
{
    class ProdutoIDAO : IDao
    {

        /* public bool consultar(object objeto)
        {
            Herois heroi = new Herois();
            heroi = (Herois)objeto;

            bool sucesso = false;

            string SELECT = "SELECT * FROM HEROIS WHERE idHeroi = " + heroi.IdPessoa;

            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);

                //dataReader ira receber o resultado da consulta
                // somente para leitura 
                SqlDataReader dataReader;

                //Exuta a consulta
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) // Lendo Registro
                {
                    heroi.IdPessoa = dataReader.GetInt32(0);
                    heroi.NomePessoa = dataReader.GetString(1);
                    heroi.AnoNasc = dataReader.GetInt32(2);
                    heroi.Idade = dataReader.GetInt32(3);
                    heroi.Email = dataReader.GetString(4);
                    heroi.NomeHeroi = dataReader.GetString(5);
                    heroi.PlanetaOrigem = dataReader.GetString(6);
                    heroi.AtividadeProfissional = dataReader.GetString(7);
                    heroi.Parceiro = dataReader.GetString(8);
                    heroi.SuperPoder = dataReader.GetString(9);
                    heroi.Grupo = dataReader.GetString(10);

                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }
*/

        public bool excluir(object objeto)
        {
            Produto prod = new Produto();
            prod = (Produto)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM Produto WHERE idProduto = " + prod.IdProduto;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand Command = new SqlCommand(DELETE, conexaoDB);
                if (Command.ExecuteNonQuery() == 1)
                {
                    Command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de exclusão" + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }

        public object consultar1(object objeto)
        {
            Produto prod = new Produto();
            prod = (Produto)objeto;

            DataTable dataTable = new DataTable();

            string SELECT = "SELECT * FROM Produto ORDER BY valorProduto ASC";

            SqlDataReader dataReader = null;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataTable.Columns.Add("idProduto", typeof(int));
                    dataTable.Columns.Add("nomeProduto", typeof(string));
                    dataTable.Columns.Add("valorProduto", typeof(float));
                    dataTable.Columns.Add("disponibilidadeProduto", typeof(string));
                    dataTable.Columns.Add("descricaoProduto", typeof(string));


                    while (dataReader.Read())
                    {
                        DataRow row = dataTable.NewRow();

                        row["idProduto"] = Convert.ToInt32(dataReader[0].ToString());
                        row["nomeProduto"] = dataReader[1].ToString();
                        row["valorProduto"] = Convert.ToInt32(dataReader[2].ToString());
                        row["disponibilidadeProduto"] = dataReader[3].ToString();
                        row["descricaoProduto"] = dataReader[4].ToString();
                        dataTable.Rows.Add(row);
                    }
                    dataTable.DefaultView.Sort = "valorProduto ASC";

                }

                command.Dispose();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }

            return dataTable;
        }
        public object consultar2()
        {
            DataTable dataTable = new DataTable();

            string SELECT = "SELECT * FROM Produto ORDER BY valorProduto ASC";

            SqlDataReader dataReader = null;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataTable.Columns.Add("idProduto", typeof(int));
                    dataTable.Columns.Add("nomeProduto", typeof(string));
                    dataTable.Columns.Add("valorProduto", typeof(float));
                    dataTable.Columns.Add("disponibilidadeProduto", typeof(string));
                    dataTable.Columns.Add("descricaoProduto", typeof(string));


                    while (dataReader.Read())
                    {
                        DataRow row = dataTable.NewRow();

                        row["idProduto"] = Convert.ToInt32(dataReader[0].ToString());
                        row["nomeProduto"] = dataReader[1].ToString();
                        row["valorProduto"] = Convert.ToInt32(dataReader[2].ToString());
                        row["disponibilidadeProduto"] = dataReader[3].ToString();
                        row["descricaoProduto"] = dataReader[4].ToString();
                        dataTable.Rows.Add(row);
                    }
                }

                command.Dispose();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }

            return dataTable;
        }


        public List<object> consultar(string sql)
        {
            List<object> listProd = null;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(sql, conexaoDB);

                // DataReader ira receber o resultada da consulta 
                //Somente para leitura
                SqlDataReader dataReader;

                // Executa a consulta 
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                    listProd = new List<object>();

                while (dataReader.Read()) // Lendo Registros 
                {
                    Produto prod = new Produto();
                    prod.IdProduto = dataReader.GetInt32(0);
                    prod.NomeProduto = dataReader.GetString(1);
                    prod.ValorProduto = dataReader.GetFloat(2);
                    prod.DispProduto = dataReader.GetString(3);
                    prod.DescProduto = dataReader.GetString(4);
                 
                    listProd.Add(prod);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return listProd;
        }

    

        public int inserir1(object objeto)
        {
            Produto prod = (Produto)objeto;
            int idGerado = 0;

            string INSERT = "INSERT INTO Produto (nomeProduto, valorProduto, disponibilidadeProduto, " +
                "descricaoProduto) " +
                "VALUES ('" + prod.NomeProduto+
                "', '" + prod.ValorProduto+
                "', '" + prod.DispProduto+
                "', '" + prod.DescProduto+
                "'); SELECT SCOPE_IDENTITY();";

            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, ConexaoDb);

                idGerado = Convert.ToInt32(command.ExecuteScalar());

                Console.WriteLine("Sucesso na Inscrição");
                command.Dispose();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de Inserção " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }

            return idGerado;
        }

        DataTable IDao.consultar1(object objeto)
        {
            Produto prod = new Produto();
            prod = (Produto)objeto;

            DataTable dataTable = new DataTable();

            string SELECT = "SELECT * FROM Produto ORDER BY valorProduto ASC";

            SqlDataReader dataReader = null;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataTable.Columns.Add("idProduto", typeof(int));
                    dataTable.Columns.Add("nomeProduto", typeof(string));
                    dataTable.Columns.Add("valorProduto", typeof(float));
                    dataTable.Columns.Add("disponibilidadeProduto", typeof(string));
                    dataTable.Columns.Add("descricaoProduto", typeof(string));


                    while (dataReader.Read())
                    {
                        DataRow row = dataTable.NewRow();

                        row["idProduto"] = Convert.ToInt32(dataReader[0].ToString());
                        row["nomeProduto"] = dataReader[1].ToString();
                        row["valorProduto"] = Convert.ToInt32(dataReader[2].ToString());
                        row["disponibilidadeProduto"] = dataReader[3].ToString();
                        row["descricaoProduto"] = dataReader[4].ToString();
                        dataTable.Rows.Add(row);
                    }

                }

                command.Dispose();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }

            return dataTable;
        }
    }
}


