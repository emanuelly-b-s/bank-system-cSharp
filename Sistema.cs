using System;

public static class Sistema
{
    public static Cliente Propietario { get; set; }
    public static Agencia Agencia { get; set; }
    public static void Deposito(float valor, Conta conta) => conta.Deposito(valor);
    public static void Saque(float valor, Conta conta) => conta.Saque(valor);
    public static void Extrato(Conta conta) => conta.Extrato(conta);
    
    public static void CriarConta()
    {
        while (true)
        {
            WriteLine("Digite o tipo de conta que deseja criar: ");
            Console.WriteLine
            int op = int.Parse(Console.ReadLine());
            
        }
    }
}