using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi
{
   public static class ImprimirRecibo
    {
        public static string Recibo(string codrecibo)
        {
            string retorno;

            string json = "{\"TokenCliente\": \"pItRnemCfitpFgjHGhGESA==\"," +
                                    "\"ReciboRetorno\":" +
                                    "[{\"CodRecibo\":\"" + codrecibo + "\"" +
                                    "}]}";

            string url = "http://187.9.76.122:8901/Debito/ImprimirRecibo/";
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] data = encoder.GetBytes(json);//Aqui no meio vai o json para o post cade esses dados?

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            request.Expect = "application/json";

            request.GetRequestStream().Write(data, 0, data.Length);
            HttpWebResponse webResponse = request.GetResponse() as HttpWebResponse;


            using (var stream = webResponse.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                string jsonRetorno = reader.ReadToEnd();
                retorno = jsonRetorno;
                //retorno = JSONSerializer<RootObject>.DeSerialize(jsonRetorno);
                //retorno.StatusCode = webResponse.StatusCode;
            }
            return retorno;

            

        }
    }
}
