namespace HerancaPolimorfismo.Entidades
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
    
}
