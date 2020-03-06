using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class ListaParametroPagamentoVeiculo
    {
        [DataMember]
        public string CodServico { get; set; }
        [DataMember]
        public string CodSubServico { get; set; }
        [DataMember]
        public string ValorTotal { get; set; }
        [DataMember]
        public string Renavam { get; set; }
        [DataMember]
        public string Placa { get; set; }
        [DataMember]
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string CodFederal { get; set; }
        public string LocalEntrega { get; set; }
        public string ControleCliente { get; set; }
        [DataMember]
        public List<Ipva> Ipvas { get; set; }
        [DataMember]
        public List<Dpvat> Dpvats { get; set; }
        [DataMember]
        public List<Multa> Multas { get; set; }
        [DataMember]
        public List<MultasRenainf> MultasRenainf { get; set; }
        public IpvaAtual IpvaAtual { get; set; }
        public DpvatAtual DpvatAtual { get; set; }
    }
}
