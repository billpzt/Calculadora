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

            opcao = menu();
            while (opcao != 0) 
            {
                a = lerNumero("Digite o primeiro número: ");
                b = lerNumero("Digite o segundo número: ");
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
                        resposta = (int)divisao(a, b);
                        break;
                }
                Console.WriteLine("Resposta = " + resposta);
                opcao = menu();
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
            
            bool opcaoValida = false;
            int opcaoMenu = -1;

            while (!opcaoValida)
            {
                try
                {
                    opcaoMenu = int.Parse(Console.ReadLine());
                    if (opcaoMenu >= 0 && opcaoMenu <= 4)
                    {
                        opcaoValida = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
            return opcaoMenu;
        }

        private static int lerNumero(string mensagem)
        {
            int numero = 0;
            bool numeroValido = false;

            while (!numeroValido)
            {
                try
                {
                    Console.Write(mensagem);
                    numero = int.Parse(Console.ReadLine());
                    numeroValido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Não é um número, tente novamente");
                }
            }
            return numero;
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

        private static double divisao(double a, double b)
        {
            double resposta = 0.0;
            try
            {
                if (b != 0)
                {
                    resposta = a / b;
                }
            }
            catch
            {
                Console.WriteLine("Erro, divisão por zero!");
            }
            return resposta;
        }
    }
}
