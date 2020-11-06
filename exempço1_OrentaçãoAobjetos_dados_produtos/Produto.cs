using System;
using System.Globalization;

namespace exempço1_OrentaçãoAobjetos_dados_produtos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
            return Nome + ", $" + Preco.ToString("F2",CultureInfo.InvariantCulture) 
            + ", quantidade: " + Quantidade + " unidade"
            + " ,total $" + ValorTotalEstoque().ToString("F2",CultureInfo.InstalledUICulture);
        }
    }
}