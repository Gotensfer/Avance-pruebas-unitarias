using System;

namespace AvancePruebasUnitarias
{
	public class T_TowerPlayer : T_Tower
	{
		public int positionPlayer;
		Random rnd = new Random();

		public T_TowerPlayer(int size)
		{

			GenerateTower(size);
			AssignPlayer();
		}

		public T_TowerPlayer()
		{
			GenerateTower(GenerateRandomSize());
			AssignPlayer();
		}

		public void AssignPlayer()												//Genera el jugador
		{
			positionPlayer = rnd.Next(0, tower.Count);
			tower[positionPlayer].GeneratePlayer();

		}
	}
}
