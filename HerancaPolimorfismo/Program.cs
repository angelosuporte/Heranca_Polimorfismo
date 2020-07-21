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
            conta2.Saque(10.0);
            //Como não há sobreposição, ou seja, uso das palavras virtual e override será aplicado no saque o mesmo desconto  de 5.0
            //tanto na conta, bem como na poupança
            Console.WriteLine(conta1.Saldo);
            Console.WriteLine(conta2.Saldo);
        }
    }
}
