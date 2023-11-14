using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAnimal.Dto;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnimal.Controllers
{
    public class CiudadController :BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Mapper _mapper;

        public CiudadController(IUnitOfWork unitOfWork, Mapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<CiudadDto>>> Get()
        {
            var ciudades = await _unitOfWork.Ciudades.GetAllAsync();
            return _mapper.Map<List<CiudadDto>>(ciudades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CiudadDto>> Get(int id)
        {
            var ciudad = await _unitOfWork.Ciudades.GetByIdAsync(id);
            if(ciudad == null)
            {
                return NotFound();
            }
            return _mapper.Map<CiudadDto>(ciudad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CiudadDto>>Post(CiudadDto ciudadDto)
        {
            var ciudad = _mapper.Map<Ciudad>(ciudadDto);
            this._unitOfWork.Ciudades.Add(ciudad);
            await _unitOfWork.SaveAsync();
            if(ciudad == null)
            {
                return BadRequest();
            }
            ciudadDto.Id = ciudad.Id;
            return CreatedAtAction(nameof(Post), new {id = ciudadDto.Id}, ciudadDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CiudadDto>> put(int id, [FromBody] CiudadDto ciudadDto)
        {
            var ciudad = _mapper.Map<Ciudad>(ciudadDto);
            if(ciudad == null)
            {
                return NotFound();
            }
            if (ciudad.Id == 0)
            {
                ciudad.Id = id;
            }
            if (ciudad.Id != id)
            {
                return BadRequest();
            }
            ciudadDto.Id = ciudad.Id;
            _unitOfWork.Ciudades.Update(ciudad);
            await _unitOfWork.SaveAsync();
            return ciudadDto;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<Ciudad>> Delete(int id)
            {
                var ciudad = await _unitOfWork.Ciudades.GetByIdAsync(id);
                if(ciudad == null)
                {
                    return NotFound();
                }
                _unitOfWork.Ciudades.Remove(ciudad);
                await _unitOfWork.SaveAsync();
                return NoContent();
            }
    }
}