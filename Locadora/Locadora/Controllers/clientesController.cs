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
    public class clientesController : ApiController
    {
        
        private static List<cliente> clientes = new List<cliente>();

        public List<cliente> Get()
        {
            return clientes;

        }

        [HttpPost]
        public void Post(cliente cliente)
        {
            //if(!string.IsNullOrEmpty(cliente))
                clientes.Add(cliente);               
             
        }
        
    }
}
