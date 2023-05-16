using System;

struct Produto
{
    public string nome;
    public double preco;
    public int quantidadeEmEstoque;

    public void AplicarCupomDescontoValor(double valorDesconto)
    {
        if (valorDesconto >= preco)
        {
            preco = 0.0;
        }
        else
        {
            preco -= valorDesconto;
        }
    }

    public void AplicarCupomDescontoPorcentagem(double percentualDesconto)
    {
        double desconto = preco * (percentualDesconto / 100);
        preco -= desconto;
    }

    public void VerificarQuantidadeEmEstoque()
    {
        Console.WriteLine("Quantidade em estoque: " + quantidadeEmEstoque);
    }

    public void Imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preço: R$" + preco);
        Console.WriteLine("Quantidade em estoque: " + quantidadeEmEstoque);
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();
        produto.nome = "God of War: Ragnarok";
        produto.preco = 375.0;
        produto.quantidadeEmEstoque = 1000;

        produto.Imprimir(); // Imprime os dados do produto

        produto.AplicarCupomDescontoValor(20.0); // Aplica um cupom de desconto em valor fixo

        produto.AplicarCupomDescontoPorcentagem(10.0); // Aplica um cupom de desconto em porcentagem

        produto.VerificarQuantidadeEmEstoque(); // Verifica a quantidade em estoque do produto

        produto.Imprimir(); // Imprime os dados atualizados do produto
    }
}