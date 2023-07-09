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
            double respostaDiv = 0.0;
            bool escolhaDiv = false;

            opcao = menu();
            while (opcao != 0) 
            {
                a = lerNumero("Digite o primeiro número: ");
                b = lerNumero("Digite o segundo número: ");
                switch(opcao)
                {
                    case 1:
                        escolhaDiv = false;
                        resposta = soma(a, b);
                        break;
                    case 2:
                        escolhaDiv = false;
                        resposta = subtracao(a, b);
                        break;
                    case 3:
                        escolhaDiv = false;
                        resposta = multiplicacao(a, b);
                        break;
                    case 4:
                        escolhaDiv = true;
                        respostaDiv = (double)divisao(a, b);
                        break;
                }
                if (escolhaDiv)
                {
                    Console.WriteLine("Resposta = " + respostaDiv);
                } else
                {
                    Console.WriteLine("Resposta = " + resposta);
                }
                opcao = menu();
            }
        }

        private static int menu()
        {
            Console.WriteLine("");
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

        private static double divisao(int a, int b)
        {
            double aDouble = Convert.ToDouble(a);
            double bDouble = Convert.ToDouble(b);

            double resposta = 0.0;
            try
            {
                if (bDouble != 0.0)
                {
                    resposta = aDouble / bDouble;
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
