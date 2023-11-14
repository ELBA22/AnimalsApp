using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class DepartamentoRepository :GenericRepository<Departamento>, IDepartamento
    {
        private readonly AnimalContext _context;

        public DepartamentoRepository(AnimalContext context) : base(context)
        {
            _context = context;
        }
    }
}