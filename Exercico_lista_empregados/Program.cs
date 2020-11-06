using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercico_lista_empregados
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Registro de funcionarios");
            System.Console.WriteLine();
            System.Console.Write("Digite o numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());
            List<Empregados> list = new List<Empregados>();
            for (int i = 0 ; i < n ; i++){
                System.Console.WriteLine($"Empregado #{i}");
                System.Console.Write("ID: ");
                int id= int.Parse(Console.ReadLine());
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
                System.Console.WriteLine();
                list.Add(new Empregados (id,nome,salario));
            }
            System.Console.Write("Entre com o ID do funcionario que receberá o aumento: ");
            int id1 = int.Parse(Console.ReadLine());
            Empregados empregado = list.Find(x=> x.ID == id1);
            if(empregado != null){
                System.Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                empregado.AumentoSalario(porcentagem);
            }
            else{
                System.Console.WriteLine("Esse ID não existe");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Lista atualizada: ");
            foreach(Empregados obj in list){
                System.Console.WriteLine(obj);
            }
        }
    }
}
