using API_Senai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Senai.Interfaces
{
    interface IJogoRepository
    {
        List<Jogo> Listar();

        Jogo BuscarPorId(Guid id);
        void Adicionar(Jogo jogo);
        void Editar(Jogo jogo);
        void Remover(Guid id);
    }
}
