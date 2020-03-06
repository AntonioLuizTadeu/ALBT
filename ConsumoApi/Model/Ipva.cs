using System.Runtime.Serialization;

namespace ConsumoApi.Model
{
    [DataContract]
    public class Ipva
    {
        [DataMember]
        public string Valor { get; set; }

        [DataMember]
        public string Exercicio { get; set; }

        [DataMember]
        public string CotaIpva { get; set; }
    }
}
