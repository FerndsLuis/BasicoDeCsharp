using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Listas
    {
        public void ListasLinq()
        {
            /*
             * Com Linq - biblioteca - podemos em uma lista:
             *  Filtrar
             *  Remover
             *  Buscar
             *  etc...
             *  
             *  Utilizando listas com  System.Collections.Generic
             */

            List<string> clientes = new List<string>();
            clientes.Add("Luís");
            clientes.Add("Lima");
            clientes.Add("Cris");
            clientes.Add("Ana");

            string pessoa = "José";
            clientes.Add(pessoa);//atribuindo através de um objeto

            //Console.WriteLine(clientes[2]);
            clientes[2] = "Luís Fernandes";//alterando um dado
            //Console.WriteLine(clientes[2]);

            //exibindo os elementos
            foreach(string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            //removendo elementos da lista
            Console.WriteLine("-------------------------------------");

            clientes.RemoveAt(2);//removendo pelo índice 
            clientes.RemoveAll(c => c == "Luís"); //remove os elemento utilizando um predicado - Linq -

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }


            //Buscando elementos na lista
            Console.WriteLine("-------------------------------------");

            string busca = clientes.Find(c => c == "Ana");//findall para achar + de um dado ou Find par achar um dado - Utilizamos os predicados
            Console.WriteLine(busca);

            List<string> buscaTamanho = clientes.FindAll(c => c.Length > 3);

            foreach (string b in buscaTamanho)
            {
                Console.WriteLine(b);
            }

        }
    }
}
