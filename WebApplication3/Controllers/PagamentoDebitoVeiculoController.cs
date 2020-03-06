using ConsumoApi;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PagamentoDebitoVeiculoController : ApiController
    {

       [HttpPost]
        // POST: api/PagamentoDebitoVeiculo

        public string DebitoVeiculo([FromBody] Parametros.ParametroPagamentoDebito param)
        {
            var retorno = PagarDebito.PagamentoVeiculo(param.Renavam,param.Placa,param.Documento,
                                                       param.Exercicio, 
                                                       param.Nome, param.CodServico,
                                                       param.CodSubServico,param.ValorTotal
                                                       );

            return retorno;
        }

    }

    
}
