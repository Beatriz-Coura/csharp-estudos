using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
         int num = int.Parse(Console.ReadLine());
        int fat = 1;
        while(num != 1)
        {
            fat *= num;
            num--;
        }

        Console.WriteLine($"O fatorial é: {fat}");
        
    }
}
