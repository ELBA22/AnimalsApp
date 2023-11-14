using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class ClienteDireccionRepository : GenericRepository<ClienteDireccion>, IClienteDireccion
    {
        private readonly AnimalContext _context;
        public ClienteDireccionRepository(AnimalContext context) : base(context)
        {
            _context = context;
        }
    }
}