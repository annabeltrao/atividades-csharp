//1. Implementar a classe ListaEncadeada;
using System; 
class No
{
    private string Elemento;
    private No Proximo;

    public No(string Elemento)
    {
        this.Elemento = Elemento;
        Proximo = null;
    }

    public string GetEelemento()
    {
        return Elemento;
    }

    public void SetElemento(string elemento)
    {
        this.Elemento = elemento;
    }

    public No GetProximo()
    {
        return Proximo; 
    }

    public void SetProximo(No proximo)
    {
        this.Proximo = proximo;
    }
}

class ListaEncadeada
{
    //Guarda o primeiro elemento da lista
    public No cabeça;
    //Guarda quantos elementos existem
    public int Quantidade;

        public ListaEncadeada()
    {
        cabeça = null;
        Quantidade = 0;
    }
}

class Program
    
{
    static void Main()
    {
        ListaEncadeada lista = new ListaEncadeada();
        Console.Write("A quantidade:"+ lista.Quantidade);
    }
}



