using System;
using System.Data;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Controllers
{
    public class ReservaController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        #region Inserir
        public int Inserir(Reserva reserva)
        {
            dataBase.ClearParameter();

            string query = "EXEC sp_insert_reserva @QtdHospedes, @DataReserva, @DataCheckIn, @DataCheckOut, @StatusReserva, @StatusCheckIn, @StatusCheckOut, @Quarto, @Hospede";

            dataBase.AddParameter("@QtdHospedes",    reserva.QtdHospedes      );
            dataBase.AddParameter("@DataReserva",    reserva.DtReserva        );
            dataBase.AddParameter("@DataCheckIn",    reserva.DtCheckIn        );
            dataBase.AddParameter("@DataCheckOut",   reserva.DtCheckOut       );
            dataBase.AddParameter("@StatusReserva",  reserva.StatusReserva    );
            dataBase.AddParameter("@StatusCheckIn",  reserva.StatusCheckIn    );
            dataBase.AddParameter("@StatusCheckOut", reserva.StatusCheckOut   );
            dataBase.AddParameter("@Quarto",         reserva.Quarto.IdQuarto  );
            dataBase.AddParameter("@Hospede",        reserva.Hospede.IdHospede);

            dataBase.ExecuteManipulation(CommandType.Text, query);

            return Convert.ToInt32(dataBase.ExecuteQueryScalar(CommandType.Text, "EXEC sp_get_last_reserva"));
        }
        #endregion

        #region Alterar
        public int Alterar(Reserva reserva)
        {
            string query = "EXEC sp_insert_reserva @IdReserva, @QtdHospedes, @DataReserva, @DataCheckIn, @DataCheckOut, @StatusReserva, @StatusCheckIn, @StatusCheckOut, @Quarto, @Hospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdReserva", reserva.IdReserva);
            dataBase.AddParameter("@QtdHospedes", reserva.QtdHospedes);
            dataBase.AddParameter("@DataReserva", reserva.DtReserva);
            dataBase.AddParameter("@DataCheckIn", reserva.DtCheckIn);
            dataBase.AddParameter("@DataCheckOut", reserva.DtCheckOut);
            dataBase.AddParameter("@StatusReserva", reserva.StatusReserva);
            dataBase.AddParameter("@StatusCheckIn", reserva.StatusCheckIn);
            dataBase.AddParameter("@StatusCheckOut", reserva.StatusCheckOut);
            dataBase.AddParameter("@Quarto", reserva.Quarto.IdQuarto);
            dataBase.AddParameter("@Hospede", reserva.Hospede.IdHospede);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region Alterar
        public int Apagar(int IdReserva, int IdHospede)
        {
            string query = "DELETE FROM tb_reservas WHERE id = @IdReserva AND hospede_id = @IdHospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdReserva", IdReserva);
            dataBase.AddParameter("@IdHospede", IdHospede);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region ConsultarTodosQuartosReservados
        public ReservaCollection ConsultarTodosQuartosReservados(int IdQuarto)
        {
            ReservaCollection reservaCollection = new ReservaCollection();
            QuartoController quartoController = new QuartoController();
            HospedeController hospedeController = new HospedeController();

            string query = "SELECT * FROM tb_reservas WHERE quarto_id = @IdQuarto ORDER BY id";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdQuarto", IdQuarto);

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Reserva reserva = new Reserva();

                reserva.QtdHospedes    = Convert.ToInt32(dataRow["qtd_hospedes"]);
                reserva.DtReserva      = Convert.ToDateTime(dataRow["dt_reserva"]);
                reserva.DtCheckIn      = Convert.ToDateTime(dataRow["dt_check_in"]);
                reserva.DtCheckOut     = Convert.ToDateTime(dataRow["dt_check_out"]);
                reserva.StatusReserva  = Convert.ToInt32(dataRow["reserva_status"]);
                reserva.StatusCheckIn  = Convert.ToInt32(dataRow["check_in_status"]);
                reserva.StatusCheckOut = Convert.ToInt32(dataRow["check_out_status"]);
                reserva.Quarto  = quartoController.ConsultarPorId(Convert.ToInt32(dataRow["quarto_id"]));
                reserva.Hospede = hospedeController.ConsultarPorId(Convert.ToInt32(dataRow["hospede_id"]));

                reservaCollection.Add(reserva);
            }
            return reservaCollection;
        }
        #endregion

        #region ConsultarTodosQuartosReservados
        public ReservaCollection ConsultarReservas()
        {
            ReservaCollection reservaCollection = new ReservaCollection();
            QuartoController quartoController = new QuartoController();
            HospedeController hospedeController = new HospedeController();

            string query = "SELECT * FROM tb_reservas";

            dataBase.ClearParameter();

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Reserva reserva = new Reserva();

                reserva.QtdHospedes = Convert.ToInt32(dataRow["qtd_hospedes"]);
                reserva.DtReserva = Convert.ToDateTime(dataRow["dt_reserva"]);
                reserva.DtCheckIn = Convert.ToDateTime(dataRow["dt_check_in"]);
                reserva.DtCheckOut = Convert.ToDateTime(dataRow["dt_check_out"]);
                reserva.StatusReserva = Convert.ToInt32(dataRow["reserva_status"]);
                reserva.StatusCheckIn = Convert.ToInt32(dataRow["check_in_status"]);
                reserva.StatusCheckOut = Convert.ToInt32(dataRow["check_out_status"]);
                reserva.Quarto = quartoController.ConsultarPorId(Convert.ToInt32(dataRow["quarto_id"]));
                reserva.Hospede = hospedeController.ConsultarPorId(Convert.ToInt32(dataRow["hospede_id"]));

                reservaCollection.Add(reserva);
            }
            return reservaCollection;
        }
        #endregion

        #region ConsultarPorId
        public Reserva ConsultarPorId(int IdReserva)
        {
            QuartoController quartoController = new QuartoController();
            HospedeController hospedeController = new HospedeController();

            string query = "EXEC sp_get_reserva @Id";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Id", IdReserva);

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

                
            if (dataTable.Rows.Count > 0)
            {
                Reserva reserva = new Reserva();

                reserva.QtdHospedes = Convert.ToInt32(dataTable.Rows[0]["qtd_hospedes"]);
                reserva.DtReserva = Convert.ToDateTime(dataTable.Rows[0]["dt_reserva"]);
                reserva.DtCheckIn = Convert.ToDateTime(dataTable.Rows[0]["dt_check_in"]);
                reserva.DtCheckOut = Convert.ToDateTime(dataTable.Rows[0]["dt_check_out"]);
                reserva.StatusReserva = Convert.ToInt32(dataTable.Rows[0]["reserva_status"]);
                reserva.StatusCheckIn = Convert.ToInt32(dataTable.Rows[0]["check_in_status"]);
                reserva.StatusCheckOut = Convert.ToInt32(dataTable.Rows[0]["check_out_status"]);
                reserva.Quarto = quartoController.ConsultarPorId(Convert.ToInt32(dataTable.Rows[0]["quarto_id"]));
                reserva.Hospede = hospedeController.ConsultarPorId(Convert.ToInt32(dataTable.Rows[0]["hospede_id"]));

                return reserva;
            }
            else
                return null;
        }
        #endregion
    }
}

