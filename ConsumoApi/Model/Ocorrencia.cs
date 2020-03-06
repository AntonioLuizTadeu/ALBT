using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class Ocorrencia
    {
        [DataMember]
        public string CodOcorrencia { get; set; }

        [DataMember]
        public string Descricao { get; set; }

    }
}
