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
                Local = "Salvador",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular 11 e Dotnet 5",
                QtdPessoas = 250,
                Lote = "1º Lote",
                ImagemURL = "foto.exemplo"
            },
                new Evento()
                {   
                EventoId = 2,
                Local = "Castro Alves",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                Tema = "História",
                QtdPessoas = 78,
                Lote = "2º Lote",
                ImagemURL = "foto.jpg"
            }
        };
    
        public EventoController()
        {    
        }

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
            return "Exemplo de Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put = {id} ";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete = {id} ";
        }
    }
}
