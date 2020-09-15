using API_Senai.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Senai.Context
{
    public class JogadorContext : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<JogoJogador> JogosJogadores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-V0C9ELT0\SQLEXPRESS;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
