using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Model
{
    [DataContract(Name = "serializedObject")]
    public class SerializedObject
    {
        [DataMember]
        public List<ListaDebito> ListaDebitos { get; set; }

        [DataMember]
        public List<Ipva> Ipvas { get; set; }
    }
}
