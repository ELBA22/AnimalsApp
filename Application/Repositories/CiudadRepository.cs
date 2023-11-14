using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class CiudadRepository : GenericRepository<Ciudad>, ICiudad
    {
        private readonly AnimalContext _context;
        public CiudadRepository(AnimalContext context) : base(context)
        {
            _context = context;
        }
    }
}