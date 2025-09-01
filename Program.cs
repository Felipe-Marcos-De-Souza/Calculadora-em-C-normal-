using System;
using System.Data;
using System.Collections.Generic;

class Calculadora
{
    // Lista para armazenar o histórico das operações
    static List<string> historico = new List<string>();

    static void Main(string[] args)
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
            Console.WriteLine("7- Ver histórico");
            Console.WriteLine("8- Apagar histórico");
            Console.WriteLine("9 - Calcular expressão com parentesis");
            Console.WriteLine("6- Sair");
            Console.WriteLine("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida!");
                opcao = 0;
            }

            switch (opcao)
            {
                case 1:
                    soma();
                    break;

                case 2:
                    subtracao();
                    break;

                case 3:
                    multi();
                    break;

                case 4:
                    divisao();
                    break;

                case 5:
                    quadrada();
                    break;

                case 6:
                    Console.WriteLine("Saindo...");
                    break;

                case 7:
                    mostrarHistorico();
                    break;

                case 8:
                    apagarHistorico();
                    break;
                    
                case 9:
                    calcularExpressaoComParenteses();
                    break;
                    
                default:
                    Console.WriteLine("Opção inválida, por favor digite outro número");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        while (opcao != 6);
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

        if (decisao == 'S' || decisao == 's')
        {
            Console.WriteLine("Digite o número que deseja adicionar à soma:");
            int num3soma = int.Parse(Console.ReadLine());
            soma = (num1soma + num2soma + num3soma);
        }
        else
        {
            soma = (num1soma + num2soma);
        }

        Console.WriteLine($"O resultado é {soma}");
        historico.Add($"Soma = {soma}");
    }

    static void subtracao()
    {
        Console.WriteLine("Escreva o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o segundo número:");
        int num2 = int.Parse(Console.ReadLine());
        int resultadoSub = num1 - num2;

        Console.WriteLine("Você quer adicionar mais um número à subtração? (S/N)");
        if (Console.ReadLine().ToUpper() == "S")
        {
            Console.WriteLine("Digite o terceiro número:");
            int num3 = int.Parse(Console.ReadLine());
            resultadoSub -= num3;
        }

        Console.WriteLine($"O resultado é {resultadoSub}");
        historico.Add($"Subtração = {resultadoSub}");
    }

    static void divisao()
    {
        Console.WriteLine("Escreva o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não permitida!");
            return;
        }

        int resultadoDiv = num1 / num2;

        Console.WriteLine("Você quer adicionar mais um número à divisão? (S/N)");
        if (Console.ReadLine().ToUpper() == "S")
        {
            Console.WriteLine("Digite o terceiro número:");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 != 0)
                resultadoDiv /= num3;
            else
                Console.WriteLine("Erro: divisão por zero ignorada.");
        }

        Console.WriteLine($"O resultado é {resultadoDiv}");
        historico.Add($"Divisão = {resultadoDiv}");
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

        if (decisaomult == 'S' || decisaomult == 's')
        {
            Console.WriteLine("Digite o número que deseja multiplicar:");
            int num3mult = int.Parse(Console.ReadLine());
            mult = (num1mult * num2mult * num3mult);
        }
        else
        {
            mult = (num1mult * num2mult);
        }

        Console.WriteLine($"O resultado é {mult}");
        historico.Add($"Multiplicação = {mult}");
    }

    static void quadrada()
    {
        Console.WriteLine("===== RAIZ QUADRADA =====");
        Console.Write("Digite um número: ");

        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            if (numero >= 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine($"A raiz quadrada de {numero} é {raiz}");
                historico.Add($"Raiz quadrada de {numero} = {raiz}");
            }
            else
            {
                Console.WriteLine("Erro: Não é possível calcular a raiz quadrada de número negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite um número válido.");
        }
    }

    static void mostrarHistorico()
    {
        Console.WriteLine("===== HISTÓRICO =====");
        if (historico.Count == 0)
        {
            Console.WriteLine("Nenhuma operação realizada ainda.");
        }
        else
        {
            foreach (string item in historico)
            {
                Console.WriteLine(item);
            }
        }
    }

    static void apagarHistorico()
    {
        historico.Clear();
        Console.WriteLine("Histórico apagado com sucesso!");
    }

    static void calcularExpressaoComParenteses()
    {
        Console.WriteLine("===== EXPRESSÃO COM PARÊNTESES =====");
        Console.Write("Digite a expressão (ex: (2+3)*4): ");
        string expressao = Console.ReadLine();
    
        try
        {
            var resultado = new DataTable().Compute(expressao, null);
            Console.WriteLine($"O resultado da expressão '{expressao}' é {resultado}");
            historico.Add($"Expressão '{expressao}' = {resultado}");
        }
        catch
        {
            Console.WriteLine("Expressão inválida! Certifique-se de usar apenas números e operadores válidos.");
        }
    }

}

