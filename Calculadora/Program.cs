using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora
{
    class Program
    {

        static void Main(string[] args)
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha um Menu: ");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Resto");
                Console.WriteLine("6 - Potenciação");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 0) // Sair
                {
                    break;
                }
                else if (op == 1) // Somar
                {
                    Somar();
                }
                else if (op == 2) // Subtrair
                {
                    Subtrair();
                }
                else if (op == 3) // Multiplicar
                {
                    Multiplicar();
                }
                else if (op == 4) // Dividir
                {
                    Dividir();
                }
                else if (op == 5) // Resto
                {
                    Resto();
                }
                else if (op == 6) // Potenciação
                {
                    Potencia();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Invalida");
                    Console.ReadKey();
                }
            }
        }

        private static void Somar()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(n1 + "+" + n2 + "=" + (n1 + n2));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Precione qualquer tecla para retornar ao Menu Principal");
            Console.ReadKey();
        }

        private static void Subtrair()
        {
            Console.Clear();
            Console.WriteLine("Subtrair");

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(n1 + "-" + n2 + "=" + (n1 - n2));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Precione qualquer tecla para retornar ao Menu Principal");
            Console.ReadKey();
        }

        private static void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(n1 + "/" + n2 + "=" + (n1 / n2));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Precione qualquer tecla para retornar ao Menu Principal");

            Console.ReadKey();
        }

        private static void Multiplicar()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(n1 + "*" + n2 + "=" + (n1 * n2));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Precione qualquer tecla para retornar ao Menu Principal");

            Console.ReadKey();
        }

        private static void Resto()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(n1 + "/" + n2 + "=" + (n1 / n2));
            Console.WriteLine("O resto desta divisão é: " + (n1 % n2));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Precione qualquer tecla para retornar ao Menu Principal");

            Console.ReadKey();
        }

        private static void Potencia()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a potência: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O resultado é: " + Math.Pow(n1,n2)) ;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Precione qualquer tecla para retornar ao Menu Principal");

            Console.ReadKey();
        }

    }
}