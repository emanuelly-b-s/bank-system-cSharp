public static class Sistema
{
    public static Cliente Propietario { get; set; }
    public static Agencia Agencia { get; set; }
    public static void Deposito(float valor, Conta conta) => Opcoes.Deposito(valor, conta);
    public static void Saque(float valor, Conta conta) => Opcoes.Saque(valor, conta);
    public static void Extrato(Conta conta) => Opcoes.Extrato(conta);
}