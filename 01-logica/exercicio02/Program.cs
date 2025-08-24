//Exercício 2: Escreva um programa que leia um número inteiro e diga se ele é par ou ímpar.

using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"O número {num} é par");
        }
        else
        {
            Console.WriteLine($"O número {num} é impar");
        }
    }
}