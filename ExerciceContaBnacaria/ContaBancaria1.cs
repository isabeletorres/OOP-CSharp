using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciceContaBnacaria {
    internal class ContaBancaria1 {
       public int Numero {  get; private set; }
       public string Titular { get; set; }
       public double Saldo { get; private set; }

        public ContaBancaria1(int num, string nome) {
            Numero = num;
            Titular = nome;
            Saldo = 0;
        }
        public ContaBancaria1(int num, string nome, double saldo) : this(num, nome) {
            Saldo = saldo;
        }
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= quantia + 5;
        }
        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo;
        }
    }
}
