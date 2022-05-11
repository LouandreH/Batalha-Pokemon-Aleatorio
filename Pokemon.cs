using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___POO
{
    public class Pokemon
    {

        public Pokemon()
        {
            this.Nome = " ";
            this.Descricao = " ";
            

        }

        public Pokemon(String nome, String descricao)
        {

            this.Nome = nome;
            this.Descricao = descricao;
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set {
                String texto = value.ToUpper();
                nome = texto;
            
            }
        }

        private String descricao;

        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value.ToUpper(); }
        }

        



        public void ExibirDadosPokemon()
        {
            
            Console.WriteLine("Nome do Pokemon: "+this.Nome);
            Console.WriteLine("Descricao do Pokemon: " +this.Descricao);
            Console.WriteLine("---------------------------------");

        }

       
    }
}
