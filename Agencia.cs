using System.Collections.Generic;

public class Agencia
{
    public string NumAgencia { get; set; }
    public List<Conta> Contas = new List<Conta>();
    public void AddConta(Conta conta) => Contas.Add(conta);
}

public class Agencia01 : Agencia
{
    public Agencia01()
    {
        this.NumAgencia = "0220";
    }
    
}