//• Ler as notas de 80 alunos, armazená-las num array e calcular:
//• Média das notas e o número de notas acima da média;
//• Maior nota e a quantidade de alunos que tiveram a maior nota;
//• Menor nota e os índices (posição do array) dos alunos que tiveram a menor nota;
//• Número de alunos com nota <5.

using System.Runtime.Serialization;

double[] notas = new double[80];
double soma = 0;

for(int i =0; i<notas.Length; i++)
{
    Console.WriteLine($"Digite a nota do {i} aluno ");
    notas[i] = double.Parse(Console.ReadLine());

    soma += notas[i];
}

double media = soma / notas.Length;

int acimaMedia = 0;
double maiorNota = notas[0];
int qntdmaiornota = 0;
double menorNota = notas[0];
int menor5 = 0;

for(int i=0; i<notas.Length; i++)
{
    if (notas[i]>media )
    {
        acimaMedia++;
    }

    if (notas[i]>maiorNota)
    {
        maiorNota = notas[i];
        qntdmaiornota=1;
    }
    else if (notas[i]==maiorNota)
    {
        qntdmaiornota++;
    }
    if (notas[i]<menorNota)
    {
        menorNota = notas[i];
    }
    if (notas[i]<5)
    {
        menor5++;
    }
}
Console.WriteLine($"A media das notas= {media} e a quantidade de alunos acima da media é de= {acimaMedia} alunos.");
Console.WriteLine($"A maior nota é= {maiorNota} e a quantidade de alunos com a maior nota é de {qntdmaiornota} alunos.");
Console.WriteLine();
Console.WriteLine($"Menor nota= {menorNota}");
Console.WriteLine("Indice de menor nota:");
for(int i=0; i<notas.Length;i++)
{
    if (notas[i]==menorNota)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine($"Numeros de alunos com a nota menor que 5= {menor5}");

