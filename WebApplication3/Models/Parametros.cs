using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Parametros
    {
        public class ParametroPagamentoDebito
        {

            public string Renavam { get; set; }
            public string Placa { get; set; }
            public string Documento { get; set; }
            public string Exercicio { get; set; }
            public string Nome { get; set; }
            public string CodServico { get; set; }
            public string CodSubServico { get; set; }
            public string ValorTotal { get; set; }


        }

        public class ParametrosConsultaDebito
        {
            public string Renavam { get; set; }
            public string CodServico { get; set; }
            public string CodSubServico { get; set; }
            public string TipoConsulta { get; set; }

        }
        public class Recibo
        {
            public string CodRecibo { get; set; }

        }

        public class Titulo
        {
            public string NossoNumero { get; set; }

        }
        //  
    }
}