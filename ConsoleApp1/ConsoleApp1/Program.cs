using System;
using System.Globalization;

namespace Licao18_08 {
    class Program {
        static void Main(string[] args) {

            for (int i = 0; i < 3; i++) {
                Console.Write("Digite o salário: ");
                var salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta resultado = new Conta (salario);
                Console.WriteLine(resultado);
            }
        }
    }
}