using API_Senai.Context;
using API_Senai.Domains;
using API_Senai.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Senai.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly JogadorContext _ctx;

        public JogadorRepository()
        {
            _ctx = new JogadorContext();
        }

        public void Adicionar(Jogador jogador)
        {
            try
            {
                _ctx.Jogadores.Add(jogador);

                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Jogador BuscarPorId(Guid id)
        {
            try
            {
                return _ctx.Jogadores.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Editar(Jogador jogador)
        {
            try
            {
                Jogador jogadorTemp = BuscarPorId(jogador.Id);
                if (jogadorTemp == null)
                    throw new Exception("jogador não encontrado");

                jogadorTemp.Nome = jogador.Nome;
                jogadorTemp.Email = jogadorTemp.Email;
                jogadorTemp.DataNascimento = jogadorTemp.DataNascimento;
                jogadorTemp.Senha = jogadorTemp.Senha;

                _ctx.Jogadores.Update(jogadorTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }

        public List<Jogador> Listar()
        {
            try
            {
                return _ctx.Jogadores.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remover(Guid id)
        {
            try
            {
                Jogador jogadorTemp = BuscarPorId(id);
                if (jogadorTemp == null)
                    throw new Exception("Produto não encontrado");

                _ctx.Jogadores.Remove(jogadorTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
