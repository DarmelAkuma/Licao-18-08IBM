using System;
using System.Globalization;

namespace Licao18_08 {
    class Program {
        static void Main(string[] args) {

            for (int i = 0; i < 3; i++) {
                Conta IR = new Conta();
                Console.WriteLine("Digite o salário:");
                IR.salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                IR.ImpostoRenda();
                IR.Saida();
            }
        }
    }
}