using System.ComponentModel.Design;

namespace ClassificacaoDeTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Classificador de Triângulos");
                Console.WriteLine("----------------------------------------------");

                //receber a entrada (imput) de dados
                Console.WriteLine("Informe o valor do lado X: ");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o valor do lado Y: ");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o valor do lado Z: ");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

                //exibir os valores digitados
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Valores informados:");
                Console.WriteLine("Lado X: " + ladoX);
                Console.WriteLine("Lado Y: " + ladoY);
                Console.WriteLine("Lado Z: " + ladoZ);

                // verificar a validade do triãngulo
                bool medidasTrianguloValidas = 
                    ladoX + ladoY > ladoZ && 
                    ladoX + ladoZ > ladoY &&
                    ladoY + ladoZ > ladoX;

                if (medidasTrianguloValidas == true)
                {
                    Console.WriteLine("O triãngulo é válido!");

                    string tipoTriangulo = "Não classificado";

                    if (ladoX == ladoY && ladoY == ladoZ)
                        tipoTriangulo = "Equilátero";

                    else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                        tipoTriangulo = "Escaleno";

                    else
                        tipoTriangulo = "Isósceles";

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
    }
}
