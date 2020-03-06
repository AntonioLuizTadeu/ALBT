using System.IO;
using System.Net;
using System.Text;

namespace ConsumoApi
{
    public static class ConsultarDebitos
    {
        public static string PesquisaDebito(string renavam, string codServico
                                                , string codSubServico
                                                , string tipoConsulta)
        {
            string retorno;

            string json = "{\"TokenCliente\": \"pItRnemCfitpFgjHGhGESA==\"," +
                                   "\"FormaPagamento\": \"D\"," +
                                    "\"ListaParametroDebitoVeiculo\":" +
                                    "[{\"Renavam\":\""    + renavam + "\"," +
                                    "\"CodServico\":\""   + codServico + "\"," +
                                    "\"CodSubServico\":\""+ codSubServico + "\"," +
                                    "\"TipoConsulta\":\"" + tipoConsulta + "\"}]}";

            string url = "http://187.9.76.122:8901/Debito/ConsultarDebitos/";
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

            //var httpWebRequest = (HttpWebRequest)WebRequest.Create(" http://187.9.76.122:8901/Debito/ConsultarDebitos/");
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";

            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    string json = "{\"TokenCliente\": \"pItRnemCfitpFgjHGhGESA==\"," +
            //                       "\"FormaPagamento\": \"D\"," +
            //                        "\"ListaParametroDebitoVeiculo\":" +
            //                        "[{\"Renavam\":\"00303673320\"," +
            //                        "\"CodServico\":\"8\"," +
            //                        "\"CodSubServico\":\"1\"," +
            //                        "\"TipoConsulta\":\"D\"}]}";
            //    streamWriter.Write(json);
            //}

            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //if (httpResponse.StatusCode == HttpStatusCode.OK)

            //    Console.WriteLine("A U T E N T I C A D O -- > ConsultarDebitos");

            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();

            //    System.Console.WriteLine(result);
            //    System.Console.WriteLine("");
            //}

        }

    }
}
