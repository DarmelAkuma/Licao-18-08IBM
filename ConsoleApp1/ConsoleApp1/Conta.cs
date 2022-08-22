using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Licao18_08 {
    class Conta {
        public decimal salario;
        public decimal porcentagem;
        public void ImpostoRenda() {

            var primeiraRenda = new[] { 0, 2000 };
            decimal[] segundaRenda = new decimal[] { 2000.01m, 3000 };
            decimal[] terceiraRenda = new decimal[] { 3000.01m, 4500 };

            if (salario < primeiraRenda[1]) {
                porcentagem = 0;
            }
            else if (salario < segundaRenda[1]) {
                porcentagem = (salario - primeiraRenda[1]) * 0.08m;
            }
            else if (salario < terceiraRenda[1]) {
                porcentagem = (salario - segundaRenda[1]) * 0.18m + (1000 * 0.08m);
            }
            else if (salario > terceiraRenda[1]) {
                porcentagem = (salario - terceiraRenda[1]) * 0.28m + (1500 * 0.18m) + (1000 * 0.08m);
            }
        }
        public void Saida() {
            if (porcentagem >= 0) {
                Console.WriteLine("R$ " + porcentagem.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (porcentagem == 0){
                Console.WriteLine("Isento");
            }
        }
    }
}