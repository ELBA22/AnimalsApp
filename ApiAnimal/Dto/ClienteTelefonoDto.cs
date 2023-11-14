using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimal.Dto
{
    public class ClienteTelefonoDto
    {
        public int Id {get; set;}

        public int IdCliente {get; set;}
        public string Numero {get; set;}
    }
}