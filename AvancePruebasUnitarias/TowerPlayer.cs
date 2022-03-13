using System;

namespace AvancePruebasUnitarias
{
	public class TowerPlayer : Tower
	{
		int positionPlayer;
		Random rnd = new Random();

		public TowerPlayer(int size)
		{
			GenerateTower(size);
			AssignPlayer();
		}

		public TowerPlayer()
		{
			GenerateTower(GenerateRandomSize());
			AssignPlayer();
		}

		void AssignPlayer()
		{
			positionPlayer = rnd.Next(0, tower.Count);
			for (int i = 0; i < tower.Count; i++)
			{
				if (i == positionPlayer) tower[i].GeneratePlayer();
			}
		}
	}
}
