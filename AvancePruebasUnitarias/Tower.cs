using System;
using System.Collections.Generic;

namespace AvancePruebasUnitarias
{
	public class Tower : Levels
	{
		List<Levels> towerPlayer = new List<Levels>(), towerEnemy = new List<Levels>();
		Random rnd = new Random();
		int amountLevels, positionPlayer;

		public Tower(int amount)
		{
			amountLevels = rnd.Next(1, amount);
			for (int i = 0; i < amountLevels; i++)
			{
				towerPlayer.Add(null);
			}
		}

		void GenerateTower()
        {
			if(amountLevels <= 0) throw new Exception("Out of range");
        }

		void AssignPlayer()
        {
			positionPlayer = rnd.Next(0, towerPlayer.Count);
            for (int i = 0; i < towerPlayer.Count; i++)
            {
				if (i == positionPlayer) towerPlayer[i].GeneratePlayer();
            }
        }


	}
}
