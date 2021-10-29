using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("Nenhum parâmetro informado.");
                return;
            }

            string funcao = args[0];

            switch (funcao)
            {
                case "soma":
                    soma(args);
                    break;
                case "subtracao":
                    subtrai(args);
                    break;
                case "multiplica":
                    multiplica(args);
                    break;
                case "parOuImpar":
                    parOuImpar(args);
                    break;
                case "fritePastel":
                    fritePastel(args);
                    break;
                default:
                    Console.WriteLine("Função informada não existe.");
                    break;
            }
        }

        static void soma(string[] args)
        {
            int resultado = 0;
            for (short i = 1; i < args.Length; i++)
            {
                resultado += Convert.ToInt32(args[i]);
            }

            Console.WriteLine("O resultado da soma é: {0}", resultado);
        }

        static void subtrai(string[] args)
        {
            int resultado = 0;
            for (short i = 1; i < args.Length; i++)
            {
                resultado -= Convert.ToInt32(args[i]);
            }

            Console.WriteLine("O resultado da subtração é: {0}", resultado);
        }
        
        static void multiplica(string[] args)
        {
            int resultado = args.Length == 0 ? 0 : 1;
            for (short i = 1; i < args.Length; i++)
            {
                resultado *= Convert.ToInt32(args[i]);
            }

            Console.WriteLine("O resultado da multiplicação é: {0}", resultado);
        }

        static void parOuImpar(string[] args) {
            var valor = Convert.ToDouble(args[1]);
            string resultado;
            var resultadoDaDivisaoPorDois = valor % 2;
            if (resultadoDaDivisaoPorDois == 0) {
                resultado = "par";
            } else {
                resultado = "ímpar";
            }

            Console.WriteLine("O resultado é: {0}", resultado);
        }
    
        static void fritePastel(string[] args) {
            string sabor = args[1];
            string tamanho = args[2];
            Pastel pastel = new Pastel(sabor, tamanho);

            recebaPedido();
            montePastel(pastel);
            preparePastel(pastel);
            entreguePastel(pastel);
        }

        static void recebaPedido() {
            Console.WriteLine("Pedido recebido");
            Thread.Sleep(500);
        }

        static void montePastel(Pastel pastel) {
            Console.WriteLine("Montando um pastel {0} de {1}", pastel.Tamanho, pastel.Sabor);
            Thread.Sleep(1000);
        }

        static void preparePastel(Pastel pastel) {
            Console.WriteLine("Fritando o pastel de {0}", pastel.Sabor);
            Thread.Sleep(1000);
        }

        static void entreguePastel(Pastel pastel) {
            Console.WriteLine("Entregando o pastel de {0}", pastel.Sabor);
            Thread.Sleep(1000);
        }
    }

    enum SaborEnum {
        Carne,
        Frango
    }

    enum TamanhoEnum {
        P, M, G
    }

    class Pastel {
        public Pastel(string sabor, string tamanho)
        {
            this.Sabor = sabor;
            this.Tamanho = tamanho;
        }

        public string Sabor {get;set;}
        public string Tamanho {get;set;}
    }
}