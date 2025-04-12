// EXERCICIO 2 - Jogo de adivinhação com dicas precisas
//Enunciado: Implemente um jogo de adivinhação onde o usuário deve adivinhar um número entre 1 e 1000.
//Após cada tentativa, o programa deve informar se o número é maior ou menor que a tentativa, e também se
//está muito distante (>100), distante (>50), ou perto (≤50). 


using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            Menu();
        }
    }


static void Menu()
{
Console.WriteLine("Olá! Vamos fazer um jogo de advinhação, escreva um número de 1 a 1000: ");

int palpite = int.Parse(Console.ReadLine());
int resposta = 765 ; 

// dica 1
if (palpite == resposta)// dizer se é maior menor ou igual
{
    Console.WriteLine($"Parabéns! Você acertou! A resposta é {resposta}");
}
else if (palpite < resposta)
{
    Console.WriteLine($"A resposta é maior que seu palpite de {palpite}");
}
else if (palpite > resposta)
{
    Console.WriteLine($"A resposta é menor que seu palpite de {palpite}");
}

// dica 2
int diferenca = Math.Abs(palpite - resposta); // pegando o modulo
if (diferenca > 100)
{
    Console.WriteLine("Você está muito distante, a diferença é maior do que 100!");
}
else if (diferenca > 50)
{
    Console.WriteLine("Você está distante, a diferença é maior do que 50!");
}
else if (diferenca <= 50)
{
    Console.WriteLine("Você está próximo, a diferença é menor ou igual a 50!");
}


}
}