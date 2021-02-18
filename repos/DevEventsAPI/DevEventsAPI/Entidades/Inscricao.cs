using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEventsAPI.Entidades
{
    public class Inscricao
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdEvento { get; set; }
    }
}
