using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ciudad :BaseEntity
    {
        public string NombreCiudad {get; set;}
        public int IdDep { get; set; }
        public Departamento Departamentos { get; set; }
        public int IdClienteDir { get; set; }
        public ClienteDireccion ClientesDirecciones {get; set;}
    }
}