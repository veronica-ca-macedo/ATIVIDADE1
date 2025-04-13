﻿// EXERCICIO 1: JOGO DA FORCA
//  Implemente o jogo da forca. O usuário deve adivinhar uma palavra, letra por letra.
//O programa deve mostrar a palavra oculta com underscores e revelar as letras corretas conforme são adivinhadas.
//O usuário tem um número limitado de tentativas.


using System; //funcionalidades básicas do .NET, como Console, DateTime
using System.Collections.Generic; //permite usar coleções genéricas, como Dictionary, List


class Program
{  
    static string resposta;
    static string palpite;
    static bool resultado;


    static void Main()
    {
        while (true)
        {
            menu();
        }
    }

    static void menu()
    {
        resposta = "veronica";


        resposta = resposta.ToUpper(); // ajustando erros de maiuscula e minuscula 
        char[] array = resposta.ToCharArray(); // convertendo palavra em array de caracteres         

        char[] respostaEscondida = new char[array.Length];
        for (int i = 0; i < array.Length; i++) // ultimo array é length-1 (indezador comecao com 0)
        {
        respostaEscondida[i] = '_'; // para todas as letras converter a letra por _
        }


        //string respostaescondida = new string(array);  // tranformado resposta com tds letras são _

do
{
        Console.WriteLine($"Vamos jogar jogo da forca! Escreva uma letra seu palpite da palavra {respostaEscondida} abaixo: ");
        palpite = Console.ReadLine();
        palpite = palpite.ToUpper(); // protegendo de erro de maiusculo e minusculo
        char letraPalpite = palpite[0]; // apenas uma letra (a primeira)

        resultado = false;
        
        for (int i = 0; i < array.Length; i++) // ultimo array é length-1 (indezador comecao com 0)
        {
            if (resposta[i] == letraPalpite)
            {
                respostaEscondida[i] = letraPalpite;
                resultado = true;
            }
        }

        if (resultado == true)
        {
            Console.WriteLine($"Parabéns! A letra {letraPalpite} está correta, a palavra agora é {respostaEscondida}");
        }
        else
        {
            Console.WriteLine($"A letra {letraPalpite} está incorreta, tente novamente");
        }


} while(true);
        

    }









}
    