using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimal.Dto
{
    public class ClienteDireccionDto
    {
        public string TipoDeVia {get; set;}
        public int NumeroPri { get; set; }
        public string Letra { get; set; }
        public string Bis { get; set; }
        public string LetraSec { get; set; }
        public string Cardinal { get; set; }
        public int NumeroSec { get; set; }
        public string LetraTer { get; set; }
        public int NumeroTer { get; set; }
        public string CardinalSec { get; set; }
        public string Complemento { get; set; }
        public string CodigoPostal { get; set; }
        public int IdCiudadFk { get; set; }
    
        public int IdClienteFk {get; set;}
    }
}