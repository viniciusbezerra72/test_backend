using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora.Models
{
    public class locacao
    {
        public int Id { get; set; }  
        public DateTime dtLocacao { get; set; }
        public DateTime dtDevolucao { get; set; }
        public cliente cliente { get; set; }
        public int clienteId { get; set; }
        public filme filme { get; set; }
        public int filmeId { get; set; }

    

        

    }
}