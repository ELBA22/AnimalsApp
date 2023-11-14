using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using ApiAnimal.Dto;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnimal.Controllers
{
    public class ClienteDireccionController :BaseController
    {
        private readonly IUnitOfWork _uniOfWork;
        private readonly Mapper _mapper;

        public ClienteDireccionController(IUnitOfWork unitOfWork, Mapper mapper)
        {
            _uniOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ClienteDireccionDto>>> Get()
        {
            var  clienteDir = await _uniOfWork.ClienteDirecciones.GetAllAsync();
            return _mapper.Map<List<ClienteDireccionDto>>(clienteDir);
        }

        
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ClienteDireccionDto>> Get(int id)
        {
            var clienteDir = await _uniOfWork.ClienteDirecciones.GetByIdAsync(id);
            if(clienteDir == null)
            {
                return NotFound();
            }
            return _mapper.Map<ClienteDireccionDto>(clienteDir);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDireccionDto>> Post(ClienteDireccionDto clienteDireccionDto)
        {
            var clienteDir = _mapper.Map<ClienteDireccion>(clienteDireccionDto);
            this._uniOfWork.ClienteDirecciones.Add(clienteDir);
            await _uniOfWork.SaveAsync();
            if(clienteDir == null)
            {
                return BadRequest();
            }
            clienteDireccionDto.Id = clienteDireccionDto.Id;
            return CreatedAtAction(nameof(Post), new {id = clienteDireccionDto.Id}, clienteDireccionDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDireccionController>Lis


        
    }
}