using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class Base
    {
        [DataMember]
        public HttpStatusCode StatusCode { get; set; }

        [DataMember]
        public string Mensagem { get; set; }
    }
}
