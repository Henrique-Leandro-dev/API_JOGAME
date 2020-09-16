using API_Senai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Senai.Interfaces
{
    interface IJogoJogador
    {
       
        List<JogoJogador> Listar();
        JogoJogador BuscarPorId(Guid id);
        void Adicionar(JogoJogador jogador);
        void Editar(JogoJogador jogador);
        void Remover(Guid id);
    }
}
