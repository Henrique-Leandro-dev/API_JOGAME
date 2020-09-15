using API_Senai.Context;
using API_Senai.Domains;
using API_Senai.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Senai.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly JogadorContext _ctx;

        public JogoRepository()
        {
            _ctx = new JogadorContext();
        }
        public void Adicionar(Jogo jogo)
        {
            try
            {
                _ctx.Jogos.Add(jogo);

                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Jogo BuscarPorId(Guid id)
        {
            try
            {
                return _ctx.Jogos.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Editar(Jogo jogo)
        {
            try
            {
                Jogo jogoTemp = BuscarPorId(jogo.Id);
                if (jogoTemp == null)
                    throw new Exception("jogo não encontrado");

                jogoTemp.Nome = jogo.Nome;
                jogoTemp.Descricao = jogo.Descricao;
                jogoTemp.DataLanca = jogo.DataLanca;

                

                _ctx.Jogos.Update(jogoTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Jogo> Listar()
        {
            try
            {
                return _ctx.Jogos.ToList();
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
                Jogo jogoTemp = BuscarPorId(id);
                if (jogoTemp == null)
                    throw new Exception("Produto não encontrado");

                _ctx.Jogos.Remove(jogoTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
