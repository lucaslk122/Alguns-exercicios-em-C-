using System;
using System.Globalization;

namespace ExeFixação2_POO_rfuncionario
{
    public class Funcionario
    {
        public double SalarioBruto;
        public double Imposto;
        public string Nome;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem){
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem/100.0);
        }
        public override string ToString(){
            return Nome + " , R$ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}