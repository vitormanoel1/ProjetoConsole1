using System;

namespace projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o primeiro numero: ");
            string num1_texto = Console.ReadLine();
            int num1 = int.Parse(num1_texto);

            Console.Write("digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma =num1 + num2;

            Console.Write("o resultado é: ");
            Console.Write(soma);
        }
    }
    
}
