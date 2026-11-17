public class Livro
{

    private string autor;
    private string titulo;
    private int paginas;

    private Livro(string autor, string titulo, int paginas)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.paginas = paginas;
    }

    //***Metodo de Fabrica***
    //O TryCreate (conhecido como Try-Parse Pattern ou Try-Create Pattern) é uma
    //convenção oficial e muito popular no ecossistema C#/.NET. Ele serve para criar
    //objetos ou converter dados sem depender de exceções (throw) para controlar o fluxo
    //do programa. Usado no exemplo para prevenir numero de paginas menor que 0
    public static Livro TryCreate(string autor, string titulo, int paginas)
    {
        if (paginas > 0)
        {
            return new Livro(titulo, autor, paginas);
            
        }
        else
        {
            Console.WriteLine("Erro: O número de páginas deve ser positivo. Objeto não criado.");
            return null; // Nenhum objeto é instanciado
        }
    }

    public string getTitulo() { return titulo; }

    public string getAutor() { return autor; }

    public int getPaginas() { return paginas; }


    public override string ToString()
    {
        return $"""
            ----------------------------
            Autor: {autor}
            Livro: {titulo}
            Paginas: {paginas}
            ----------------------------
            """;
    }

}