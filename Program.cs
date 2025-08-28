using System;

class Calculadora
{
    static void Main
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("===== CALCULADORA =====");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Raiz quadrada");
            Console.WriteLine("6- Sair");
            Console.WriteLine("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                adicao()
                break;

                case 2:
                subtracao()
                break;

                case 3:
                multi()
                break;

                case 4:
                divisao()
                break;

                case 5:
                quadrada()
                break;

                case 6:
                Console.WriteLine("Saindo...");
                break;

                default:
                Console.WriteLine("Opção inválida, por favor digite outro número");
                break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        while(opcao != 6);
        
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
    static void soma()
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1soma = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int num2soma = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Deseja somar mais algum número? (S/N)");
        char decisao = char.Parse(Console.ReadLine());
        int soma;
        
        if (decisao == 'S')
        {
            Console.WriteLine("Digite o número que deseja adicionar a soma:");
            int num3soma = int.Parse(Console.ReadLine());
            soma = (num1soma + num2soma + num3soma);
            Console.WriteLine($"O resultado é {soma}");
        }
        
        else if (decisao == 'N')
        {
            soma = (num1soma + num2soma);
            Console.WriteLine($"O resultado é {soma}");
        }
    }

    static void multi()
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1mult = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int num2mult = int.Parse(Console.ReadLine());
        Console.WriteLine("Deseja multiplicar mais algum número? (S/N)");
        char decisaomult = char.Parse(Console.ReadLine());
        int mult;
        
        if (decisaomult =='S')
        {
            Console.WriteLine("Digite o número que deseja adicionar a multiplicação:");
            int num3mult = int.Parse(Console.ReadLine());
            mult = (num1mult * num2mult * num3mult);
            Console.WriteLine($"O resultado é {mult}");
        }
        
        else if(decisaomult == 'N')
        {
            mult = (num1mult*num2mult);
            Console.WriteLine($"O resultado é {mult}");
        }
    }

    static void Main(string[] args)
    {
        int resultado1 = divisao();
        int resultado2 = subtracao();
        Console.WriteLine($"Resultado da divisão: {resultado1}");
        Console.WriteLine($"Resultado da subtração: {resultado2}");
    }
}


