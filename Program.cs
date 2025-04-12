// EXERCICIO 3. Verificação de Palíndromo 
// Enunciado: Escreva um programa que leia uma string e verifique se ela é um palíndromo
//(palavra que se lê da mesma forma de trás para frente). O programa deve ignorar espaços e considerar
//maiúsculas e minúsculas como iguais. 

using System;

class Program
{
static void Main()
    {
        while (true)
        {
            menu();
        }
    }

static void menu()
{
    Console.WriteLine("Olá! Vamos validar se a palavra é um palíndromo");
    Console.WriteLine("Escreva a plavra desejada: ");
    string palavra = Console.ReadLine();

    char[] array = palavra.ToCharArray(); // convertendo palavra em array de caracteres
        Array.Reverse(array); //invertendo o array para formar nova palavra
        string inverso = new string(array); //fazedno o array inverso virar uma string

    if (inverso == palavra) // resposta para o usuario
    {
        Console.WriteLine($"Sua palavra {palavra} é um palíndromo!");
    }
    else
    {
        Console.WriteLine($"Sua palavra {palavra} não é um palíndromo! O inverso dela é {inverso}");
    }
}

}