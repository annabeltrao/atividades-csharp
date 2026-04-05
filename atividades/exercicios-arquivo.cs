using System;
using System.IO;

class arquivo
{
    static void Main()
    {
        string caminho = "text.txt";

        if (File.Exists(caminho))
        {
            Console.WriteLine("O arquivo existe!");


            //Lê o conteudo do arquivo 
            string conteudo = File.ReadAllText(caminho);
            Console.WriteLine("O conteudo do arquivo:");
            Console.WriteLine(conteudo);
        }

        //  Se o arquivo não existir
        else
        {
            Console.WriteLine("O arquivo não existe.");
        }

        // Pedir para o usuario adcionar um novo conteudo no arquivo.

        Console.WriteLine("Adicione um novo conteudo ao arquivo");
        string novoTexto = Console.ReadLine();

        File.WriteAllText(caminho, novoTexto);

        Console.WriteLine("Alteração feita com sucesso!");

    }
}

