using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    public class MultasRenainf
    {
        public string Aiip { get; set; }
        public string Guia { get; set; }
        public string DataInfracao { get; set; }
        public string Uf { get; set; }
        public Municipio3 Municipio { get; set; }
        public Enquadramento2 Enquadramento { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public OrgaoAutuador2 OrgaoAutuador { get; set; }
    }
}
