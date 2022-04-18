using Conta_Bancaria;
using System;
using System.Globalization;

namespace Usuario
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria Conta;

            Console.Write("NUMERO DA CONTA: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("NOME DO TITULAR DA CONTA: ");
            string titular = Console.ReadLine();
            Console.Write("HAVERA DEPOSITO INICIAL? ");
            Console.WriteLine(" SIM OU NÃO ? ");
            string resp1 = (Console.ReadLine());

            if(resp1 == "Sim" || resp1 == "SIM" || resp1 == "sim")
            {
                Console.Write("VALOR DO DEPOSITO INICIAL: R$");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                Conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("DADOS DA CONTA: ");
            Console.WriteLine(Conta);

            Console.WriteLine();

            Console.WriteLine("QUER FAZER ALGUM DEPOSITO OU SAQUE?");
            Console.WriteLine("CASO NÃO QUEIRA, DIGITE SAIR");
            Console.WriteLine();
            Console.WriteLine("DEPOSITO / SAQUE OU SAIR?");
            string resp2 = (Console.ReadLine());

            Console.WriteLine();

            if( resp2 == "Deposito" || resp2 == "DEPOSITO" || resp2 == "deposito")
            {
                Console.Write("VALOR DO DEPOSITO: R$");
                double Quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta.Deposito(Quantia);
                Console.WriteLine();
                Console.WriteLine("DADOS DA CONTA: ");
                Console.WriteLine(Conta);
            }
            else if(resp2 == "Saque" || resp2 == "SAQUE" || resp2 == "saque")
            {
                Console.WriteLine("==== LEMBRANDO QUE SAQUE TEM UM DESCONTO DE 5% ====");
                Console.Write("VALOR DO SAQUE: R$");
                double Quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta.Saque(Quantia);
                Console.WriteLine();
                Console.WriteLine("DADOS DA CONTA: ");
                Console.WriteLine(Conta);
                Console.WriteLine();
            }
            else if( resp2 == "Sair" || resp2 == "SAIR" || resp2 == "sair")
            {
                Console.WriteLine("OBRIGADO");
            }

        }
    }
}