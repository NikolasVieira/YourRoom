using System;
using System.Data;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Controllers
{
    public class QuartoController
    {
        #region Variaveis Locais
        DataBaseSqlServer dataBase = new DataBaseSqlServer();
        #endregion

        #region Inserir
        public int Inserir(Quarto quarto)
        {
            dataBase.ClearParameter();

        string query =
            "INSERT INTO Quarto (Numero, Categoria, Status, Diaria, Capacidade) " +
            "VALUES (@Numero, @Categoria, @Status, @Diaria, @Capacidade)";

            dataBase.AddParameter("@Numero", quarto.Numero);
            dataBase.AddParameter("@Categoria", quarto.Categoria);
            dataBase.AddParameter("@Status", quarto.Status);
            dataBase.AddParameter("@Diaria", quarto.Diaria);
            dataBase.AddParameter("@Capacidade", quarto.Capacidade);

            dataBase.ExecuteManipulation(CommandType.Text, query);

            return Convert.ToInt32(dataBase.ExecuteQueryScalar(
                CommandType.Text, "SELECT @@IDENTITY"));
        }
        #endregion

        #region Alterar
        public int Alterar(Quarto quarto)
        {
            string query =
                "UPDATE Quarto SET " +
                "Numero = @Numero, " +
                "Categoria = @Categoria, " +
                "Status = @Status, " +
                "Diaria = @Diaria, " +
                "Capacidade = @Capacidade, " +
                "WHERE IdQuarto = @IdQuarto";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdQuarto", quarto.IdQuarto);
            dataBase.AddParameter("@Numero", quarto.Numero);
            dataBase.AddParameter("@Categoria", quarto.Categoria);
            dataBase.AddParameter("@Status", quarto.Status);
            dataBase.AddParameter("@Diaria", quarto.Diaria);
            dataBase.AddParameter("@Capacidade", quarto.Capacidade);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region Apagar
        public int Apagar(int IdQuarto)
        {
            string query =
                "DELETE FROM Quarto " +
                "WHERE IdQuarto = @IdQuarto";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdQuarto", IdQuarto);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region ConsultarPorNome
        public HospedeCollection ConsultarPorNumero(int numero)
        {
            HospedeCollection hospedeCollection = new HospedeCollection();
            string query =
                "SELECT * FROM Hospede " +
                "WHERE Nome LIKE '%' + @Nome + '%'";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Nome", numero);

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

                //Usar no HospedeController
                //reserva.Hospede = ConsultarPorId(Convert.ToInt32(dataTable.Rows[0]["IdHospede"]));

                if (!(dataTable.Rows[0]["DtNascimento"] is DBNull))
                    hospede.DtNascimento =
                        Convert.ToDateTime(dataTable.Rows[0]["DtNascimento"]);
                hospede.Telefone = Convert.ToString(dataTable.Rows[0]["Telefone"]);

                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection tera um objeto de cada linha
                return hospede;
            }
            else
                return null;
        }
        #endregion
    }
}
