using ConsumoApi;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ConsultaDebitoTaxaController : ApiController
    {
        // POST: api/ConsultaDebito
        [HttpPost]
        public string ConsultaInformacoesDebitoTaxa([FromBody]Parametros.ParametrosConsultaDebito param)
        {
            var retorno = ConsultaDebitosTaxas.PesquisaDebitoTaxas(param.Renavam, param.CodServico,
                                                                    param.CodSubServico, param.TipoConsulta);
         
            return retorno;
        }


    }
}
