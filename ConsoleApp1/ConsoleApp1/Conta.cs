using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Licao18_08 {
    class Conta {
        private readonly decimal _salario;

        public Conta(decimal salario) {
            _salario = salario;
        }
        private decimal ImpostoRenda() {
            var primeiraRenda = new decimal[] { 0, 2000 };
            decimal[] segundaRenda = new decimal[] { 2000.01m, 3000 };
            decimal[] terceiraRenda = new decimal[] { 3000.01m, 4500 };

            if (_salario < primeiraRenda[1]) {
                return 0;
            }
            else if (_salario >= segundaRenda[0] && _salario <= segundaRenda[1]) {
                return (_salario - primeiraRenda[1]) * 0.08m;
            }
            else if (_salario >= terceiraRenda[0] && _salario <= terceiraRenda[1]) {
                return (_salario - segundaRenda[1]) * 0.18m + (1000 * 0.08m);
            }
            else {
                return (_salario - terceiraRenda[1]) * 0.28m + (1000 * 0.08m) + (1500 * 0.18m);
            }
        }
        public override string ToString() {
            var reducao = ImpostoRenda();
            return  reducao == 0 ? "Isento" : "R$ " + reducao.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}