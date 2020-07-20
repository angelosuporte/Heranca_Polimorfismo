namespace HerancaPolimorfismo.Entidades
{
    class ContaEmpresarial : Conta // --> : <-- Herança das propriedades e métodos da clase Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial()
        {
        }

        public ContaEmpresarial(int numero, string titular, double saldo, double limiteEmprestimo) 
            : base (numero, titular, saldo) //Reutilização de parâmetros da superclasse
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteEmprestimo){
                Saldo += quantia;
            }
        }


    }
}
