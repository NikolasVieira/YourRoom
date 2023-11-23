using System;
using System.Data;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Controllers
{
    public class HospedeController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        #region Inserir
        public int Inserir(Hospede hospede)
        {
            dataBase.ClearParameter();

            string query =
            "INSERT INTO tb_hospedes (nome, cpf, dt_nascimento, telefone) " +
            "VALUES (@Nome, @CPF, @DtNascimento, @Telefone)";

            dataBase.AddParameter("@Nome", hospede.Nome);
            dataBase.AddParameter("@CPF", hospede.CPF);
            dataBase.AddParameter("@DtNascimento", hospede.DtNascimento);
            dataBase.AddParameter("@Telefone", hospede.Telefone);

            dataBase.ExecuteManipulation(CommandType.Text, query);

            return Convert.ToInt32(dataBase.ExecuteQueryScalar(
                CommandType.Text, "SELECT @@IDENTITY"));
        }
        #endregion

        #region Alterar
        public int Alterar(Hospede hospede)
        {
            string query =
                "UPDATE tb_hospedes SET " +
                "nome = @Nome, " +
                "cpf = @CPF, " +
                "dt_nascimento = @DtNascimento, " +
                "telefone = @Telefone, " +
                "WHERE id = @IdHospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdHospede", hospede.IdHospede);
            dataBase.AddParameter("@Nome", hospede.Nome);
            dataBase.AddParameter("@CPF", hospede.CPF);
            dataBase.AddParameter("@DtNascimento", hospede.DtNascimento);
            dataBase.AddParameter("@Telefone", hospede.Telefone);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region Apagar
        public int Apagar(int IdHospede)
        {
            string query =
                "DELETE FROM tb_hospedes " +
                "WHERE id = @IdHospede";

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
                "SELECT * FROM tb_hospedes " +
                "WHERE nome LIKE '%' + @Nome + '%'";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Hospede hospede = new Hospede();

                hospede.IdHospede = Convert.ToInt32(dataRow["id"]);
                hospede.Nome = Convert.ToString(dataRow["nome"]);
                hospede.CPF = Convert.ToString(dataRow["cpf"]);

                if (!(dataRow["DtNascimento"] is DBNull))
                    hospede.DtNascimento =
                        Convert.ToDateTime(dataRow["dt_nascimento "]);
                hospede.Telefone = Convert.ToString(dataRow["telefone"]);

                hospedeCollection.Add(hospede);
            }
            return hospedeCollection;
        }
        #endregion

        #region ConsultarPorId
        public Hospede ConsultarPorId(int IdHospede)
        {
            string query =
                "SELECT * FROM tb_hospedes " +
                "WHERE id = @IdHospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdHospede", IdHospede);

            DataTable dataTable = dataBase.ExecuteQuery(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Hospede hospede = new Hospede();

                hospede.IdHospede = Convert.ToInt32(dataTable.Rows[0]["id"]);
                hospede.Nome = Convert.ToString(dataTable.Rows[0]["nome"]);
                hospede.CPF = Convert.ToString(dataTable.Rows[0]["cpf"]);

                if (!(dataTable.Rows[0]["dt_nascimento "] is DBNull))
                    hospede.DtNascimento =
                        Convert.ToDateTime(dataTable.Rows[0]["dt_nascimento "]);
                hospede.Telefone = Convert.ToString(dataTable.Rows[0]["telefone"]);


                return hospede;
            }
            else
                return null;
        }
        #endregion
    }
}
