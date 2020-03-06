using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    public class Multa
    {
        public string Aiip { get; set; }
        public string Guia { get; set; }
        public string CodSegmento { get; set; }
        public string CodEmpresaOrgao { get; set; }
        public string DataInfracao { get; set; }
        public Municipio2 Municipio { get; set; }
        public Enquadramento Enquadramento { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public OrgaoAutuador OrgaoAutuador { get; set; }
    }
}
