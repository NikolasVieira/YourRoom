using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourRoom.Models
{
    public class Quarto
    {
        public int IdQuarto { get; set; } 
        public int Numero { get; set; } // Número do Quarto
        public int Categoria { get; set; } // Categoria do Quarto
        public int Status { get; set; } // Status do Quarto
        public decimal Diaria { get; set; } // Valor da Diaria do Quarto
        public int Capacidade { get; set; } // Capacidade de Pessoas
    }
}
