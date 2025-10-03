// Exercício 6: Crie uma aplicação console que peça o nome do usuário e mostre: Olá, {nome}!

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escreva seu nome: ");
        string nome = Console.ReadLine();
        Console.Write($"Olá, {nome}");
    }
}
