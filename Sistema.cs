using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System;

public static class Sistema
{

    public static Cliente Propietario { get; set; }
    public static Agencia Agencia { get; set; }
    public static void Deposito(float valor, Conta conta) => conta.Deposito(valor);
    public static void Saque(float valor, Conta conta) => conta.Saque(valor);
    public static void Extrato(Conta conta) => conta.Extrato();
    
    public static void CriarConta()
    {
        while (true)
        {
            WriteLine("Digite o tipo de conta que deseja criar: ");
            WriteLine("(1) - Conta Corrente\n(2)-Conta Poupança");
            int op = int.Parse(ReadLine());

            switch (op)
            {
                case 1:
                    WriteLine("Digite seu nome: ");
                    string nomeCliente = ReadLine();
                    Cliente cliente = new Cliente();
                    Random randNmConta = new Random();
                    string conta = Convert.ToString(randNmConta.Next(1000, 5000));
                    Agencia01 agCliente = new Agencia01();
                    ContaCorrente contaCliente = new ContaCorrente(conta,
                                                                   cliente,
                                                                   agCliente,
                                                                   00.0f);
                    cliente.Nome = nomeCliente;
                    cliente.AddConta(contaCliente);
                    WriteLine("Digite seu CPF: ");
                    string CPF = ReadLine();
                    cliente.AddCPF(CPF);
                    agCliente.AddConta(contaCliente);
                    bool rodar = true;
                    while (rodar)
                    {
                        WriteLine("Opções: ");
                        WriteLine("(1) Deposito: ");
                        WriteLine("(2) Saque: ");
                        WriteLine("(3) Extrato: ");
                        WriteLine("(4) Pix: ");
                        int opEmConta = int.Parse(ReadLine());
                        switch (opEmConta)
                        {
                            case 1:
                                WriteLine("Valor do deposito: ");
                                double valorD = double.Parse(ReadLine());
                                contaCliente.Deposito(valorD);
                                Console.ReadKey(true);
                                break;
                            case 2:
                                WriteLine("Valor do saque: ");
                                double valorS = double.Parse(ReadLine());
                                contaCliente.Saque(valorS);
                                Console.ReadKey(true);
                                break;
                            case 3:
                                contaCliente.Extrato();
                                Console.ReadKey(true);
                                break;
                            case 4:

                                break;
                        }
                    }
                    
                break;
            }
                
        }
    }
}