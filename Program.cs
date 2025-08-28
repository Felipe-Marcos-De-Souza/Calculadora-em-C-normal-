using System;

class Calculadora
{
    static int subtracao()
    {
        Console.WriteLine("Escreva o primeiro número");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o segundo número");
        int num2 = int.Parse(Console.ReadLine());
        int resultadoSub = num1 - num2;
        Console.WriteLine("Você quer adicionar mais um número à subtração?");

        if (Console.ReadLine() == "s")
        {
            Console.WriteLine("Digite o terceiro número");
            int num3 = int.Parse(Console.ReadLine());
            resultadoSub -= num3;
        }

        return resultadoSub;
    }

    static int divisao()
    {
        Console.WriteLine("Escreva o primeiro número");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o segundo número");
        int num2 = int.Parse(Console.ReadLine());
        int resultadoDiv = num1 / num2;
        Console.WriteLine("Você quer adicionar mais um número à divisão?");

        if (Console.ReadLine() == "s")
        {
            Console.WriteLine("Digite o terceiro número");
            int num3 = int.Parse(Console.ReadLine());
            resultadoDiv /= num3;
        }

        return resultadoDiv;
    }

    static void Main(string[] args)
    {
        int resultado1 = divisao();
        int resultado2 = subtracao();
        Console.WriteLine($"Resultado da divisão: {resultado1}");
        Console.WriteLine($"Resultado da subtração: {resultado2}");
    }
}
