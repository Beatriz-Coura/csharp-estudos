//Exercício 1: Crie um algoritmo que receba dois números e mostre a soma, subtração, multiplicação e divisão.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        if (num2 != 0)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero!");
        }

    }
}

