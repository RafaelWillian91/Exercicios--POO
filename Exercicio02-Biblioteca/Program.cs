Console.WriteLine("************  Biblioteca  ***************");

// Ele foi criado para ser uma barreira de segurança rápida e limpa: você tenta criar
// o objeto; se os dados estiverem certos, o programa segue normalmente; se estiverem
// errados, o programa apenas ignora e continua rodando sem quebrar. Validacao na criacao do objeto
Livro livro1 = Livro.TryCreate("J.K. Rowling", "Harry Potter e a Pedra Filosofal", 264);
Livro livro2 = Livro.TryCreate("George Orwell", "1984", 416);
Livro livro3 = Livro.TryCreate("J.R.R. Tolkien", "O Hobbit",0);

Livro[] arrayLivros = new Livro[]{

    livro1 , livro2 , livro3

};

for (int i = 0; i < arrayLivros.Length; i++)
{
    Console.WriteLine(arrayLivros[i]);
}