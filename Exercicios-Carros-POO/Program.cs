Console.WriteLine("********* Conta Bancária ************");


ContaBancaria c1 = new ContaBancaria();
c1.setTitular("Rafael Willian");
Console.WriteLine(c1.getTitular());
Console.WriteLine(c1.getSaldo());
c1.depositar(500);
Console.WriteLine(c1.getSaldo());
c1.sacar(200);

ContaBancaria c2 = new ContaBancaria();
c2.setTitular("Josiane Visicatto");
Console.WriteLine(c2.getTitular());
Console.WriteLine(c2.getSaldo());
c2.depositar(1500);
c2.sacar(400);

c2.transferir(c1, 700);

Console.WriteLine(c1.ToString());
Console.WriteLine(c2.ToString());