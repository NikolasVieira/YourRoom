using YourRoom.Models;
using YourRoom.Services;
using System;
using System.Data;

namespace YourRoom.Controllers
{
    public class ReservaController
    {
        #region Variaveis Locais
        // Importa os métodos que realizam interação com o banco de dados
        DataBaseSqlServer dataBase = new DataBaseSqlServer();
        #endregion

        #region Inserir
        // Insere na tabela de reserva
        public int Inserir(Reserva reserva)
        {
            // Limpa os parametros que podem estar na Query
            dataBase.ClearParameter();

            // Query que vai ser executada
            string queryInsertReserva =
            "INSERT INTO Reserva (Quarto, Hospede, QtdHospedes, DataReserva, DataCheckIn, DataCheckOut, StatusReserva, StatusCheckIn, StatusCheckOut) "+
            "VALUES (@Quarto, @Hospede, @QtdHospedes, @DataReserva, @DataCheckIn, @DataCheckOut, @StatusReserva, @StatusCheckIn, @StatusCheckOut)";

            //Adiona os valores de cada parametro que esta sendo utilizado
            //dataBase.AddParameter("@Quarto",         reserva.Quarto); 
            //dataBase.AddParameter("@Hospede",        reserva.Hospede);
            dataBase.AddParameter("@QtdHospedes",    reserva.QtdHospedes);
            dataBase.AddParameter("@DataReserva",    reserva.DataReserva);
            dataBase.AddParameter("@DataCheckIn",    reserva.DataCheckIn);
            dataBase.AddParameter("@DataCheckOut",   reserva.DataCheckOut);
            dataBase.AddParameter("@StatusReserva",  reserva.StatusReserva);
            dataBase.AddParameter("@StatusCheckIn",  reserva.StatusCheckIn);
            dataBase.AddParameter("@StatusCheckOut", reserva.StatusCheckOut);

            //Solicita a camada de banco de dados a execução da query
            dataBase.ExecuteManipulation(CommandType.Text, queryInsertReserva);
            //Nesse momento o meu comando é executado no banco de dados

            //Executar um comando no banco de dados, para recupear o ID criado
            //pelo Identity
            //SELECT @@IDENTITY
            return Convert.ToInt32(dataBase.ExecuteQueryScalar(
                CommandType.Text, "SELECT @@IDENTITY"));
        }
        #endregion
    }
}
