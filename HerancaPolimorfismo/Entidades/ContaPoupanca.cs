namespace HerancaPolimorfismo.Entidades
{
    class ContaPoupanca : Conta
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
        //Uso da palavra base, vai executar o método da superclasse normalmente, mas com o base é possível inserir outras regras como segue
        public override void Saque(double quantia)
        {
            base.Saque(quantia); //<--Fará saque normalmente, mas, conforme abaixo, vai descontar taxa de 2.0
            Saldo -= 2.0;

        }
    }

}
