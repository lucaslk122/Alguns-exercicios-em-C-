
using System.Globalization;

namespace Exercico_lista_empregados
{
    public class Empregados
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public void AumentoSalario(double porcentagem){
            Salario = Salario + (Salario*(porcentagem/100));
        }

        public Empregados(int id, string nome, double salario){
            ID = id;
            Nome = nome;
            Salario = salario;
        }
        public override string ToString()
        {
            return ID + ", " + Nome + ", " + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}