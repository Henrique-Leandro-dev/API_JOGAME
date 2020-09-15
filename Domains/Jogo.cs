using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Senai.Domains
{
    public class Jogo : BaseDomain
    {
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLanca { get; set; }

       

    }

    //Jogador - Nome, Email, Senha, Data Nasc
    // Jogo - Nome, Descriçao, Data Lançamento
    //JogosJogadores - IdJogo, IdJogador
}
