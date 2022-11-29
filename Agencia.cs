using System.Collections.Generic;

public class Agencia
{
    public string NumAgencia { get; set; }
    public List<Conta> Contas = new List<Conta>();

    public Agencia(string numAgencia) => this.NumAgencia = numAgencia;

    public void AddConta(Conta conta) => Contas.Add(conta);
}