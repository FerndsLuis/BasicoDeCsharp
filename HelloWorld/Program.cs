using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        enum Cor { AZUL, VERDE, AMARELO }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            //LogicaProgramacao l = new LogicaProgramacao();
            //l.Logica();
            //l.ExerciciosRepeticao();


            //CalculadoraCMD ca = new CalculadoraCMD();
            //ca.Calcular();

            //DesenvolvendoStructs d = new DesenvolvendoStructs();
            //d.TrabalhandoComStruct();

            Listas l = new Listas();
            l.ListasLinq();


            Console.ReadLine(); //para o console não fechar ao fim da execução 
        }
    }
}
