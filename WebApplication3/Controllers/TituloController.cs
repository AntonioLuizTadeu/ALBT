using ConsumoApi;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class TituloController : ApiController
    {

        // POST: api/Titulo
        [HttpPost]
        public string ReimprimeTitulo([FromBody]Parametros.Titulo param)
        {
            var retorno = Titulo.ReimprimeTitulo(param.NossoNumero);
            return retorno;
        }


    }
}
