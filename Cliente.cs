// using MongoDB.Bson;
// using MongoDB.Bson.Serialization.Attributes;
public class Cliente

{
    // [BsonId()]
    private string CPF { get; set; }

    // [BsonElement("Nome")]
    // [BsonRequired()]
    public string Nome { get; set; }

    // [BsonElement("DataNascimento")]
    // [BsonRequired()]
    public string DataNascimento { get; set; }

    // [BsonElement("Conta")]
    // [BsonRequired()]
    public Conta Conta { get; protected set; }

    public void AddConta(Conta conta) => this.Conta = conta;
    public void AddCPF(string cpf) => this.CPF = cpf;
    public Cliente() {}
}


