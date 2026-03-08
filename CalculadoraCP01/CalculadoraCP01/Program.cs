public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*** Calculadora (Adição / Subtração / Multiplicação / Divisão) ***\n");

        int EscolhaUser;

        do
        {
            ExibirMenu();
            EscolhaUser = int.Parse(Console.ReadLine());

            if (EscolhaUser >= 1 && EscolhaUser <= 4)
            {
                Console.Write("Digite o primeiro número: \n--> ");
                int Num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: \n--> ");
                int Num2 = int.Parse(Console.ReadLine());

                switch (EscolhaUser)
                {
                    case 1:
                        Console.WriteLine("Você escolheu Adição.");
                        Somar(Num1, Num2);
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu Subtração.");
                        Subtrair(Num1, Num2);
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu Multiplicação.");
                        Multiplicar(Num1, Num2);
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu Divisão.");
                        Dividir(Num1, Num2);
                        break;
                }

                Console.Write("Deseja realizar outra operação? (S/N) \n--> ");
                string Continuar = Console.ReadLine().ToUpper();
                if (Continuar != "S")
                {
                    Console.WriteLine("Saindo da calculadora. Até logo!");
                    break;
                }
            }
            else if (EscolhaUser == 5)
            {
                Console.WriteLine("Saindo da calculadora. Até logo!");
            }
            else
            {
                Console.Write("Entrada inválida. Por favor, insira um número entre 1 e 5. \n--> ");
            }

        } while (EscolhaUser != 5);
    }

    public static void ExibirMenu()
    {
        Console.Write("Escolha uma opção:\r\n1-Adição\r\n2-Subtração\r\n3-Multiplicação\r\n4-Divisão\r\n5-Sair \n--> ");
    }

    public static void Somar(int A, int B)
    {
        int Resultado = A + B;
        Console.WriteLine($"A soma de {A} e {B} é: {Resultado}");
    }

    public static void Subtrair(int A, int B)
    {
        int Resultado = A - B;
        Console.WriteLine($"A subtração de {A} e {B} é: {Resultado}");
    }

    public static void Multiplicar(int A, int B)
    {
        int Resultado = A * B;
        Console.WriteLine($"A multiplicação de {A} e {B} é: {Resultado}");
    }

    public static void Dividir(int A, int B)
    {
        if (B != 0)
        {
            int Resultado = A / B;
            Console.WriteLine($"A divisão de {A} por {B} é: {Resultado}");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
    }
}