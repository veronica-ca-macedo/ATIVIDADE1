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
}

}