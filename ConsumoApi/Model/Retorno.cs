using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class Retorno
    {
        [DataMember]
        public string TipoRetorno { get; set; }

        [DataMember]
        public string Mensagem { get; set; }

    }
}
