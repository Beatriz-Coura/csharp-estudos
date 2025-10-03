//Exercício 3: Receba a idade de uma pessoa e informe se ela é criança, adolescente, adulto ou idoso.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade > 0 && idade < 12)
        {
            Console.WriteLine("O usuário é uma criança");
        }
        else if (idade >= 12 && idade < 18 )
        {
            Console.WriteLine("O usuário é um adolescente");
        }
        else if (idade >= 18 && idade < 60)
        {
            Console.WriteLine("O usuário é um adulto");
        }
        else if (idade > 60)
        {
            Console.WriteLine("O usuário é um idoso");
        }
        else
        {
            Console.WriteLine("Idade inválida");
        }



    }
}