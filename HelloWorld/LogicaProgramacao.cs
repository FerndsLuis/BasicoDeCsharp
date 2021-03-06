using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class LogicaProgramacao
    {
        public void Logica()
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
            *

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
            */

            /* ************************************************************* 
           * Bloco 10.1º - Funções com retorno
           * 1- Crie um programa em C# que utilize uma Função chamada “ PrecoFinal ” que
                ajuste em 25% a mais do valor inicial dos produtos:
                ● Chocolate: 30
                ● Refrigerante: 50
                ● Bolo: 45
                ● Sorvete: 60
                ● Pão: 15
           * 
           *
            precoFinal(10);
            void precoFinal(int preco)
            {
                Console.WriteLine("Preço inicial: "+ preco + " final: " + (preco + (preco * 0.25)));
            }

            *
             * 2- Paulo é um pizzaiolo que precisa descobrir a área de uma circunferência para
               conseguir fazer a pizza perfeita e ganhar o concurso nacional, Crie um programa C#
               fazendo o uso das funções, que calcule a área de um círculo, recebendo o raio valor
               30 desejado por Paulo.
             *

            calcularRaio();

            void calcularRaio()
            {
                float raioDoCirculo = 30f;
                Console.WriteLine(Math.PI * (raioDoCirculo * raioDoCirculo));
            }

           *
             * 3- Alguns engenheiros precisam construir uma praça em um terreno que tem
                formato Triangular, porém precisam saber qual a área exata desse terreno, Crie um
                programa em C# com uma função que calcule a área de um triângulo, recebendo
                uma base de 250 e uma altura de 350 como parâmetros.
            *


            Console.WriteLine("Area do triangulo é: " + areaDoTriangulo(250, 350));           

            float areaDoTriangulo(int baseTriangulo, int alturaTriangulo)
            {
                return (baseTriangulo * alturaTriangulo) / 2;
            }

            */

            /* ************************************************************* 
            * Bloco 11º - Arrays
            *

            //não pode mudar o tamanho do array
            string[] produtos = new string[5] {"Fifa","GTA IV","Minicrafit","Need For speed","Portal"}; 
            Console.WriteLine(produtos[4]);

            int[] valores = { 10, 20, 40, 100 }; //maneira simples de declarar um array
            */


            /* ************************************************************* 
            * Bloco 12º - Switch
            * Só realiza operações de igualdade
            * Muito útil para menus
            *

            string cor = "azul";

            switch (cor) 
            {
                case "vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case "amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo");
                    break;
                case "azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
                default:
                    Console.WriteLine("Cor não encontrada");
                    break;
            }
            */

            /* ************************************************************* 
            * Bloco 13º - Enum
            * 
            * Cria um novo tipo de dado e define os valores
            * Valores limitado de dados
            *

            Cor corFavorita = Cor.AMARELO;
            Cor corDoZe = Cor.AZUL;

            Console.WriteLine(corFavorita);
            Console.WriteLine((int)corDoZe);
            Console.WriteLine((Cor)2);
            */


            /* ************************************************************* 
            * Bloco 14º - Enum e Switch para menu
            * 
            * 
            *

            Console.WriteLine("Selecione uma da opções:");
            Console.WriteLine(" 1-Criar\n 2-Deletar\n 3-Editar\n 4-Listar\n 5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            //Console.WriteLine(opcaoSelecionada);

            switch(opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Opção criar");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Opção Deletar");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Opção Editar");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Opção Listar");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Opção Atualizar");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            */



            /* ************************************************************* 
            * Bloco 15º - While
            * 
            * Enquanto for verdade, então faça.
            *

            int contador = 0;

            while(contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            */


            /* ************************************************************* 
           * Bloco 16º - Do While
           * 
           * Vai executar ao menos uma vez
           *
            int contador = 4;

            do
            {
                Console.WriteLine("Contador");
                contador++;
            }
            while (contador < 5);
            */


            /* ************************************************************* 
            * Bloco 17º - For Each
            * 
            * serve para percorrer array*
            * foreach = para cada
            *

            string[] cursos = { "C#", "POO", "SQL", "GIT", "GITHUB" };

            foreach(string curso in cursos)
            {
                Console.WriteLine(curso);
            }
            */

            /* ************************************************************* 
            * Bloco 18º - For
            *             
            *
            *
            string[] cursos = { "C#", "POO", "SQL", "GIT", "GITHUB" };

            for(int contador = 0; contador < cursos.Length; contador++)//crescente
            {
                Console.WriteLine(cursos[contador]);
            }

            Console.WriteLine("--");

            for (int contador = cursos.Length; contador > 0; contador--)//decrescente
            {
                Console.WriteLine(cursos[contador-1]);
            }
            */


            /* ************************************************************* 
            * Bloco 19º - Escopo
            *             
            *

            void exibiNome()
            {
                string nome = "Luís";
                Console.WriteLine(nome); //escopo local
            }

            Console.WriteLine(nome); //teremos um erro pois a variável nome está no escopo local exibirNome.
            */


                      
        }

        public void ExerciciosRepeticao()
        {
            /* ************************************************************* 
           * Bloco 19.1º - Exercícios
           *             
           */




            /*
             * 1. A diretora de uma escola precisa de um programa C# que exiba uma mensagem de
                  boas vindas para os 10 alunos novos, utilizando a estrutura Foreach exiba a mesma
                  mensagem para todos os alunos novos
            *

            string[] alunos = { "Marcos", "Luis", "Julio", "Vinicius", "Felipe", "Ana", "Carla", "Patricia", "Joice", "Rafaela" };

            foreach(string aluno in alunos)
            {
                Console.WriteLine("Seja bem-vindo (a) " + aluno);
            }
            */




            /*
             * 2. Crie um programa C# usando as estruturas de repetição que contabilize a
                  velocidade de um carro de fórmula 1, sem ultrapassar o limite de 200 Km/h permitido
                  na pista, exiba uma mensagem no final informando que chegou no limite
            *

            for (int velodiade = 0; velodiade <= 200; velodiade++)
            {
                if (velodiade == 200) { Console.WriteLine("Chegou no limite de 200km/h"); break; }
                Console.WriteLine("Sua velocidade é: " + velodiade + "km/h");                
            }
            */



            /*
             * 3. Crie um programa C# que exiba para os clientes de um mercado que está aberto
                  sob a condição do seu horário de funcionamento das 7h às 17h após esse horário
                  exibir uma mensagem de que se encontra fechado e indicando o horário de
                  funcionamento deste estabelecimento
            *

            int hora = 0;

            while(hora <= 23)
            {
                if(hora >= 7 && hora <= 17)
                {
                    Console.WriteLine("Mercado aberto: " + hora + ":00");
                }
                else
                {
                    Console.WriteLine("O mercado está fechado! " + hora + ":00");
                    Console.WriteLine("Horário de funcionamento de 7h até as 17h");
                }

                hora++;
            }
            */




            /*
            *4. Crie um programa C# que exiba um cardápio de uma pizzaria contando 10 sabores
                de pizza, exiba na tela repetindo a frase : “ Temos o sabor: ” “Aproveite a refeição”
                nos 10 sabores.
            *

            string[] cardpaio = { "1) Calabresa", "2) Portuguesa.", "3) Marguerita.", "4) Frango com catupiry.", "5) Muçarela.", "6) Napolitana. ", "7) Brigadeiro.", "8) Romeu e Julieta.", "9) Pão de alho", "10) Carne seca" };

            foreach(string item in cardpaio)
            {
                Console.WriteLine("Temos o sabor: "+ item +", Aproveite a refeição");
            }
            */





            /*
            *5. Utilizando as estruturas de repetição, crie um programa C# que Realize uma
                Contagem regressiva de 1000 a 1 para que um foguete seja lançado ao espaço.
            *
            *
            for(int numero = 1000; numero > 0; numero--)
            {
                Console.WriteLine(numero);
            }
            */
        }
    }
}
