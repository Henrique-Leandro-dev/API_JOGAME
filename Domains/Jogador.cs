using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Senai.Domains
{
    public class Jogador : BaseDomain
    {
        
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        
    }

    //Jogador - Nome, Email, Senha, Data Nasc
   // Jogo - Nome, Descriçao, Data Lançamento
        //JogosJogadores - IdJogo, IdJogador
}
