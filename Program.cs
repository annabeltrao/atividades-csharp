//• Ler uma sequência de 20 números inteiros para um array, e:
//• Para cada elemento do array, escreva na consola o seu valor e a sua posição, começando na primeira posição;
//• Para cada elemento do array, escreva na consola o seu valor e a sua posição, começando na última posição e terminando na primeira posição;
//• Inverta a posição dos elementos do array;
//• Some o valor 10 a cada elemento do array

int[] numeros = { 04, 07, 11, 15, 18,22,25, 29, 31,34, 38,40,43,47,50,52,55,58, 59, 60 };

for (int i= 0; i<20; i++)
{
    Console.WriteLine($"Posição: {i}= {numeros[i]}");
}

Console.WriteLine();

for (int i= 19;i>0;i--)
{
    Console.WriteLine($"Posição: {i}= {numeros[i]}");
}

Console.WriteLine();

for (int i = 0; i < numeros.Length / 2; i++)
{
    int temp = numeros[i];
    numeros[i] = numeros[numeros.Length - 1 - i];
    numeros[numeros.Length - 1 - i] = temp;
}

Console.WriteLine(); 

for(int i=0; i< numeros.Length; i++)
{
    numeros[i] += 10;
}

Console.WriteLine();

for(int i =0; i<numeros.Length; i++)
{
    Console.WriteLine($"Posição {i} = {numeros[i]}");
}