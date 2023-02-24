internal class Program
{
    private static void Main(string[] args)
    {
        int opc = 0;
        while (opc != 5)
        {
            Console.Clear();
            Console.Write(" MENU\n 1- Soma\n 2- Subtração\n 3- Multiplicação\n 4- Divisão\n 5- Sair\nEscolha uma opção: ");
            opc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opc)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.Write("Opção incorreta, tente novamente"); break;
            }
            Console.WriteLine("\nGostaria de continuar? [1- SIM/2- NAO]");
            int opc2 = int.Parse(Console.ReadLine());
            if (opc2 == 2)
            {
                Console.Write("Obrigado por utilizar!!");
                break;
            }
            else
                continue;
        }

    }
    static void Soma()
    {
        Console.Write("Escolha o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escolha o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = num1 + num2;
        Console.Write("O resultado da soma é: " + result);
    }
    static void Subtracao()
    {
        Console.Write("Escolha o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escolha o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = num1 - num2;
        Console.Write("O resultado da subtração é: " + result);
    }
    static void Multiplicacao()
    {
        Console.Write("Escolha o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escolha o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = num1 * num2;
        Console.Write("O resultado da multiplicação é: " + result);
    }
    static void Divisao()
    {
        Console.Write("Escolha o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escolha o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = num1 / num2;
        Console.Write("O resultado é: " + result);
    }
}