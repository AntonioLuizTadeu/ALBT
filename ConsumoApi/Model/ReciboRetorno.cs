using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class ReciboRetorno
    {
        [DataMember]
        public string CodRecibo { get; set; }
        [DataMember]
        public string Pdf { get; set; }
    }
}
