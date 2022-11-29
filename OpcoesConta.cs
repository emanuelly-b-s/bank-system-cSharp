using System;
using System.Collections.Generic;

public static class Opcoes
{
    public static Cliente Propietario { get; set; }
    public static Agencia Agencia { get; set; }

    public static Conta Conta { get; set; }
    public static void Deposito(double valor, Conta conta)
    {
        conta.Saldo += valor;
        Console.WriteLine($"Novo Saldo: {conta.Saldo:0.##}");
    } 
    public static void Extrato(Conta conta) => Console.WriteLine(conta.Saldo);
    
    public static void Saque(double valor, Conta conta)
    {
        if (valor <= conta.Saldo)
        {
            conta.Saldo -= valor;
            Console.WriteLine($"Novo Saldo: {conta.Saldo:0.##}");
        }
        else
            Console.WriteLine("Saldo insuficiente");
    } 


    public static void Pix(double valor, Conta destino, Conta conta)
    {
        if(valor < conta.Saldo)
        {
            conta.Saldo -= valor;
            destino.Saldo += valor;
        }
    }
}

