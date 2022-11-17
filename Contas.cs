public class Conta 
{
    public string? NumeroConta { get; set; }
    public Cliente? Propietario { get; set; }
    public Agencia? Agencia { get; set; }
    public double Saldo { get; set; }

    

    public void Deposito(double valor)
    {
        this.Saldo += valor;
    } 
    public void Extrato()
    {
        Console.WriteLine(Saldo);
    } 
    public void Saque(double valor)
    {
        if (valor <= Saldo)
            this.Saldo -= valor;
        else
            Console.WriteLine("Saldo insuficiente");
    } 


    public void Pix(double valor, Conta destino)
    {
        if(valor < Saldo)
        {
            this.Saldo -= valor;
            destino.Deposito(valor);
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
    public ContaPoupanca(string numConta, Cliente cliente, Agencia agencia, double saldo)
    {
        this.NumeroConta = numConta;
        this.Propietario = cliente;
        this.Agencia = agencia;
        this.Saldo = saldo;
    }
}