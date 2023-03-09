using System;

public class Conta 
{
    public string NumeroConta { get; set; }
    public Cliente Propietario { get; set; }
    public Agencia Agencia { get; set; }
    public double Saldo { get; set; }

    public virtual void Deposito(double valor) 
    {
        this.Saldo += valor;
        Console.WriteLine($"Novo Saldo: {this.Saldo:0.##}");
    }

    public virtual void Extrato() => Console.WriteLine(this.Saldo);

    public virtual void Saque(double valor)
    {
        if (valor <= this.Saldo)
        {
            this.Saldo -= valor;
            Console.WriteLine($"Novo Saldo: {this.Saldo:0.##}");
        }
        else
            Console.WriteLine("Saldo insuficiente");
    }

    public virtual void Pix(double valor, Conta destino, Conta conta)
    {
        if(valor < conta.Saldo)
        {
            conta.Saldo -= valor;
            destino.Saldo += valor;
        }
    } 

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
    public double TaxaRendimento { get; set; }
    public string TipoDeInvestimento { get; set; }

    public ContaPoupanca(string numConta, Cliente cliente, Agencia agencia, double saldo, double txRend, string tpInvestimeto)
    {
        this.NumeroConta = numConta;
        this.Propietario = cliente;
        this.Agencia = agencia;
        this.Saldo = saldo;
        this.TaxaRendimento = txRend;
        this.TipoDeInvestimento = tpInvestimeto;
    }
}