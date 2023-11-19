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
        public DateTime DataReserva { get; set; } // A data que a reserva foi feita
        public DateTime DataCheckIn { get; set; } // A data que o check-in deve ser feito
        public DateTime DataCheckOut { get; set; } // A data que o check-out deve ser feito
        public string StatusReserva { get; set; } // Status da Reserva (Pendente, Ativa, Encerrado)
        public string StatusCheckIn { get; set; } // Status da Reserva (Pendente, Encerrado)
        public string StatusCheckOut { get; set; } // Status da Reserva (Pendente, Encerrado)
        public Quarto Quarto { get; set; } // O Quarto da reserca
        public Hospede Hospede { get; set; } // O Hospede que fez a reserva
    }
}
