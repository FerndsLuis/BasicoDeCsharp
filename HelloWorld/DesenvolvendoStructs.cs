using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class DesenvolvendoStructs
    {
        struct Produto 
        {
            //atributos - tipos - da struct
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            //Construtor da struct
            public Produto(string nome, float preco, float peso, string marca) 
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }

            //métodos
            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Preço: R${preco}");
                Console.WriteLine($"Peso: {peso}kg");
                Console.WriteLine($"Marca: {marca}");
                Console.WriteLine("-------------------");

            }

            public float AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc/100f;
                return this.preco - desconto;
            }
        }

        public void TrabalhandoComStruct()
        {
            Produto bola = new Produto("Bola",20f,0.9f,"Nike");
            Produto carro = new Produto("Uno",19000f,1200f,"Fiat");
            Console.WriteLine($"{bola.nome} e {carro.nome}");

            //Método 
            bola.ExibirInfo();

            carro.ExibirInfo();
            float valorFinal = carro.AdicionarCupom(25f);
            Console.WriteLine(valorFinal);

        }
    }
}
