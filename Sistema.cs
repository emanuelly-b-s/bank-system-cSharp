public static class Sistema
{
    public static Cliente? Propientario { get; set; }
    public static void Deposito(float valor, Conta conta)
    {
        conta.Deposito(valor);
        Console.WriteLine($"Novo saldo: {conta.Saldo}");
    }
    public static void Saque(float valor, Conta conta) => conta.Saque(valor);
    public static void Extrato(Conta conta) => conta.Extrato();
}