using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    using System;

    namespace URI
    {
        class Program
        {
            static void Main(string[] args)
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                int number = int.Parse(Console.ReadLine());
                int hora = int.Parse(Console.ReadLine());
                double valorHora = double.Parse(Console.ReadLine(), CI);

                double salario = hora * valorHora;

                Console.WriteLine("Number = " + number);
                Console.WriteLine("Salary = " + salario.ToString("F2", CI));

            }
        }
    }
}