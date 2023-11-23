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
            "INSERT INTO tb_quartos (numero, categoria, status, diaria, capacidade) " +
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
                "UPDATE tb_quartos SET " +
                "numero = @Numero, " +
                "categoria = @Categoria, " +
                "status = @Status, " +
                "diaria = @Diaria, " +
                "capacidade = @Capacidade, " +
                "WHERE id = @IdQuarto";

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
                "DELETE FROM tb_quartos " +
                "WHERE id = @IdQuarto";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdQuarto", IdQuarto);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region ConsultarPorNumero
        public QuartoCollection ConsultarPorNumero(int numero)
        {
            QuartoCollection quartoCollection = new QuartoCollection();
            string query =
                "SELECT * FROM tb_quartos " +
                "WHERE numero LIKE '%' + @Numero + '%'";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Numero", numero);

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Quarto quarto = new Quarto();

                quarto.IdQuarto = Convert.ToInt32(dataRow["id"]);
                quarto.Numero = Convert.ToInt32(dataRow["numero"]);
                quarto.Categoria = Convert.ToInt32(dataRow["categoria"]);
                quarto.Status = Convert.ToInt32(dataRow["status"]);
                quarto.Diaria = Convert.ToDecimal(dataRow["diaria"]);
                quarto.Capacidade = Convert.ToInt32(dataRow["capacidade"]);

                quartoCollection.Add(quarto);
            }
            return quartoCollection;
        }
        #endregion

        #region ConsultarPorId
        public Quarto ConsultarPorId(int IdQuarto)
        {
            string query =
                "SELECT * FROM tb_quartos " +
                "WHERE id = @IdQuarto";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdQuarto", IdQuarto);

            DataTable dataTable = dataBase.ExecuteQuery(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Quarto quarto = new Quarto();

                quarto.IdQuarto = Convert.ToInt32(dataTable.Rows[0]["id"]);
                quarto.Numero = Convert.ToInt32(dataTable.Rows[0]["numero"]);
                quarto.Categoria = Convert.ToInt32(dataTable.Rows[0]["categoria"]);
                quarto.Status = Convert.ToInt32(dataTable.Rows[0]["status"]);
                quarto.Diaria = Convert.ToDecimal(dataTable.Rows[0]["diaria"]);
                quarto.Capacidade = Convert.ToInt32(dataTable.Rows[0]["capacidade"]);

                return quarto;
            }
            else
                return null;
        }
        #endregion
    }
}
