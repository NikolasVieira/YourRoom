using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourRoom.Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int QtdHospedes { get; set; } // A quantidade de Hospede 
        public DateTime DtReserva { get; set; } // A data que a reserva foi feita
        public DateTime DtCheckIn { get; set; } // A data que o check-in deve ser feito
        public DateTime DtCheckOut { get; set; } // A data que o check-out deve ser feito
        public int StatusReserva { get; set; } // Status da Reserva (Pendente, Ativa, Encerrado)
        public int StatusCheckIn { get; set; } // Status da Reserva (Pendente, Encerrado)
        public int StatusCheckOut { get; set; } // Status da Reserva (Pendente, Encerrado)
        public Quarto Quarto { get; set; } // O Quarto da reserca
        public Hospede Hospede { get; set; } // O Hospede que fez a reserva
    }
}
