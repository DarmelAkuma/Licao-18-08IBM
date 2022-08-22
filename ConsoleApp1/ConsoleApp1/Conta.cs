using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Licao18_08 {
    class Conta {

        public double Salario { get; private set; }

        public Conta(double salario) {
            Salario = salario;
        }
        public double ImpostoRenda() {
            double[] primeiraRenda = new double[] { 0, 2000 };
            double[] segundaRenda = new double[] { 2000.01, 3000 };
            double[] terceiraRenda = new double[] { 3000.01, 4500 };

            if (Salario > primeiraRenda[0] && Salario <= primeiraRenda[1]) {
                return 0;
            }
            else if (Salario >= segundaRenda[0] && Salario <= segundaRenda[1]) {
                return (Salario - 2000) * 0.08;
            }
            else if (Salario >= terceiraRenda[0] && Salario <= terceiraRenda[1]) {
                return (Salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else {
                return (Salario - 4500) * 0.28 + 1000 * 0.08 + 1500 * 0.18;
            }
        }
        public override string ToString() {

            var portecentagem = ImpostoRenda();

            return portecentagem == 0 ? "Isento" : "R$ " + portecentagem.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
