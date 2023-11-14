using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimal.Dto
{
    public class CiudadDto
    {
        public int Id {get; set;}

        public string NombreCiudad {get ; set; }

        public int IdDeparFk {get; set;}
    }
}