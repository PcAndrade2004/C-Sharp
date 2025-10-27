Console.WriteLine("## Validando Conhecimento ##\n");

    ContaBancaria conta = new ContaBancaria("12345-6", "João Silva", 1000M);
    conta.Depositar(200);
    conta.Sacar(50);
    conta.ExibirSaldo();
    
    Console.WriteLine("----------------------------------");

    ContaBancaria conta2 = new ContaBancaria("65432-1", "Maria Souza", 1000M);
    conta2.Depositar(300);
    conta2.Sacar(100);
    conta2.ExibirSaldo();

Console.ReadKey();


public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public string Titular { get; set; }
    public decimal Saldo { get; private set; } 

    public ContaBancaria() { }
    public ContaBancaria(string numeroConta, string titular)
    {
        this.NumeroConta = numeroConta;
        this.Titular = titular;
        Saldo = 0;
    }

    public ContaBancaria(string numero, string titular, decimal saldoInicial)
    {
        NumeroConta = numero;
        Titular = titular;
        Saldo = saldoInicial < 50 ? 50 : saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void Sacar (decimal valor)
    {
        if (valor < Saldo)
        {
            Saldo -= valor;
        }else
        {
           Console.WriteLine("Saldo insuficiente para saque.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Conta: {NumeroConta}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo atual: {Saldo:C}");
    }   
}