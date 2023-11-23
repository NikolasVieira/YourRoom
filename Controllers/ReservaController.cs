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

            string query =
            "INSERT INTO tb_reservas (qtd_hospedes, dt_reserva, dt_check_in, dt_check_out, reserva_status, check_in_status, check_out_status, quarto_id, hospede_id) " +
            "VALUES (@QtdHospedes, @DataReserva, @DataCheckIn, @DataCheckOut, @StatusReserva, @StatusCheckIn, @StatusCheckOut, @Quarto, @Hospede)";

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

            return Convert.ToInt32(dataBase.ExecuteQueryScalar(CommandType.Text, "SELECT MAX(id) FROM tb_reservas"));
        }
        #endregion

        #region Alterar
        public int Alterar(Reserva reserva)
        {
            string query =
                "UPDATE tb_reservas SET " +
                    "qtd_hospedes     = @QtdHospedes,    " +
                    "dt_reserva       = @DataReserva,    " +
                    "dt_check_in      = @DataCheckIn,    " +
                    "dt_check_out     = @DataCheckOut,   " +
                    "reserva_status   = @StatusReserva,  " +
                    "check_in_status  = @StatusCheckIn,  " +
                    "check_out_status = @StatusCheckOut, " +
                    "quarto_id        = @Quarto,         " +
                    "hospede_id       = @Hospede,        " +
                "WHERE id = @IdReserva";

            dataBase.ClearParameter();
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
        public int Apagar(int IdQuarto, int IdHospede)
        {
            string query = "DELETE FROM tb_reservas WHERE quarto_id = @IdQuarto AND hospede_id = @IdHospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdQuarto", IdQuarto);
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
                reserva.StatusReserva  = Convert.ToInt32(dataRow["status_reserva"]);
                reserva.StatusCheckIn  = Convert.ToInt32(dataRow["check_in_status"]);
                reserva.StatusCheckOut = Convert.ToInt32(dataRow["check_out_status"]);
                reserva.Quarto  = quartoController.ConsultarPorId(Convert.ToInt32(dataRow["quarto_id"]));
                reserva.Hospede = hospedeController.ConsultarPorId(Convert.ToInt32(dataRow["hospede_id"]));

                reservaCollection.Add(reserva);
            }
            return reservaCollection;
        }
        #endregion
    }
}

