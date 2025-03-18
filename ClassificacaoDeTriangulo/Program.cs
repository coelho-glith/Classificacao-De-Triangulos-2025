using System;
using System.ComponentModel.Design;

namespace ClassificacaoDeTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                ExibirCabecalho();

                int ladoX = LerLado("X");
                int ladoY = LerLado("Y");
                int ladoZ = LerLado("Z");

                ExibirValoresInformados(ladoX, ladoY, ladoZ);

                if (MedidasFormaTrianguloValido(ladoX, ladoY, ladoZ))
                {

                    string tipoTriangulo = ClassificarTriangulo(ladoX, ladoY, ladoZ);


                    Console.WriteLine($"O triãngulo é {tipoTriangulo} ");
                }
                else
                    Console.WriteLine("Os valores informados não formam um triãngulo válido");


                Console.WriteLine("----------------------------------------------");
                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static void ExibirCabecalho()
        {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Classificador de Triângulos");
                Console.WriteLine("----------------------------------------------");

        }
        
        static int LerLado(string nomeLado)
        {
            int valor;

            while (true)
            {
                Console.Write($"Informe o valor do lado {nomeLado} ");

                bool conseguiuConverter = int.TryParse(Console.ReadLine(), out valor);

                if (conseguiuConverter)
                    break;
            }

            return valor;
        }

        static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Valores informados:");
            Console.WriteLine("Lado X: " + ladoX);
            Console.WriteLine("Lado Y: " + ladoY);
            Console.WriteLine("Lado Z: " + ladoZ);
            Console.WriteLine("----------------------------------------------");
        }

        static bool MedidasFormaTrianguloValido(int ladoX, int ladoY, int ladoZ)
        {
            bool medidasTrianguloValidas =
                ladoX + ladoY > ladoZ &&
                ladoX + ladoZ > ladoY &&
                ladoY + ladoZ > ladoX;

            return medidasTrianguloValidas;
        }

        static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
        {
            Console.WriteLine("O triãngulo é válido!");

            string tipoTriangulo = "Não classificado";

            if (ladoX == ladoY && ladoY == ladoZ)
                tipoTriangulo = "Equilátero";

            else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                tipoTriangulo = "Escaleno";

            else
                tipoTriangulo = "Isósceles";

            return tipoTriangulo;
        }
    }
}
