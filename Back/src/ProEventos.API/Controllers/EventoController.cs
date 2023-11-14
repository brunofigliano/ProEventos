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
        public IEnumerable<Evento> _evento = new Evento[] {
                 new() {
                    EventoId = 1,
                    Local = "Belo Horizonte",
                    DataEvento = "01/02/2024",
                    Tema = "Angular",
                    QtdPessoas = 150,
                    Lote = "Primeiro Lote",
                    ImagemUrl = "img.png",
                },
                  new() {
                    EventoId = 2,
                    Local = "São Paulo",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "Angular e C#",
                    QtdPessoas = 350,
                    Lote = "Segundo Lote",
                    ImagemUrl = "img1.png",
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
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
