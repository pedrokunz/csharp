using System;

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
    }
}
