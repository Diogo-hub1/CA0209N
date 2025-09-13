using System;

public class Gerente:Funcionario
{
	public Gerente()
	{
		public string nomeEquipe;
		public int numeroEquipe;


	  public int AprovarFerias(int dias, int dias_de_atestado, int colaboraresDeFerias, int dias_trabalhado)
	{
		if (colaboraresDeFerias >= 3)
		{
			Console.WriteLine("Ferias, não pode ser liberada, pois a equipe não vai ter produtividade o suficiete");
		} else if (colaboraresDeFerias <= 2 && dias_de_atestado > dias_trabalhado) {
			Console.WriteLine("O funcionario teve muitos dia de atestado")
		} else {
			console.WriteLine("Pode Aprovar Ferias");
		}

		public string AlocarTarefa(string funcinario, string tarefa)
	{
		Console.WriteLine(funcinario + "Recebeu essa:" + tarefa);
		string tarefaAtual;
		tarefaAtual = funcinario + tarefa;
		return tarefaAtual;
	}



	}
}
