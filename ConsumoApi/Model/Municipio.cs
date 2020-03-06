using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class Municipio
    {
        [DataMember]
        public string CodFederal { get; set; }

        [DataMember]
        public string CodEstadual { get; set; }

        [DataMember]
        public string Nome { get; set; }

    }
}
