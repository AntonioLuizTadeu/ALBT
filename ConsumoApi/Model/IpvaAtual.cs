using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class IpvaAtual
    {
        [DataMember]
        public string Exercicio { get; set; }

        [DataMember]
        public string DataVencimentoComDesconto { get; set; }

        [DataMember]
        public string ValorComDesconto { get; set; }

        [DataMember]
        public string DataVencimentoSemDesconto { get; set; }

        [DataMember]
        public string ValorSemDesconto { get; set; }

        [DataMember]
        public string DataVencimentoParcela1 { get; set; }

        [DataMember]
        public string ValorParcela1 { get; set; }

        [DataMember]
        public string DataVencimentoParcela2 { get; set; }

        [DataMember]
        public string ValorParcela2 { get; set; }

        [DataMember]
        public string DataVencimentoParcela3 { get; set; }

        [DataMember]
        public string ValorParcela3 { get; set; }

        [DataMember]
        public string DataVencimentoParcela4 { get; set; }

        [DataMember]
        public string ValorParcela4 { get; set; }

        [DataMember]
        public string DataVencimentoParcela5 { get; set; }

        [DataMember]
        public string ValorParcela5 { get; set; }

        [DataMember]
        public string ValorParcela6 { get; set; }
    }
}
