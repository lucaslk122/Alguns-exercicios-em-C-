using System;
using System.Globalization;

namespace exempço1_OrentaçãoAobjetos_dados_produtos
{
    public class Produto
    {
        private string _nome; //Esse é o padrão da linguagem C# para definir uma variavel privada, isso significa que essa classe não pode ser mudada por usuarios ou programadores.
        private double _preco;
        private int _quantidade;

        public Produto(string nome,double preco,int quantidade){
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public double ValorTotalEstoque(){
            return _preco * _quantidade;
        }
        public Produto(){
        }
        public Produto(string nome,double preco){
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }
        public void AdicionarProdutos(int quantidade){
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade){
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", $" + _preco.ToString("F2",CultureInfo.InvariantCulture) 
            + ", quantidade: " + _quantidade + " unidade"
            + " ,total $" + ValorTotalEstoque().ToString("F2",CultureInfo.InstalledUICulture);
        }
    }
}