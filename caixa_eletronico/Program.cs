using System;
using System.Globalization;
namespace caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;

            Console.Write("Entre com o número da conta : ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta : ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char deposito = char.Parse(Console.ReadLine());
            if (deposito == 's' || deposito == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial : ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            Conta conta = new Conta(numero, nome, valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta : ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito : ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.deposito(valor);
            Console.WriteLine("Dados Atualizados da conta : ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque : ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.debito(valor);
            Console.WriteLine("Dados Atualizados da conta : ");
            Console.WriteLine(conta);







        }
    }
}
