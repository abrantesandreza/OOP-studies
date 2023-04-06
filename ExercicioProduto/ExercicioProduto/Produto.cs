using System.Globalization;

namespace ExercicioProduto
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int addQuantidade)
        {
            Quantidade += addQuantidade;
        }

        public void RemoverProdutos(int removQuantidade)
        {
            Quantidade -= removQuantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) + " reais";
        }

    }

}
