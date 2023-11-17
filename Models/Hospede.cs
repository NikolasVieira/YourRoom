using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourRoom.Models
{
    public class Hospede
    {
        public int IdHospede { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Telefone { get; set; }
    }
}
