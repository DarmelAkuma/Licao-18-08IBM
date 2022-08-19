using System;
using System.Globalization;

namespace Licao18_08 {
    class Program {
        static void Main(string[] args) {

            double salario, imposto, porcentagem, e, e1, e2;

            imposto = 0;
            porcentagem = 0;

            Console.WriteLine("Digite seu salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000) {
                Console.WriteLine();
                Console.WriteLine("Isento");
            }
            else if (salario >= 2000.01 && salario <= 3000) {
                e = salario - 2000;

                porcentagem = 8.0 / 100.0;
                imposto = porcentagem * e;

                Console.WriteLine(imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 3000.01 && salario <= 4500) {
                e = salario - 2000;
                e1 = e - 1000;

                porcentagem = 8.0 / 100.0;
                imposto = porcentagem * (e - e1);

                porcentagem = 18.0 / 100.0;
                imposto += porcentagem * e1;

                Console.WriteLine(imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (salario > 4500) {
                e = salario - 2000;
                e1 = e - 1000;
                e2 = e1 - 1500;
                porcentagem = 8.0 / 100.0;
                imposto = porcentagem * 1000;

                porcentagem = 18.0 / 100.0;
                imposto += porcentagem * 1500;

                porcentagem = 28.0 / 100.0;
                imposto += porcentagem * e2;

                Console.WriteLine(imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}