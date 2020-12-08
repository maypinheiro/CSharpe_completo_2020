using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("");
            Console.Write("Digite o número da conta: ");
             int numero= int.Parse(Console.ReadLine());
            Console.Write("Nome do Titular: ");
            string titular= (Console.ReadLine().ToUpper());
            Console.WriteLine("Haverar deposito inicial s/n");
            char res =char.Parse(Console.ReadLine().ToUpper());

            if (res=='S'){
                Console.Write("Digite o valor do deposito inicial: ");
                double depositoInicial= double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero,titular,depositoInicial);
            }
            else{
                conta= new ContaBancaria(numero, titular);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Dite o valor do DEPOSITO: ");
            double quantia= double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine($"Dados da conta Atualizado | {conta}");

            Console.WriteLine("");
            Console.Write("Dite o valor do SAQUE: ");
             quantia= double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine($"Dados da conta Atualizado | {conta}");


            

            

           
           

            

        }
    }
}
