using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AnimalContext _context;
        private CitaRepository _citas;
        private PaisRepository _paises;
        private DepartamentoRepository _departamentos;
        private ClienteRepository _clientes;
        private MascotaRepository _mascostas;
        private RazaRepository _razas;
    }
}