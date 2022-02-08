using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class CalculadoraCMD
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        public void Calcular() 
        {
            bool exibeMenu = false;
            
            while(!exibeMenu)
            {
                Console.WriteLine("Bem-vindo ao Calc, selecione uma das opções: ");
                Console.WriteLine(" 1-Soma\n 2-Subtracao\n 3-Divisao\n 4-Multiplicacao\n 5-Potencia\n 6-Raiz\n 7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case Menu.Sair:
                        exibeMenu = true;
                        break;
                    case Menu.Soma:                       
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pod();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                }                
                Console.Clear();
            }            
        }
        
        public void Soma()
        {
            Console.Clear();
            int a, b, resultado = 0;

            Console.WriteLine("Soma de dois números");

            Console.WriteLine("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            resultado = a + b;

            Console.WriteLine($"O resultado de {a} + {b} = {resultado}");

            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
        
        public void Sub()
        {
            Console.Clear();
            int a, b, resultado = 0;

            Console.WriteLine("Subtração de dois números");

            Console.WriteLine("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            resultado = a - b;

            Console.WriteLine($"O resultado de {a} - {b} = {resultado}");

            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
       
        public void Div()
        {
            Console.Clear();
            int a, b = 0;
            float resultado = 0f;

            Console.WriteLine("Divisão de dois números");

            Console.WriteLine("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            resultado = (float)a / (float)b;

            Console.WriteLine($"O resultado de {a} / {b} = {resultado}");

            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
        
        public void Mult()
        {
            Console.Clear();
            int a, b, resultado = 0;

            Console.WriteLine("Multiplicação de dois números");

            Console.WriteLine("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            resultado = a * b;

            Console.WriteLine($"O resultado de {a} * {b} = {resultado}");

            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }

        public void Pod()
        {
            Console.Clear();
            double baseNum, exp, resultado = 0;

            Console.WriteLine("Potência de um número");

            Console.WriteLine("Digite a base: ");
            baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            exp = int.Parse(Console.ReadLine());

            resultado = Math.Pow(baseNum, exp);

            Console.WriteLine($"O resultado de {baseNum} ^ {exp} = {resultado}");

            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }

        public void Raiz()
        {
            Console.Clear();
            double a, resultado = 0;

            Console.WriteLine("Raiz de um número");

            Console.WriteLine("Digite o numero: ");
            a = int.Parse(Console.ReadLine());

            resultado = Math.Sqrt(a);

            Console.WriteLine($"O resultado da raíz de {a} = {resultado}");

            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
    }
}
