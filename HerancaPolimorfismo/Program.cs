using System;
using HerancaPolimorfismo.Entidades;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(1001, "Pedro", 500.0);
            Conta conta2 = new ContaPoupanca(1002, "Vera Lúcia", 500.0, 0.0);

            conta1.Saque(10.0);
            conta2.Saque(100.0);

            Console.WriteLine(conta1.Saldo);
            Console.WriteLine(conta2.Saldo);
        }
    }
}
