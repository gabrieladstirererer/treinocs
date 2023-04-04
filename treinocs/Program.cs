using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyApp_01 // Note: actual namespace depends on the project name.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            double armazenar, armazenar1;
            int escolha;

            while (!sair)
            {
                Console.WriteLine("1 + Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 * Multiplicar");
                Console.WriteLine("4 / Dividir");
                escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Opcao soma");
                        armazenar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        armazenar1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        double resultado;
                        resultado = armazenar + armazenar1;
                        Console.WriteLine("Seu resultado é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("opcao subtrair");
                        double sub1, sub2, resulSub;
                        sub1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        sub2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        resulSub = sub1 - sub2;
                        Console.WriteLine("Seu resultado é: " + resulSub.ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case 3:
                        Console.WriteLine("Opcao multiplicacao");
                        double calc1, calc2, resultadoCalculo;
                        calc1 = double.Parse(Console.ReadLine());
                        calc2 = double.Parse(Console.ReadLine());
                        resultadoCalculo = calc1 + calc2;
                        Console.WriteLine("Seu resultado é: " + resultadoCalculo.ToString("F2"), CultureInfo.InvariantCulture);

                        break;

                    case 4:
                        Console.WriteLine("Opcao dividir");
                        float div1, div2, resultadoDiv;
                        div1 = float.Parse(Console.ReadLine());
                        div2 = float.Parse(Console.ReadLine());
                        resultadoDiv = div1 + div2;
                        Console.WriteLine("Seu resultado é : " + resultadoDiv.ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }

            }
        }
    }
}


