using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ************************************************************* 
             * Bloco 1º - conceitos básicos de variáveis
             * 
            int segundaGuerraMundial = 1942; //Declarando váriavel do tipo int
            string cor_favorita = "vermelho"; //Declarando váriavel do tipo string
            float velocidadeF1 = 294.48f; //Declarando váriavel do tipo float - precisa do "f"
            bool segundaGuerrraMundialAconteceu = true; //Declarando váriavel do tipo boleano

            //Exibindo variáveis
            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerrraMundialAconteceu);
            */

            /* ************************************************************* 
            * Bloco 2º - declarando variável sem especificar o tipo
            * 
            *
            var cor_favorita = "Vermelho"; // automáticamente é tipada como string, não pode ser alterada para um int, por exemplo
            var modeloDoProduto = 1010; // automáticamente é tipada como int, não pode ser alterada para um string, por exemplo
            */

            /* ************************************************************* 
            * Bloco 3º - declarando variável dinâmica
            *           
            *
            dynamic cor_favorita = "Vermelho"; // o tipo dela pode ser alterado
            cor_favorita = 10;
            Console.WriteLine(cor_favorita);
            */

            /* ************************************************************* 
            * Bloco 4º - Constantes
            *           
            *
            const string SENHA = "TESTESTS@1#"; // valor constante, não pode ser alterado em hipótese alguma - sempre use letra caixa alta
            Console.WriteLine(SENHA);
            */

            /* ************************************************************* 
            * Bloco 5º - Entrada de dados
            *           
            */

            string nome;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nome);


            Console.ReadLine(); //para o console não fechar ao fim da execução 
        }
    }
}
