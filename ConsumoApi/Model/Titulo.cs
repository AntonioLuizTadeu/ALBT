using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    public class Titulo
    {
        public string NossoNumero { get; set; }
        public string LinhaDigitavel { get; set; }
        public string CodBarras { get; set; }
        public double Valor { get; set; }
        public string DataVencimento { get; set; }
        public string Pdf { get; set; }
        public Retorno Retorno { get; set; }
    }
}
