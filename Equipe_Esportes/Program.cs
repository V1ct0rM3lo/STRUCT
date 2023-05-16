using System;

struct EquipeEsports
{
    public string nome;
    public string jogo;
    public int numeroCampeonatosVencidos;
    public double valorTotalPremiacoes;
    public int anoEstreia;

    public void RegistrarCampeonatoVencido(double valorPremio)
    {
        numeroCampeonatosVencidos++;
        AtualizarValorTotalPremiacoes(valorPremio);
    }

    public void AtualizarValorTotalPremiacoes(double valor)
    {
        valorTotalPremiacoes += valor;
    }

    public bool VerificarAnoEstreia()
    {
        int anoAtual = DateTime.Now.Year;
        return anoEstreia == anoAtual;
    }

    public void Imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Jogo: " + jogo);
        Console.WriteLine("Número de campeonatos vencidos: " + numeroCampeonatosVencidos);
        Console.WriteLine("Valor total de premiações: " + valorTotalPremiacoes);
        Console.WriteLine("Ano de estreia: " + anoEstreia);
    }
}
class Program
{
    static void Main()
    {
        EquipeEsports equipe = new EquipeEsports();
        equipe.nome = "Pain";
        equipe.jogo = "League of Legends";
        equipe.numeroCampeonatosVencidos = 2;
        equipe.valorTotalPremiacoes = 5000.0;
        equipe.anoEstreia = 2010;

        equipe.Imprimir(); // Imprime os dados da equipe

        equipe.RegistrarCampeonatoVencido(2000.0); // Incrementa o número de campeonatos vencidos e atualiza o valor total de premiações

        equipe.AtualizarValorTotalPremiacoes(1500.0); // Atualiza o valor total de premiações

        bool anoEstreia = equipe.VerificarAnoEstreia(); // Verifica se a equipe é novata ou veterana

        equipe.Imprimir(); // Imprime os dados atualizados da equipe
    }
}