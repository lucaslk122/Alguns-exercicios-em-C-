using System;
using System.Globalization;

namespace exempço1_OrentaçãoAobjetos_dados_produtos
{
    public class Produto
    {
        private string _nome; //Esse é o padrão da linguagem C# para definir uma variavel privada, isso significa que essa classe não pode ser mudada por usuarios ou programadores.
        public double Preco{get; private set;}
        public int Quantidade{get; private set;}

        public Produto(){

        }
        
        public string Nome{
            get {return _nome;}
            set {
                if (value != null && value.Length > 1){
                _nome = value;
                }
            }
        }

        public Produto(string nome,double preco,int quantidade){
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade){
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2",CultureInfo.InvariantCulture) 
            + ", quantidade: " + Quantidade + " unidade"
            + " ,total $" + ValorTotalEstoque().ToString("F2",CultureInfo.InstalledUICulture);
        }
    }
}