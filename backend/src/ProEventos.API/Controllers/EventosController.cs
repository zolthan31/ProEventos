﻿using System.Diagnostics.Tracing;
using System.Collections;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {        
        private readonly DataContext _context;

        public EventosController(DataContext context) 
        {
            _context = context;
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento =>
             evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "teste post";
        }

        [HttpPut]
        public string Put()
        {
            return "teste put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "teste delete";
        }
    }
}
