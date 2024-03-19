using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual operação deseja utilizar (/, *, -, +): ");
            string operacao = Console.ReadLine();

            switch (operacao)
            {
                case "/":
                    double divisao = n1 / n2;
                    Console.WriteLine("O resultado da operação é: " + divisao);
                    break;
                case "*":
                    double mult = n1 * n2;
                    Console.WriteLine("O resultado da operação é: " + mult);
                    break;
                case "-":
                    double subtracao = n1 - n2;
                    Console.WriteLine("O resultado da operação é: " + subtracao);
                    break;
                case "+":
                    double soma = n1 + n2;
                    Console.WriteLine("O resultado da operação é: " +soma);
                    break;

            }

            Console.ReadKey();

        }
    }
}
