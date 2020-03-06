using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class ListaDebito
    {
        [DataMember]
        public string Renavam { get; set; }

        [DataMember]
        public string Placa { get; set; }

        [DataMember]
        public string Documento { get; set; }

        [DataMember]
        public int Exercicio { get; set; }

        [DataMember]
        public string Nome { get; set; }

        //[DataMember]
        //public Municipio Municipio { get; set; }

        [DataMember]
        public int CodServico { get; set; }

        [DataMember]
        public int CodSubServico { get; set; }

        [DataMember]
        public string TipoConsulta { get; set; }

        //[DataMember]
        //public Ocorrencia Ocorrencia { get; set; }

        [DataMember]
        public Retorno Retorno { get; set; }

        [DataMember]
        public double ValorTotal { get; set; }

        [DataMember]
        public double ValorIpvas { get; set; }

        [DataMember]
        public IpvaAtual IpvaAtual { get; set; }

        [DataMember]
        public List<Ipva> Ipvas { get; set; }

        [DataMember]
        public DateTime DataMovimento { get; set; }

        [DataMember]
        public DateTime DataHoraConsulta { get; set; }
    }
}
