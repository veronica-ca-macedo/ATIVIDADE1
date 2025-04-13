// EXERCICIO 4: CLASSIFICAÇÃO ALUNOS
// Enunciado: Crie um programa que leia uma lista de nomes e notas de alunos.
// O programa deve calcular a média da turma e exibir as pessoas com notas acima da média


using System; //funcionalidades básicas do .NET, como Console, DateTime
using System.Collections.Generic; //permite usar coleções genéricas, como Dictionary, List
using System.Linq;


class Program
{  
    static Dictionary<string, double> AlunosNotas = new Dictionary<string, double>();

    static double Notas;
    static string AlunosNomes;

    static void Main()
    {
        while (true)
        {
            menu();
        }
    }

    static void menu()
    {
        do
        {
        Console.WriteLine("Digite o nome do aluno. Digite FIM quando terminar de preencher.");
        AlunosNomes = Console.ReadLine();
        AlunosNomes = AlunosNomes.ToUpper();
        if (AlunosNomes == "FIM")
        {
            // parar
        }
        else
        {
        Console.WriteLine("Digite a nota deste aluno: ");
        Notas = double.Parse(Console.ReadLine());
        AlunosNotas[AlunosNomes] = Notas;
        }
        } while (AlunosNomes != "FIM");


        double media = AlunosNotas.Values.Average(); // média valores lista

        Console.WriteLine($"Média das notas: {media:F2}"); // media em duas casas decimais

    }
}