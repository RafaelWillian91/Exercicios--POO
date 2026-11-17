using System.Globalization;

public class ContaBancaria{

    public string titular;
    public double saldo = 0;
    public string getTitular()
    {
        return titular;
    }
    public double getSaldo()
    {
        return saldo;
    }
    public void setTitular(string titular)
    {
        this.titular = titular;
    }

    public void depositar(double valor)
    {
        saldo = saldo + valor;
    }

    public bool sacar(double valor)
    {
        if((saldo - valor) < 0)
        {
            Console.WriteLine("Não há saldo suficiente para operação");
            return false;
        }
        saldo = saldo - valor;
        return true;
    }

    public void transferir(ContaBancaria contaBancariaDestino, double valor)
    {
        if (sacar(valor))
        {
            contaBancariaDestino.depositar(valor);
        }
        
    }

    public double exibirSaldo()
    {
        return saldo;
    }



//A letra C vem do inglês Currency(Moeda). Quando colocada após os dois - pontos(:C),
//ela instrui o programa a transformar um número comum em um valor monetário, aplicando automaticamente:
//O símbolo da moeda configurado no sistema operacional ou no código(no Brasil, R$).
//Os separadores de milhar(pontos) e decimais(vírgula).
//Duas casas decimais para os centavos.
    public override string ToString()
    {
        return $"""
        ----------------------------------------
            Titular: {titular}
            Saldo:   {saldo:C}
        ----------------------------------------
        """;
            
    }
}

