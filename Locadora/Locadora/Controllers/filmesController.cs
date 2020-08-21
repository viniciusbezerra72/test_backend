using Locadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Locadora.Controllers
{
    [RoutePrefix("api")]
    public class filmesController : ApiController
    {
        private static List<filme> filmes = new List<filme>();

       public List<filme> Get()
        {
            return filmes;
        }

        [HttpPost]

        public void Post(filme filme)
        {
            filmes.Add(filme);
            
        }
    }
}
