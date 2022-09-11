using System;
using System.Globalization;

namespace teste
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;

        }

        public void AdicionarQuantidade(int quantidade)
        {
           
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverQuantidade(int remove)
        {

            Quantidade = Quantidade - remove;
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " Unidades, total: $ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture) ;              
        }
    }

}
