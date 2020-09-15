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
    public class JogadoresController : ControllerBase
    {
        private readonly IJogadorRepository _jogadorRepository;

        public JogadoresController()
        {
            _jogadorRepository = new JogadorRepository();
        }

        [HttpGet]
        public List<Jogador> Get()
        {
            return _jogadorRepository.Listar();
        }

        // GET api/<RacaController>/5
        [HttpGet("{id}")]
        public Jogador Get(Guid id)
        {
            return _jogadorRepository.BuscarPorId(id);
        }

        // POST api/<RacaController>
        [HttpPost]
        public void Post( Jogador jogador)
        {
             _jogadorRepository.Adicionar(jogador);
        }

        // PUT api/<RacaController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, Jogador jogador)
        {
            jogador.Id = id;
             _jogadorRepository.Editar(jogador);
        }

        // DELETE api/<RacaController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _jogadorRepository.Remover(id);
        }
    }
}
