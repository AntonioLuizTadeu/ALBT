using ConsumoApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class SaldoController : ApiController
    {

        // POST: api/Saldo
        [HttpPost]
        public string Recibo([FromBody] string value)
        {
            var retorno = Saldo.SaldoDisponivel();
            return retorno;
        }
    }


}

