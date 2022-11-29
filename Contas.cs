using System;

public class Conta 
{
    public string NumeroConta { get; set; }
    public Cliente Propietario { get; set; }
    public Agencia Agencia { get; set; }
    public double Saldo { get; set; }


}

public class ContaCorrente : Conta 
{
    public ContaCorrente(string numConta, Cliente cliente, Agencia agencia, double saldo)
    {
        this.NumeroConta = numConta;
        this.Propietario = cliente;
        this.Agencia = agencia;
        this.Saldo = saldo;
    }
}

public class ContaPoupanca : Conta 
{
    public ContaPoupanca(string numConta, Cliente cliente, Agencia agencia, double saldo)
    {
        this.NumeroConta = numConta;
        this.Propietario = cliente;
        this.Agencia = agencia;
        this.Saldo = saldo;
    }
}