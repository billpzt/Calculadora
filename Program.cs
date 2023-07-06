using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 10;
            int a = 0;
            int b = 0;
            int resposta = 0;

            while (opcao != 0) {
                opcao = menu();

                Console.Write("Digite o primeiro número: ");
                a = lerNumero();
                Console.Write("Digite o segundo número: ");
                b = lerNumero();

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
            if (opcaoMenu < 0 || opcaoMenu > 4)
            {
                Console.WriteLine("Opção inválida!");
                return menu();
            }
            return opcaoMenu;
        }

        private static int lerNumero()
        {
            try
            {
                int numero = Console.Read();
                return numero;
            }
            catch (Exception e)
            {
                Console.WriteLine("Não é um número, tente novamente");
                return lerNumero();
            }

            //if (int.TryParse(numeroEntrada, out numero))
            //{
            //    return numero;
            //} else
            //{
            //    Console.Write("Não é um número, tente novamente");
            //    return lerNumero();
            //}

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
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Erro, divisão por zero!");
            }
            return a / b;
        }
    }
}
