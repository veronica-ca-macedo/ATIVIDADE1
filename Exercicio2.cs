// EXERCICIO 2 - Jogo de adivinhação com dicas precisas
//Enunciado: Implemente um jogo de adivinhação onde o usuário deve adivinhar um número entre 1 e 1000.
//Após cada tentativa, o programa deve informar se o número é maior ou menor que a tentativa, e também se
//está muito distante (>100), distante (>50), ou perto (≤50). 

using System;

class Program
{
    static int resposta;
    static int palpite;
    static string codigonumero = ""; // string vazia não nula

    static void Main()
    {
        while(true)
        {
            Menu();
        }
    }

static void Numeros()
{
    do{
    
    codigonumero = Console.ReadLine();
    codigonumero = codigonumero.ToUpper();
    if (codigonumero == "SAIR")
    {
        Console.WriteLine("Encerrando o sistema...");
        Environment.Exit(0);
    }
    else if (codigonumero == "A")
    {
        resposta = 168;
    }
    else if (codigonumero == "B")
    {
        resposta = 88;
    }
    else if (codigonumero == "C")
    {
        resposta = 544;
    }
    else if (codigonumero == "D")
    {
        resposta = 119;
    }
    else if (codigonumero == "E")
    {
        resposta = 780;
    }
    else
    {
        {
        Console.WriteLine("Resposta Inválida! Digite uma letra de A a E: ");
        }
    } 
     } while (codigonumero != "A" && codigonumero != "B" && codigonumero != "C" && codigonumero != "D" && codigonumero != "E");


}

static void Palpitando()
{
do
{
Console.WriteLine("Agora digite seu palpite de um número de 1 a 1000: ");
Console.WriteLine("Se deseja sair desta tentativa digite 1001. Se quiser sair do jogo digite 0.");
string entrada = Console.ReadLine();
palpite = int.Parse(entrada);

    if (palpite == 0)
    {
    Console.WriteLine("Encerrando o sistema...");
    Environment.Exit(0);
    }
    else if ((palpite < 1 || palpite > 1000) && palpite != 1001)
    {
        Console.WriteLine("Resposta inválida!");
    }

} while ((palpite < 1 || palpite > 1000) && palpite != 1001);
}

static void Dica1()
{
if (palpite == 1001) // somente sair
{

}
else if (palpite == resposta)// dizer se é maior menor ou igual
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
}

static void Dica2()
{
int diferenca = Math.Abs(palpite - resposta); // pegando o modulo
if (palpite == 1001) // somente sair
{

}
else if (diferenca > 100)
{
    Console.WriteLine("Você está muito distante, a diferença é maior do que 100!");
}
else if (diferenca > 50)
{
    Console.WriteLine("Você está distante, a diferença é maior do que 50!");
}
else if (diferenca <= 50 && diferenca > 0)
{
    Console.WriteLine("Você está próximo, a diferença é menor ou igual a 50!");
}
}


static void Menu()
{
Console.WriteLine();
Console.WriteLine("Olá! Vamos fazer um jogo de advinhação. Primeiro, escolha com qual número deseja advinhar. Digite uma letra A, B, C, D ou E: ");
Console.WriteLine("Se desejar sair do jogo digite SAIR");

Numeros(); // deixar jogador decidit qual tentativa quer fazer

do { 
Palpitando();
Dica1();
Dica2();

} while (palpite != resposta && palpite != 1001); // deixar que tentativa de chutar determinado numero acabe, mas continuar no jogo


}
} 