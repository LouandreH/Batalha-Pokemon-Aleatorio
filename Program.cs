using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0 )
            {
                resp = Menu();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }if (resp == 2)
                {
                    pokedex.ListarPokemons();

                    Console.WriteLine("Digite o código do seu Pokemon: ");
                    int codigo =Convert.ToInt32(Console.ReadLine());

                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPc = pokedex.Pokemons [codigo];
                    Console.Clear();
                    Console.WriteLine("Dados dos Pokemons que irão lutar: ");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Dados do seu Pokemon: ");
                    Console.WriteLine("---------------------------------");
                    pPlayer.ExibirDadosPokemonPlus();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Dados do seu Adversário Pokemon: ");
                    Console.WriteLine("---------------------------------");
                    pPc.ExibirDadosPokemonPlus();
                    if (pPlayer.Poder > pPc.Poder)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Player 1 Ganhou!!!!!");
                    }
                    else if (pPlayer.Poder < pPc.Poder)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Player 2 Ganhou!!!");
                        Console.WriteLine("---------------------------------");
                        pPc.ExibirDadosPokemonPlus();
                        

                    }else
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Empate");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
            
            Console.ReadKey();
          
        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Pokemon --JOGO DE BATALHA-----");
            Console.WriteLine("0- SAIR DA POKEDEX");
            Console.WriteLine("1- TODOS POKEMONS");
            Console.WriteLine("2- BATALHAR");
            Console.Write("QUAL OPÇÃO VOCÊ DESEJA?: ");
            
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
        

    }
}
