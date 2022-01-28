﻿using System;
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
            *
            string nome;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nome);
            */

            /* ************************************************************* 
            * Bloco 6º - Operadores Aritméticos
            *           
            *
            int numero = 20 + 40 * 100 + ((10 + 10) * 10)/99 % 10; //cuidado com números decimais
            Console.WriteLine(numero);
            */

            /* ************************************************************* 
            * Bloco 7º - Condicionais
            *           
            *
            int a = 10;
            int b = 20;
            int c = 2;

            if(a > b)
            {
                Console.WriteLine("é verdade");
            }
            else if(a > c)
            {
                Console.WriteLine("Executou else if");
            }
            else
            {
                Console.WriteLine("Executou else");
            }
            */

            /* ************************************************************* 
            * Bloco 7.1º - Exercicios
            * 
            * Crie um Programa em C# que receba três números do usuário, informe na tela qual
            * é o MENOR deles ou exiba se eles são iguais.
            * 
            *  Crie um Programa em C# que receba três números do usuário, informe na tela qual
            * é o MAIOR deles ou exiba se eles são iguais.
            *
            BlocoSeteExercicio ex = new BlocoSeteExercicio();

            Console.WriteLine("Digite o número A: ");
            ex.numeroA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número B: ");
            ex.numeroB = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o número C: ");
            ex.numeroC = int.Parse(Console.ReadLine());
            ex.menorNumero();
            ex.maiorNumero();
            */

            /*
            Guilherme é chefe do setor de T.I de sua empresa e precisa que você ajude-o a
            criar um programa usando a linguagem C# que receba os chamados dos usuários
            classificando e exibindo na tela o seu nível de urgência, sendo de 0-3 "BAIXO", maior
            que 3 até 6 "MÉDIO", maior que 6 até 9 "ALTO", para os demais casos é considerado
            "GRAVE".
           *
            BlocoSeteExercicio ex = new BlocoSeteExercicio();

            Console.WriteLine("Por favor, digite o nível de urgência:");
            Console.WriteLine("sendo de 0 - 3 'BAIXO''\n, maior que 3 até 6 'MÉDIO'\n, maior que 6 até 9 'ALTO'\n, para os demais casos é considerado 'GRAVE'");
            ex.urgencia = int.Parse(Console.ReadLine());
            ex.chanadosTi();
            */

            /* ************************************************************* 
            * Bloco 8º - Operadores lógicos
            * 
            *          
            bool repeti = false;
            do
            {
                Console.WriteLine("Digite sua idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <= 11)
                {
                    Console.WriteLine("Você é uma criança.");
                }
                else if (idade >= 12 && idade <= 18)
                {
                    Console.WriteLine("Você é um adolescente");
                }
                else if (idade >= 19 && idade <= 60)
                {
                    Console.WriteLine("Você é um adulto");
                }
                else
                {
                    Console.WriteLine("Você é um idoso");
                }

                Console.WriteLine("Nova pergunta? 1-SIM 2-NÂO");
                repeti = int.Parse(Console.ReadLine()) == 1 ? true : false;
            } while (repeti != false);
            */

            /* ************************************************************* 
            * Bloco 9º - Funções
            * 
            *
            *
            primeiraFuncao();
            gerarPreco(10, 20);

            void primeiraFuncao()
            {
                Console.WriteLine("Utilizando a função");
            }

            void gerarPreco(int n1, int n2) //função com parâmetro
            {
                Console.WriteLine("A soma é: " + (n1 + n2));
            }
            */

            /* ************************************************************* 
            * Bloco 10º - Funções com retorno
            * 
            */

            Console.WriteLine("Qual seu salário: ");
            float salarioBase = float.Parse(Console.ReadLine());
            Console.WriteLine("Desconto do INSS: " + valorInss(salarioBase));



            float valorInss(float salario)
            {
                float taxa = 0;
                float valorFinal = 0;

                if (salario <= 1212) taxa = 7.5f;
                if (salario > 1212 && salario <= 2427) taxa = 9f;
                if (salario > 2427 && salario <= 3641) taxa = 12f;
                if (salario > 3641) taxa = 14f;

                valorFinal = (salario * taxa)/100;

                return valorFinal;
            }




            Console.ReadLine(); //para o console não fechar ao fim da execução 
        }
    }
}
