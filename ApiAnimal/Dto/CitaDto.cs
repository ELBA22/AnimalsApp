using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimal.Dto
{
    public class CitaDto
    {
        public int Id {get; set;}

        public DateOnly Fecha {get; set;}

        public TimeOnly Hora {get; set;}

        public int IdCliente {get; set;}

        public int IdMascota {get; set;}

        public int IdServicio {get; set;}
        
    }
}