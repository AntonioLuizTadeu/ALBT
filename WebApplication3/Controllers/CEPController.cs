using ConsumoApi;
using ConsumoApi.Model;
using ConsumoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CEPController : ApiController
    {
        [HttpGet]
        public string Teste()
        {
            return "Teste de acesso api";
        }

        /// <summary>
        /// URL de chamada no POSTMAN: http://localhost:25394/api/CEP/BuscaInformacoes
        /// </summary>
        /// <param name="param">{ "CEP":"11704150" }</param>
        /// <returns>JSON tipo esse: "{\"Mensagem\":null,\"StatusCode\":200,\"bairro\":\"Ocian\",\"cep\":\"11704-150\",\"complemento\":\"\",\"gia\":\"5587\",\"ibge\":\"3541000\",\"localidade\":\"Praia Grande\",\"logradouro\":\"Rua Monteiro Lobato\",\"uf\":\"SP\",\"unidade\":\"\"}"</returns>
        /// 

        [HttpPost]
        public string BuscaInformacoes([FromBody]BuscaInformacoesParam param)
        {
            var retorno = ViaCEP.BuscarCEP(param.CEP);
            var json = JSONSerializer<RetornoConsultaCEP>.Serialize(retorno);
            return json;
        }
    }
}
