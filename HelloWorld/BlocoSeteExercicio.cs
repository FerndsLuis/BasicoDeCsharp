using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class BlocoSeteExercicio
    {
        public int numeroA = 0;
        public int numeroB = 0;
        public int numeroC = 0;
        public int urgencia = 0;

        public void menorNumero()
        {
            if (numeroA == numeroB || numeroA == numeroC || numeroC == numeroB)
            {
                Console.WriteLine("Os números são iguais");
            }
            else if (numeroA < numeroB)
            {
                Console.WriteLine("O menor número é A:" + numeroA);
            }
            else if(numeroB < numeroC)
            {
                Console.WriteLine("O menor número é B:" + numeroB);
            }
            else
            {
                Console.WriteLine("O menor número é C:" + numeroC);
            }
        }

        public void maiorNumero()
        {
            if (numeroA == numeroB || numeroA == numeroC || numeroC == numeroB)
            {
                Console.WriteLine("Os números são iguais");
            }
            else if (numeroA > numeroB)
            {
                Console.WriteLine("O maior número é A:" + numeroA);
            }
            else if (numeroB > numeroC)
            {
                Console.WriteLine("O maior número é B:" + numeroB);
            }
            else
            {
                Console.WriteLine("O maior número é C:" + numeroC);
            }
        }

        public void chanadosTi()
        {
            if(urgencia >= 0 && urgencia <= 3)
            {
                Console.WriteLine("Chamdo de baixa urgência");
            }
            else if(urgencia >= 4 && urgencia <= 6)
            {
                Console.WriteLine("Chamdo de media urgência");
            }
            else if (urgencia >= 7 && urgencia <= 9)
            {
                Console.WriteLine("Chamdo de alta urgência");
            }
            else
            {
                Console.WriteLine("Chamdo de grave urgência");
            }


        }
    }
}
