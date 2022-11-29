public class Cliente
{
    public string Nome { get; set; }
    private string CPF { get; set; }
    public Conta Conta { get; protected set; }

    public void AddConta(Conta conta) => this.Conta = conta;
    public void AddCPF(string cpf) => this.CPF = cpf;
    public Cliente() {}
}


