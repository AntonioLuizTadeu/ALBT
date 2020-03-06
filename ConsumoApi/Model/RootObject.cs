using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract]
    public class RootObject : Base
    {
        [DataMember(Name = "serializedObject")]
        public SerializedObject Data { get; set; }

        [DataMember]
        public bool isResponseOk { get; set; }

        [DataMember]
        public int statusCode { get; set; }
    }



}
