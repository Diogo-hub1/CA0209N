using System;

public class Supervisor
{
	public Supervisor()
	{
		public string setor;
		public int qtdSubordinados;
		public string turno;

	 public string RelatarProblema(string problema)
	{
		Console.WriteLine("O " + problema + " foi relatado");
	}

	public string AlterarTurno( string Turno_desejado)
	{
		if (Turno_desejado = "Noturno") {
			console.WriteLine("Mudança Realizada, agora ele está noturno")
		} else if (Turno_desejado = "Diurno") {
            console.WriteLine("Mudança Realizada, agora ele é diurno")


        }
	}
}
