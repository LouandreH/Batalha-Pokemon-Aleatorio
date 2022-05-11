using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___POO
{
    public class Pokedex
    {   
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }
        

        private void InicializaLista()
        {
            this.pokemons = new List<PokemonPlus> ();
            Pokemon p = new PokemonPlus("Blastoise", "Tipo Agua", 8); 
            this.pokemons.Add ((PokemonPlus)p);
            p = new PokemonPlus("Bulbassauro", " Tipo Planta", 10);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Charmander", "Tipo Fogo", 9);
            this.pokemons.Add((PokemonPlus)p);

        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.pokemons.Count; i++)
            {
                Console.WriteLine("Codigo do Pokemon: " + i);
                this.pokemons[i].ExibirDadosPokemon();
                
            }
        }
    }
}
