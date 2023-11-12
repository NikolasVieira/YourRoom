// LIBRARIES para o SQLSERVER 
using System;
using System.Data;
using System.Data.SqlClient; 

// Criação de conexão com o banco de dados
namespace YourRoom.Services
{
    public class DataBaseSqlServer
    {
        // Retorna uma CONEXÃO com o BANCO DE DADOS
        private SqlConnection CreateConnection()
        {
            // Cria nova VARIAVEL do tipo CONEXÃO SQL
            SqlConnection connection = new SqlConnection();

            // Define os PARAMETROS de CONEXÃO
            connection.ConnectionString = 
                "Data Source = ;" + // Nome da CONEXÃO
                "Initial Catalog = DB_YourRoom;" + // Nome do DATABASE
                "Integrated Security = SSPI;" + // Tipo de ACESSO
                "User Instance = False;";

            connection.Open(); // REALIZA a CONEXÃO
            return connection; // RETORNA o resultado da CONEXÃO
        }

        // Cria nova VARIAVEL do tipo COLEÇÃO de PARÂMETROS, ou seja uma LISTA de COMANDOS SQL
        private SqlParameterCollection parameterCollection = new SqlCommand().Parameters;

        // Realiza a limpeza dos PARÂMETROS
        public void ClearParameter()
        {
            parameterCollection.Clear();
        }

        // Adiciona novos PARÂMETROS, recebe de INPUT: Nome do PARÂMETRO e o PARÂMETRO em si
        public void AddParameter(string ParameterName, object ParameterValue)
        {
            // Cria nova VARIAVEL do tipo PARÂMETRO SQL que recebe os valores do INPUT
            SqlParameter sqlParameter = new SqlParameter(ParameterName, ParameterValue);
            // Adiciona o PARÂMETRO na COLEÇÃO de PARÂMETROS
            parameterCollection.Add(sqlParameter);
        }

        // Retorna a QUANTIDADE de linhas afetadas após uma OPERAÇÃO SQL
        public SqlCommand CreateSqlCommand(CommandType commandType, string operationName)
        {
            // Estabelece a CONEXÃO com o BANCO DE DADOS
            SqlConnection connection = CreateConnection();
            SqlCommand command = connection.CreateCommand();

            command.CommandType = commandType; // Tipo de OPERAÇÃO (STORED PROCEDURE, UPDATE, etc...
            command.CommandText = operationName; // Nome da OPERAÇÃO

            // Para cada PARÂMETRO SQL na COLEÇÃO de PARÂMETROS executa
            foreach (SqlParameter parameter in parameterCollection)
            {
                // Executa MÉTODO que adiciona os PARÂMETROS
                AddParameter(parameter.ParameterName, parameter.Value);
            }
            // Retorna o COMANDO final
            return command;
        }

        // Retorna a QUANTIDADE de linhas afetadas após uma OPERAÇÃO SQL
        public int ExecuteManipulation(CommandType commandType, string operationName)
        {
            // Tenta estabelecer CONEXÃO
            try
            {
                // Armazena o COMANDO SQL gerado pelo MÉTODO
                SqlCommand command = CreateSqlCommand(commandType, operationName);
                // Retorna o número de linhas afetadas pela EXECUÇÃO do COMANDO SQL
                return command.ExecuteNonQuery();
            }
            // Pega qualquer ERRO/EXCEPTION
            catch(Exception exception)
            {
                // Retorna ERRO caso receba alguma EXCEPTION
                throw new Exception(
                    "Problema ao executar a OPERAÇÃO! " +
                    exception.Message
                );
            }
        }

        // Retorna a CONSULTA em forma de TABELA (Linhas e Colunas)
        public DataTable ExecuteQuery(CommandType commandType, string operationName)
        {
            // Tenta estabelecer CONEXÃO
            try
            {
                // Armazena o COMANDO SQL gerado pelo MÉTODO
                SqlCommand command = CreateSqlCommand(commandType, operationName);

                // Armazena em um ADAPTADOR DE DADOS o COMANDO SQL
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                // Cria uma TABELA DE DADOS nova
                DataTable dataTable = new DataTable();

                // Preenche a TABELA DE DADOS com o resultado da EXECUÇÃO feita pelo ADAPTADOR
                dataAdapter.Fill(dataTable);

                // Retorna a TABELA DE DADOS
                return dataTable;
            }
            // Pega qualquer ERRO/EXCEPTION
            catch (Exception exception)
            {
                // Retorna ERRO caso receba alguma EXCEPTION
                throw new Exception(
                    "Problema ao executar a CONSULTA! " +
                    exception.Message
                );
            }
        }

        // Retorna a CONSULTA em forma de TABELA (Linhas e Colunas)
        public object ExecuteQueryScalar(CommandType commandType, string operationName)
        {
            // Tenta estabelecer CONEXÃO
            try
            {
                // Armazena o COMANDO SQL gerado pelo MÉTODO
                SqlCommand command = CreateSqlCommand(commandType, operationName);

                // Retorna o valor da primeira COLUNA na primeira LINHA do COMANDO SQL executado
                return command.ExecuteScalar();
            }
            // Pega qualquer ERRO/EXCEPTION
            catch (Exception exception)
            {
                // Retorna ERRO caso receba alguma EXCEPTION
                throw new Exception(
                    "Problema ao executar a CONSULTA ESCALAR! " +
                    exception.Message
                );
            }
        }
    }
}
