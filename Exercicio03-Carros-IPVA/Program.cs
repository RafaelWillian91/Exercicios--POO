Console.WriteLine("********* Tabela de Carros **********");


Carro c1 = new Carro();
c1.cadastrarCarro();
Motor m1 = new Motor();

//m1.setCilindrada(1300);
//m1.setPotencia(100);
//m1.setTipoCombustivel("Etanol");



//Carro c2 = new Carro();
//c2.cadastrarCarro();

//Carro c3 = new Carro();
//c3.cadastrarCarro();

Carro[] carros = new Carro[]
{
    c1
};

for (int i = 0; i < carros.Length; i++)
{
    Console.WriteLine(carros[i]);
    Console.WriteLine("Valor IPVA: " + carros[i].calcularIPVA());
}