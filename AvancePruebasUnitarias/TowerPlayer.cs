using System;

namespace AvancePruebasUnitarias
{
	public class TowerPlayer : Tower
	{
		int positionPlayer;
		Random rnd = new Random();

		public TowerPlayer(int size)
		{
			if(size <= 0) throw new Exception("Out of range");
			GenerateTower(size);
			AssignPlayer();
		}

		public TowerPlayer()
		{
			GenerateTower(GenerateRandomSize());
			AssignPlayer();
		}

		void AssignPlayer()												//Genera el jugador
		{
			positionPlayer = rnd.Next(0, tower.Count + 1);
			tower[positionPlayer].GeneratePlayer();

		}
	}
}
