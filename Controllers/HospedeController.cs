using System;
using System.Data;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Controllers
{
    public class HospedeController
    {
        #region Variaveis Locais
        // Importa os métodos que realizam interação com o banco de dados
        DataBaseSqlServer dataBase = new DataBaseSqlServer();
        #endregion

        #region Inserir
        // Insere na tabela de reserva
        public int Inserir(Hospede hospede)
        {
            // Limpa os parametros que podem estar na Query
            dataBase.ClearParameter();

            // Query que vai ser executada
            string query =
            "INSERT INTO Hospede (CPF, Nome, DtNascimento, Telefone) " +
            "VALUES (@CPF, @Nome, @DtNascimento, @Telefone)";

            //Adiona os valores de cada parametro que esta sendo utilizado
            //dataBase.AddParameter("@Quarto",         reserva.Quarto); 
            //dataBase.AddParameter("@Hospede",        reserva.Hospede);
            dataBase.AddParameter("@CPF", hospede.CPF);
            dataBase.AddParameter("@Nome", hospede.Nome);
            dataBase.AddParameter("@DtNascimento", hospede.DtNascimento);
            dataBase.AddParameter("@Telefone", hospede.Telefone);

            //Solicita a camada de banco de dados a execução da query
            dataBase.ExecuteManipulation(CommandType.Text, query);
            //Nesse momento o meu comando é executado no banco de dados

            //Executar um comando no banco de dados, para recupear o ID criado
            //pelo Identity
            //SELECT @@IDENTITY
            return Convert.ToInt32(dataBase.ExecuteQueryScalar(
                CommandType.Text, "SELECT @@IDENTITY"));
        }
        #endregion

        #region Alterar
        // Atualiza na tabela de reserva
        public int Alterar(Hospede hospede)
        {
            string query =
                "UPDATE Hospede SET " +
                "CPF = @CPF, " +
                "Nome = @Nome, " +
                "DtNascimento = @DtNascimento, " +
                "Telefone = @Telefone, " +
                "WHERE IdHospede = @IdHospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdHospede", hospede.IdHospede);
            dataBase.AddParameter("@CPF", hospede.CPF);
            dataBase.AddParameter("@Nome", hospede.Nome);
            dataBase.AddParameter("@DtNascimento", hospede.DtNascimento);
            dataBase.AddParameter("@Telefone", hospede.Telefone);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region Apagar
        public int Apagar(int IdHospede)
        {
            string query =
                "DELETE FROM Hospede " +
                "WHERE IdHospede = @IdHospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdHospede", IdHospede);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region ConsultarPorNome
        public HospedeCollection ConsultarPorNome(string nome)
        {
            HospedeCollection hospedeCollection = new HospedeCollection();
            string query =
                "SELECT * FROM Hospede " +
                "WHERE Nome LIKE '%' + @Nome + '%'";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Hospede hospede = new Hospede();

                hospede.IdHospede = Convert.ToInt32(dataRow["IdHospede"]);
                hospede.Nome = Convert.ToString(dataRow["Nome"]);
                hospede.CPF = Convert.ToString(dataRow["cpf"]);

                if (!(dataRow["DtNascimento"] is DBNull))
                    hospede.DtNascimento =
                        Convert.ToDateTime(dataRow["DtNascimento"]);
                hospede.Telefone = Convert.ToString(dataRow["Telefone"]);

                hospedeCollection.Add(hospede);
            }
            return hospedeCollection;
        }
        #endregion

        #region ConsultarPorId
        public Hospede ConsultarPorId(int IdHospede)
        {
            string query =
                "SELECT * FROM Hospede " +
                "WHERE IdHospede = @IdHospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdHospede", IdHospede);

            DataTable dataTable = dataBase.ExecuteQuery(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Hospede hospede = new Hospede();

                hospede.IdHospede = Convert.ToInt32(dataTable.Rows[0]["IdHospede"]);
                hospede.Nome = Convert.ToString(dataTable.Rows[0]["Nome"]);
                hospede.CPF = Convert.ToString(dataTable.Rows[0]["CPF"]);

                if (!(dataTable.Rows[0]["DtNascimento"] is DBNull))
                    hospede.DtNascimento =
                        Convert.ToDateTime(dataTable.Rows[0]["DtNascimento"]);
                hospede.Telefone = Convert.ToString(dataTable.Rows[0]["Telefone"]);

                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection tera um objeto de cada linha
                return cliente;
            }
            else
                return null;
        }
        #endregion
    }
}
