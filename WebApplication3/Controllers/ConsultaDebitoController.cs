using ConsumoApi;

using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ConsultaDebitoController : ApiController
    {

         // POST: api/ConsultaDebito

        [HttpPost]
        public string ConsultaInformacoesDebito([FromBody]Parametros.ParametrosConsultaDebito param)
        {
            var retorno = ConsultarDebitos.PesquisaDebito(param.Renavam,param.CodServico,param.CodSubServico,param.TipoConsulta);
            //var json = JSONSerializer<RootObject>.Serialize(retorno);
            return retorno;
        }

       

    }
}
