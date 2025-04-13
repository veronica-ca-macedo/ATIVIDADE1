// EXERCICIO 1: JOGO DA FORCA
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
    static int tentativa;
    static char[] respostaEscondida;
    static char[] array;
    static string codigoresposta;
    static int maxtentativas;


    static void Main()
    {
    while (true)
    {
    menu();
    }
    }

    static void Respostas()
    {
        do
        {
        Console.WriteLine("Digite uma letra de A - E para escolher sua palavra: ");
        Console.WriteLine("Se deseja sair do jogo, digite SAIR");
        codigoresposta = Console.ReadLine();
        codigoresposta = codigoresposta.ToUpper();
        if (codigoresposta == "SAIR")
        {Console.WriteLine("Encerrando o sistema...");
        Environment.Exit(0);
        }
        if (codigoresposta == "A")
        {
        resposta = "Egito";
        }
        else if (codigoresposta == "B")
        {
        resposta = "Vermelho";
        }
        else if (codigoresposta == "C")
        {
        resposta = "Agosto";
        }
        else if (codigoresposta == "D")
        {
        resposta = "Inverno";
        }
        else if (codigoresposta == "E")
        {
        resposta = "Livro";
        }
        else
        {
        Console.WriteLine("Resposta Inválida!");
        }
        } while (codigoresposta != "A" && codigoresposta != "B" && codigoresposta != "C" && codigoresposta != "D" && codigoresposta != "E");

    }


    static void AjustandoResposta()
    {
        resposta = resposta.ToUpper(); // ajustando erros de maiuscula e minuscula 
        array = resposta.ToCharArray(); // convertendo palavra em array de caracteres         

        respostaEscondida = new char[array.Length]; //array do tamanho da resposta mas vazio
        for (int i = 0; i < array.Length; i++) // ultimo array é length-1 (indezador comecao com 0)
        {
        respostaEscondida[i] = '_'; // convertendo todos os vazios para _
        }
        
        maxtentativas = (int)Math.Ceiling(array.Length * 1.5); // palavras maiores podem ter mais tentativas
    }

    static void Jogo()
    {
     do
     {
        tentativa = tentativa + 1;
        Console.WriteLine($"Você está na tentativa {tentativa} de {maxtentativas}. Escreva uma letra para a palavra {new string(respostaEscondida)}: ");
        Console.WriteLine("Se deseja sair do JOGO, digite SAIR. Se quiser sair desta TENTATIVA digite TROCAR.");
        palpite = Console.ReadLine();
        palpite = palpite.ToUpper(); // protegendo de erro de maiusculo e minusculo

        if (palpite == "SAIR")
            {
            Console.WriteLine("Encerrando o sistema...");
            Environment.Exit(0);
            }
        else if (palpite == "TROCAR")
                {
                break;
                }

        char letraPalpite = palpite[0]; // apenas uma letra (a primeira)
        resultado = false; // declara aqui e se passar por um verdadeiro passa a ser sempre verdadeiro, e se for tudo falso fica tudo falso
        
            for (int i = 0; i < array.Length; i++) // ultimo array é length-1 (indezador comecao com 0)
            {
                if (resposta[i] == letraPalpite) // se tiver duas letras iguais ja se ajusta
                    {
                    respostaEscondida[i] = letraPalpite;
                    resultado = true;
                    }
            }

        Console.WriteLine();
        // resultado da tentativa
        if (resultado == true)
            {
            Console.WriteLine($"Parabéns! A letra {letraPalpite} está correta");
            Console.WriteLine($"Seu resultado agora é {new string(respostaEscondida)}");
            }
        else
            {
            Console.WriteLine($"A letra {letraPalpite} está incorreta, tente novamente.");
            }
    } while (new string(respostaEscondida) != resposta && tentativa < maxtentativas);   
    }

    static void ResultadoFinal()
    {
        if (new string(respostaEscondida) == resposta)
        {
        Console.WriteLine($"Parabéns! Você conseguiu! A resposta é {resposta}!");
        }
        else if (tentativa == maxtentativas) // ajustado pq se quebrasse o do while apareceria msg errada
        {
        Console.WriteLine("Você excedeu o limite de tentativas!");
        }
    }




    static void menu()
    {
        tentativa = 0;
        Console.WriteLine();
        Console.WriteLine($"Vamos jogar o jogo da forca!");
        Respostas();
        AjustandoResposta();
        Console.WriteLine();
        Jogo();
        Console.WriteLine();
        ResultadoFinal();
    }


}