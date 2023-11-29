using System;
using System.Data;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Controllers
{
    public class QuartoController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();


        #region Inserir
        public int Inserir(Quarto quarto)
        {
            dataBase.ClearParameter();

            string query = "EXEC sp_insert_quarto @numero, @categoria, @status, @diaria, @capacidade";

            dataBase.AddParameter("@numero", quarto.Numero);
            dataBase.AddParameter("@categoria", quarto.Categoria);
            dataBase.AddParameter("@status", quarto.Status);
            dataBase.AddParameter("@diaria", quarto.Diaria);
            dataBase.AddParameter("@capacidade", quarto.Capacidade);

            dataBase.ExecuteManipulation(CommandType.Text, query);

            return Convert.ToInt32(dataBase.ExecuteQueryScalar(CommandType.Text, "EXEC sp_get_last_quarto"));
        }
        #endregion

        #region Alterar
        public int Alterar(Quarto quarto)
        {
            string query = "EXEC sp_update_quarto @id, @numero, @categoria, @status, @diaria, @capacidade";

            dataBase.ClearParameter();
            dataBase.AddParameter("@id", quarto.IdQuarto);
            dataBase.AddParameter("@numero", quarto.Numero);
            dataBase.AddParameter("@categoria", quarto.Categoria);
            dataBase.AddParameter("@status", quarto.Status);
            dataBase.AddParameter("@diaria", quarto.Diaria);
            dataBase.AddParameter("@capacidade", quarto.Capacidade);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region Apagar
        public int Apagar(int IdQuarto)
        {
            string query = "EXEC sp_delete_quarto @id";

            dataBase.ClearParameter();
            dataBase.AddParameter("@id", IdQuarto);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region ConsultarPorNumero
        public QuartoCollection ConsultarPorNumero(int numero)
        {
            QuartoCollection quartoCollection = new QuartoCollection();
            string query = "EXEC sp_get_quarto_numero @numero";

            dataBase.ClearParameter();
            dataBase.AddParameter("@numero", numero);

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
            string query = "EXEC sp_get_quarto @id";

            dataBase.ClearParameter();
            dataBase.AddParameter("@id", IdQuarto);

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

        public QuartoCollection Select()
        {
            QuartoCollection quartoCollection = new QuartoCollection();

            string query = "SELECT * FROM tb_quartos";

            dataBase.ClearParameter();

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

    }
}
