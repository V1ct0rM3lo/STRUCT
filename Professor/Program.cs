using System;

struct Professor
{
    public string nome;
    public double salario;
    public int cargaHoraria;

    public void ReajusteSalarialEmValor(double valorReajuste)
    {
        salario += valorReajuste;
    }

    public void ReajusteSalarialEmPorcentagem(double percentualReajuste)
    {
        double valorReajuste = salario * (percentualReajuste / 100);
        salario += valorReajuste;
    }

    public void DescontoSalarialPorFaltaEmValor(double valorDesconto)
    {
        if (valorDesconto >= salario)
        {
            salario = 0.0;
        }
        else
        {
            salario -= valorDesconto;
        }
    }

    public void DescontoSalarialPorFaltaEmPorcentagem(double percentualDesconto)
    {
        double desconto = salario * (percentualDesconto / 100);
        salario -= desconto;
    }

    public void AumentarCargaHorariaDeTrabalho(int horasAdicionais, double valorReajuste)
    {
        cargaHoraria += horasAdicionais;
        salario += valorReajuste;
    }

    public void Imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário: R$" + salario);
        Console.WriteLine("Carga Horária: " + cargaHoraria + " horas");
    }
}

class Program
{
    static void Main()
    {
Professor professor = new Professor();
professor.nome = "Professor Ezio Auditore";
professor.salario = 3000.0;
professor.cargaHoraria = 40;

professor.Imprimir(); // Imprime os dados do professor

professor.ReajusteSalarialEmValor(500.0); // Aplica um reajuste salarial em valor fixo

professor.ReajusteSalarialEmPorcentagem(10.0); // Aplica um reajuste salarial em porcentagem

professor.DescontoSalarialPorFaltaEmValor(200.0); // Aplica um desconto salarial por falta em valor fixo

professor.DescontoSalarialPorFaltaEmPorcentagem(5.0); // Aplica um desconto salarial por falta em porcentagem

professor.AumentarCargaHorariaDeTrabalho(5, 200.0); // Aumenta a carga horária de trabalho e aplica um reajuste salarial

professor.Imprimir(); // Imprime os dados atualizados do professor
 }
}




