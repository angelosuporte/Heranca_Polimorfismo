namespace HerancaPolimorfismo.Entidades
{    //uso de sealed antes de class impedirá uma especialização à partir desta classe
    sealed class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base (numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void SaldoAtualizado()
        {
            Saldo += Saldo * TaxaJuros;
        }
        //No caso de se der declarado diretamente no médodo, o uso de sealed impedirá que o médodo seja sobrescrito em outra classe
        public sealed override void Saque(double quantia)
        {
            base.Saque(quantia); 
            Saldo -= 2.0;

        }
    }

}
