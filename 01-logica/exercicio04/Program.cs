//Exercício 4: Calcule a média de 3 notas e informe se o aluno está aprovado (média ≥ 7) ou reprovado.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3.0;

        if(media >= 7)
        {
            Console.WriteLine($"A média é {media}, então o aluno está aprovado");
        }
        else {
                Console.WriteLine($"A média é {media}, então o aluno está reprovado");
            }


        }
}