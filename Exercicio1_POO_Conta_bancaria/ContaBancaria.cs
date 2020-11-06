using System.Globalization;

namespace Exercicio1_POO_Conta_bancaria
{
    public class ContaBancaria
    {
        public int Numero {get; private set;}
        public string Titutlar {get; set; }
        public double Saldo {get; private set; }

        public ContaBancaria(int numero , string titular){
            Numero = numero;
            Titutlar = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numero, string titular, double depositoIniciar): this(numero,titular){
            Deposito(depositoIniciar);
        }

        public void Deposito(double quantia){
            Saldo = quantia + Saldo;
        }

        public void Saque(double quantia){
            Saldo = Saldo - quantia - 5.00;
        }

        public override string ToString(){
            return "Conta "
            + Numero
            + " , Titular: "
            + Titutlar
            + ", Saldo: $ "
            + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}