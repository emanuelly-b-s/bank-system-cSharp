using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class Cliente

{
    [BsonId]
    private string CPF { get; set; }

    [BsonElement("Nome")]
    public string Nome { get; set; }

    [BsonElement("DataNascimento")]
    public string DataNascimento { get; set; }

    [BsonElement("Conta")]
    public Conta Conta { get; protected set; }

    public void AddConta(Conta conta) => this.Conta = conta;
    public void AddCPF(string cpf) => this.CPF = cpf;
    public Cliente() {}
}


