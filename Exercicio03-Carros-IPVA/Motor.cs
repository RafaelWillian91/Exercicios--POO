public class Motor
{

    public string tipoCombustivel;
    public int cilindrada;
    public int potencia;

    public Motor cadastrarMotor()
    {
        Motor motor = new Motor();
        Console.WriteLine("Tipo de combustivel:");
        motor.setTipoCombustivel(Console.ReadLine());

        Console.WriteLine("Cilindradas :");
        motor.setCilindrada(int.Parse(Console.ReadLine()));

        Console.WriteLine("Potência :");
        motor.setPotencia(int.Parse(Console.ReadLine()));
        return motor;
    }
    public void setTipoCombustivel(string tipoCombustivel)
    {
        this.tipoCombustivel = tipoCombustivel;
    }
    public string getTipoCombustivel()
    {
        return this.tipoCombustivel;
    }

    public void setCilindrada(int cilindrada)
    {
        this.cilindrada = cilindrada;
    }
    public int getCilindrada()
    {
        return this.cilindrada;
    }
    
    public int getPotencia()
    {
        return this.potencia;
    }
    public void setPotencia(int potencia)
    {
        this.potencia = potencia;
    }
    public override string ToString()
    {
        return $"""
            Tipo combustível: {tipoCombustivel}
            Cilindrada: {cilindrada}
            Potencia: {potencia}
        """;
    }
}