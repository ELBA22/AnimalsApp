using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class MascotaRepository :GenericRepository<Mascota>, IMascota
    {
        private readonly AnimalContext _context;

        public MascotaRepository(AnimalContext context) : base(context)
        {
            _context = context;
        }
    }
}