using System; 
  

class Program 
{ 
static string palavra; 
static string inverso; 
static void Main() 
    { 
        while (true) 
        { 
            menu(); 
        } 
    } 

static void Invertendo() 
{ 
    palavra = palavra.ToUpper(); // ajustando erros de maiuscula e minuscula 
    char[] array = palavra.ToCharArray(); // convertendo palavra em array de caracteres 
    Array.Reverse(array); //invertendo o array para formar nova palavra 
    inverso = new string(array); //fazedno o array inverso virar uma string 
} 

static void Validando() 
{ 
    if (palavra == "SAIR") // encerrar sistema 
        { 
            Console.WriteLine("Encerrando o sistema..."); 
            Environment.Exit(0); 
        } 

    else if (inverso == palavra) // resposta para o usuario 
    { 
       Console.WriteLine($"Sua palavra {palavra} é um palíndromo!"); 
    } 
    else 
    { 
        Console.WriteLine($"Sua palavra {palavra} não é um palíndromo! O inverso dela é {inverso}"); 
    } 
} 
 

static void menu() 
{ 
    Console.WriteLine("Olá! Vamos validar se a palavra é um palíndromo"); 
    Console.WriteLine("Escreva a plavra desejada: "); 
    Console.WriteLine("Se deseja sair, escreva 'SAIR'"); 
    palavra = Console.ReadLine(); 


    Invertendo(); 
    Validando(); 
Console.WriteLine(); 
} 
 

} 
