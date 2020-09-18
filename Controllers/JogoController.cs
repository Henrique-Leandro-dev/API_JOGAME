using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Senai.Domains;
using API_Senai.Interfaces;
using API_Senai.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Senai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IJogoRepository _jogoRepository;
        public JogoController()
        {
            _jogoRepository = new JogoRepository();
        }

        [HttpGet]
        public List<Jogo> Get()
        {
            return _jogoRepository.Listar();
        }

        // GET api/<JogoController>/5
        [HttpGet("{id}")]
        public Jogo Get(Guid id)
        {
            return _jogoRepository.BuscarPorId(id);
        }

        // POST api/<JogoController>
        [HttpPost]
        public void Post(Jogo jogo)
        {
            _jogoRepository.Adicionar(jogo);
        }

        // PUT api/<JogoController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, Jogo jogo)
        {
            jogo.Id = id;
            _jogoRepository.Editar(jogo);
        }

        // DELETE api/<JogoController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _jogoRepository.Remover(id);
        }
    }
}
