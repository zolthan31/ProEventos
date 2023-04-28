using System.Diagnostics.Tracing;
using System.Collections;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Belem",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageURL = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular e Suas novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImageURL = "foto2.png"
            }
        };

        public EventoController() { }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
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
