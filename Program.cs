Agencia Agencia01 = new Agencia("2202");

Cliente Josezinho = new Cliente();

ContaCorrente conta3232 = new ContaCorrente("3232-2", Josezinho, Agencia01, 00.0f);

Josezinho.Nome = "Jose da Silva";
Josezinho.AddConta(conta3232);
Josezinho.AddCPF("101.101.101-02");

Agencia01.AddConta(conta3232);

Sistema.Extrato(conta3232);
Sistema.Deposito(1200.6f, conta3232);

Sistema.Saque(1000.12f, conta3232);


