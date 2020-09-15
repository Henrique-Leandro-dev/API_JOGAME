using API_Senai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Senai.Interfaces
{
    public interface IJogadorRepository
    {
        List<Jogador> Listar();

        Jogador BuscarPorId(Guid id);
        void Adicionar(Jogador jogador);
        void Editar(Jogador jogador);
        void Remover(Guid id);
    }
}
