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
            int opcao = 10;
            int[] numeros = { };
            int a = 0;
            int b = 0;
            int resposta = 0;

            while (opcao != 0) {
                opcao = menu();
                numeros = doisNumeros();
                a = numeros[0];
                b = numeros[1];

                switch(opcao)
                {
                    case 1:
                        resposta = soma(a, b);
                        break;
                    case 2:
                        resposta = subtracao(a, b);
                        break;
                    case 3:
                        resposta = multiplicacao(a, b);
                        break;
                    case 4:
                        resposta = divisao(a, b);
                        break;

                }

                Console.WriteLine("Resposta = " + resposta);
            }
        }

        private static int menu()
        {
            Console.WriteLine("### CALCULADORA ###");
            Console.WriteLine("-------------------");
            Console.WriteLine("Escolha uma das operações:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            int opcaoMenu = Console.Read();
            return opcaoMenu;
        }

        private static int[] doisNumeros()
        {
            Console.Write("Primeiro número: ");
            int a = Console.Read();
            Console.Write("Segundo número: ");
            int b = Console.Read();

            int[] doisNumerosArr = {a, b};

            return doisNumerosArr;
        }

        private static int soma(int a, int b)
        {
            return a + b;
        }

        private static int subtracao(int a, int b)
        {
            return a - b;
        }

        private static int multiplicacao(int a, int b)
        {
            return a * b;
        }

        private static int divisao(int a, int b)
        {
            return a / b;
        }
    }
}
