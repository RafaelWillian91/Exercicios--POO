public class Carro
{

    public string fabricante;
    public string modelo;
    public int anoFabricacao;
    public int anoModelo;
    public double valorVenda;
    public double valorIPVA;
    public Motor motor;

    public void cadastrarCarro()
    {
        Console.WriteLine("Entre com o fabricante: ");
        setFabricante(Console.ReadLine());

        Console.WriteLine("Entre com o modelo: ");
        setModelo(Console.ReadLine());

        Console.WriteLine("Entre com o ano de fabricação: ");
        setAnoFabricacao(int.Parse(Console.ReadLine()));

        Console.WriteLine("Entre com o ano do modelo: ");
        setAnoModelo(int.Parse(Console.ReadLine()));

        Console.WriteLine("Entre com o valor de venda: ");
        setValorVenda(double.Parse(Console.ReadLine()));

        Motor m1 = new Motor();
        motor = m1.cadastrarMotor();
    }


    public string getFabricante()
    {
        return this.fabricante;
    }

    public void setFabricante(string fabricante)
    {
        this.fabricante = fabricante;
    }

    public string getModelo()
    {
        return this.modelo;
    }

    public void setModelo(string modelo)
    {
        this.modelo = modelo;
    }

    public int getAnoFabricacao()
    {
        return this.anoFabricacao;
    }

    public void setAnoFabricacao(int anoFabricacao)
    {
        this.anoFabricacao = anoFabricacao;
    }

    public int getAnoModelo()
    {
        return this.anoModelo;
    }

    public void setAnoModelo(int anoModelo)
    {
        this.anoModelo = anoModelo;
    }

    public double getValorVenda()
    {
        return this.valorVenda;
    }

    public void setValorVenda(double valorVenda)
    {
        this.valorVenda = valorVenda;
    }

    public Motor getMotor()
    {
        return this.motor;
    }

    public void setMotor(Motor motor)
    {
        this.motor = motor;
    }

    public double calcularIPVA()
    {
        int idadeCarro = DateTime.Now.Year - anoFabricacao;

        if (idadeCarro > 20)
        {
           return valorIPVA = 0;
        }
        else
        {
            return valorIPVA = valorVenda *0.04;
        }
    }

    public override string ToString()
    {
        return $"""
        ----------------------------------------------
        Fabricante: {fabricante}
        Modelo: {modelo}
        Ano fabricação: {anoFabricacao}
        Ano modelo: {anoModelo}
        Valor venda: {valorVenda}
        Motor:
        {motor}
        ----------------------------------------------
        """;
    }
}