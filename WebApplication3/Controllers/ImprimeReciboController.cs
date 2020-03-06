using ConsumoApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ImprimeReciboController : ApiController
    {

        // POST: api/ImprimeRecibo
        [HttpPost]
        public string Recibo([FromBody]Parametros.Recibo param)
        {
            var retorno = ImprimirRecibo.Recibo(param.CodRecibo);
            return retorno;
        }
    }

       
    
}
