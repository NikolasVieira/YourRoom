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

            string query = "EXEC sp_insert_hospede @nome, @cpf, @dt_nascimento, @telefone";

            dataBase.AddParameter("@nome", hospede.Nome);
            dataBase.AddParameter("@cpf", hospede.CPF);
            dataBase.AddParameter("@dt_nascimento", hospede.DtNascimento);
            dataBase.AddParameter("@telefone", hospede.Telefone);

            dataBase.ExecuteManipulation(CommandType.Text, query);

            return Convert.ToInt32(dataBase.ExecuteQueryScalar(CommandType.Text, "EXEC sp_get_last_hospede"));
        }
        #endregion

        #region Alterar
        public int Alterar(Hospede hospede)
        {
            string query = "EXEC sp_update_hospede @id, @nome, @cpf, @dt_nascimento, @telefone";

            dataBase.ClearParameter();
            dataBase.AddParameter("@id", hospede.IdHospede);
            dataBase.AddParameter("@nome", hospede.Nome);
            dataBase.AddParameter("@cpf", hospede.CPF);
            dataBase.AddParameter("@dt_nascimento", hospede.DtNascimento);
            dataBase.AddParameter("@telefone", hospede.Telefone);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region Apagar
        public int Apagar(int IdHospede)
        {
            string query = "EXEC sp_delete_hospede @id";

            dataBase.ClearParameter();
            dataBase.AddParameter("@id", IdHospede);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region ConsultarPorNome
        public HospedeCollection ConsultarPorNome(string nome)
        {
            HospedeCollection hospedeCollection = new HospedeCollection();

            string query = "EXEC sp_get_hospede_nome @nome";

            dataBase.ClearParameter();
            dataBase.AddParameter("@nome", nome.Trim());

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Hospede hospede = new Hospede();

                hospede.IdHospede = Convert.ToInt32(dataRow["id"]);
                hospede.Nome = Convert.ToString(dataRow["nome"]);
                hospede.CPF = Convert.ToString(dataRow["cpf"]);

                if (!(dataRow["dt_nascimento"] is DBNull))
                    hospede.DtNascimento =
                        Convert.ToDateTime(dataRow["dt_nascimento"]);
                hospede.Telefone = Convert.ToString(dataRow["telefone"]);

                hospedeCollection.Add(hospede);
            }
            return hospedeCollection;
        }
        #endregion

        #region ConsultarPorId
        public Hospede ConsultarPorId(int IdHospede)
        {
            string query = "EXEC sp_get_hospede @id";

            dataBase.ClearParameter();
            dataBase.AddParameter("@id", IdHospede);

            DataTable dataTable = dataBase.ExecuteQuery(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Hospede hospede = new Hospede();

                hospede.IdHospede = Convert.ToInt32(dataTable.Rows[0]["id"]);
                hospede.Nome = Convert.ToString(dataTable.Rows[0]["nome"]);
                hospede.CPF = Convert.ToString(dataTable.Rows[0]["cpf"]);

                if (!(dataTable.Rows[0]["dt_nascimento"] is DBNull))
                    hospede.DtNascimento =
                        Convert.ToDateTime(dataTable.Rows[0]["dt_nascimento"]);
                hospede.Telefone = Convert.ToString(dataTable.Rows[0]["telefone"]);


                return hospede;
            }
            else
                return null;
        }
        #endregion

        #region ConsultarPorCPF
        public Hospede ConsultarPorCPF(int CPF)
        {
            string query = "EXEC sp_get_hospede_cpf @cpf";

            dataBase.ClearParameter();
            dataBase.AddParameter("@cpf", CPF);

            DataTable dataTable = dataBase.ExecuteQuery(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Hospede hospede = new Hospede();

                hospede.IdHospede = Convert.ToInt32(dataTable.Rows[0]["id"]);
                hospede.Nome = Convert.ToString(dataTable.Rows[0]["nome"]);
                hospede.CPF = Convert.ToString(dataTable.Rows[0]["cpf"]);

                if (!(dataTable.Rows[0]["dt_nascimento"] is DBNull))
                    hospede.DtNascimento =
                        Convert.ToDateTime(dataTable.Rows[0]["dt_nascimento"]);
                hospede.Telefone = Convert.ToString(dataTable.Rows[0]["telefone"]);


                return hospede;
            }
            else
                return null;
        }
        #endregion
    }
}
