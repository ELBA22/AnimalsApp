using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class CitaRepository : GenericRepository<Cita>, ICita
    {
        private readonly AnimalContext _context;
        public CitaRepository(AnimalContext context) : base(context)
        {
            _context = context;
        }
    }
}