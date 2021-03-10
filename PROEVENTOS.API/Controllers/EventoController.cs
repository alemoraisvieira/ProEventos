using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROEVENTOS.API.Models;

namespace PROEVENTOS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento  = new Evento[]{

            new Evento(){ 
                EvenId = 1,
                Tema = "Curso Angular",
                Local = "São Paulo",
                Lote = "1",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")  
                },
                new Evento(){ 
                EvenId = 2,
                Tema = "Curso sql",
                Local = "São Paulo",
                Lote = "1",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddHours(2).ToString("dd/MM/yyyy")  
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


        [HttpPost]
        public string Post()
        {
           return "post"; 
        }


        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"exemplo de put com id = {id}";
        }
 
        [HttpDelete("{id}")]
        public string HttpDelete(int id)
        {
           return $"exemplo de delete com id = {id}";
        }
    }
}
