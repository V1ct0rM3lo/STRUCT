using System;

struct JogadorFutebol
{
    public string nome;
    public int idade;
    public string clubeAtual;
    public int numeroCartoesAmarelos;
    public int numeroCartoesVermelhos;

    public void RegistrarNumeroCartoesAmarelos()
    {
        numeroCartoesAmarelos++;
    }

    public void RegistrarNumeroCartoesVermelhos()
    {
        numeroCartoesVermelhos++;
    }

    public bool VerificarVinculoClube()
    {
        return !string.IsNullOrEmpty(clubeAtual);
    }

    public void Imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Clube atual: " + clubeAtual);
        Console.WriteLine("Número de cartões amarelos: " + numeroCartoesAmarelos);
        Console.WriteLine("Número de cartões vermelhos: " + numeroCartoesVermelhos);
    }


    class Program
    {
        static void Main()
        {
            JogadorFutebol jogador = new JogadorFutebol();
            jogador.nome = "Luva de Pedreiro";
            jogador.idade = 19;
            jogador.clubeAtual = "Clube das Capivaras";
            jogador.numeroCartoesAmarelos = 2;
            jogador.numeroCartoesVermelhos = 1;

            jogador.Imprimir(); // Imprime os dados do jogador

            jogador.RegistrarNumeroCartoesAmarelos(); // Incrementa o número de cartões amarelos
            jogador.RegistrarNumeroCartoesVermelhos(); // Incrementa o número de cartões vermelhos

            bool possuiVinculo = jogador.VerificarVinculoClube(); // Verifica se o jogador possui vínculo com algum clube

            jogador.Imprimir(); // Imprime os dados atualizados do jogador
        }
    }

}
