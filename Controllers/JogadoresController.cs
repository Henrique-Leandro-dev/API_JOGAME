using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using API_Senai.Domains;
using API_Senai.Interfaces;
using API_Senai.Repositories;
using API_Senai.Utils;
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

        /// <summary>
        /// mostra todos os jogadores cadastrados
        /// </summary>
        /// <returns>Lista com jogadores</returns>
        [HttpGet]
        public List<Jogador> Get()
        {
            return _jogadorRepository.Listar();
        }

        /// <summary>
        /// Busca por determinado Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna o jogador do id escolhido </returns>
        // GET api/< JogadorRepository>/5
        [HttpGet("{id}")]
        public Jogador Get(Guid id)
        {
            return _jogadorRepository.BuscarPorId(id);
        }

      
        // POST api/<JogadorRepository>
        /// <summary>
        /// cadastra um jogador 
        /// </summary>
        /// <param name="jogador"></param>
        [HttpPost]
        public void Post([FromForm] Jogador jogador)
        {
            if (jogador.Imagem != null)
            {
                var urlImagem = Upload.Local(jogador.Imagem);

                jogador.UrlImagem = urlImagem;
            }
            
            _jogadorRepository.Adicionar(jogador);
        }

        // PUT api/<JogadorRepository>/5
        /// <summary>
        /// Modifica um determinado jogador 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="jogador"></param>
        [HttpPut("{id}")]
        public void Put(Guid id, Jogador jogador)
        {
            jogador.Id = id;
             _jogadorRepository.Editar(jogador);
        }

        // DELETE api/<RacaController>/5
        /// <summary>
        /// Deleta um determinado jogador 
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _jogadorRepository.Remover(id);
        }
    }
}
