using System;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nome do Aluno:");
                string nome = Console.ReadLine();
                //pontuação de notas de 0 a 100
                Console.WriteLine("Digite as três notas do aluno:");
                double primeiraNota = double.Parse(Console.ReadLine());
                double segundaNota = double.Parse(Console.ReadLine());
                double terceiraNota = double.Parse(Console.ReadLine());

                Aluno aluno = new Aluno(nome, primeiraNota, segundaNota, terceiraNota);

                Console.WriteLine($"\n{aluno.Nome}: NOTA FINAL = {aluno.CalcularNota().ToString("F2")}");

                if (aluno.CalcularNota() < 60)
                {
                    Console.WriteLine($"REPROVADO\nFALTAM {aluno.VerificarQuantosFaltam().ToString("F2")} PONTOS");
                }
                else
                {
                    Console.WriteLine($"APROVADO");
                }

                Console.WriteLine("\nPressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
            catch (Exception falha)
            {
                Console.WriteLine($"> {falha.Message}");
                Console.ReadKey();
            }
        }
    }
}
