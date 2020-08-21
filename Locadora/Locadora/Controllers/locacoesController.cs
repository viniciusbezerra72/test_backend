using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Locadora.Controllers
{
    [RoutePrefix("api")]
    public class locacoesController : ApiController
    {
        private static List<Locacao> locacoes = new List<Locacao>();

        public List<Locacao> Get()
        {
            return locacoes;
        }

        [HttpPost]

        public void Post(Locacao locacao)
        {
            locacoes.Add(locacao);
           
        }

    }
}
