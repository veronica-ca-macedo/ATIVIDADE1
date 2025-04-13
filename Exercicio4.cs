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
    static int escolhaturma;

    static void Main()
    {
        while (true)
        {
            menu();
        }
    }

    static void PreenchendoNomes()
    {
        do
        {
        Console.WriteLine("Digite o nome do aluno. Digite FIM quando terminar de preencher ou SAIR para encerrar o sistema.");
        AlunosNomes = Console.ReadLine();
        AlunosNomes = AlunosNomes.ToUpper();
        if (AlunosNomes == "FIM")
        {
            break;
        }
        if (AlunosNomes == "SAIR")
        {
            Console.WriteLine("Encerrando o sistema...");
            Environment.Exit(0);;
        }
        else
        {
        Console.WriteLine("Digite a nota deste aluno: ");
        Notas = double.Parse(Console.ReadLine());
        Notas = Math.Round(Notas, 2);
        AlunosNotas[AlunosNomes] = Notas;
        }
        } while (true);
    }

    static void CalculoMedia()
    {
        double media = AlunosNotas.Values.Average(); // média valores lista
        media = Math.Round(media, 2);
        Console.WriteLine();
        Console.WriteLine($"Média das notas: {media}"); // media em duas casas decimais
        
        Console.WriteLine("Os alunos acima da média são: ");

        foreach (var aluno in AlunosNotas)
        {
            if (aluno.Value  > media)
            {
                Console.WriteLine($"{aluno.Key}: {aluno.Value}"); // imprimindo  nomes e sua respectica nota
            }
        }
    }

    static void NovaTurma()
    {
        do // problema: estava considerando para a mesma turma qdo digitava o mesmo
        {
        Console.WriteLine();
        Console.WriteLine("Deseja calcular para uma NOVA turma? Digite 1 para SIM e 0 para 'NÃO, quero continuar nessa turma' ou 2 para SAIR");
        escolhaturma = int.Parse(Console.ReadLine());
        if (escolhaturma == 1)
        {
            foreach (var aluno in AlunosNotas)
            {
            AlunosNotas.Remove(AlunosNomes);
            }
        }
        else if (escolhaturma == 0)
        {
            //continuar adicionando
        }
        else if (escolhaturma == 2)
        {
            Console.WriteLine("Encerrando o sistema...");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
        } while (escolhaturma != 1 && escolhaturma != 0);
    }

    static void menu()
    {
        PreenchendoNomes();
        CalculoMedia();
        NovaTurma();
    }
}