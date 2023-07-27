internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Por favor, entre com o primeiro valor inteiro: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor, entre com o segundo número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int soma = num1 + num2;

        Console.WriteLine("A soma desses valores é: " + soma);
    }
}