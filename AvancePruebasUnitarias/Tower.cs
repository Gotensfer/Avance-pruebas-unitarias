using System;
using System.Collections.Generic;

namespace AvancePruebasUnitarias
{
	public class Tower
	{
		List<Levels> tower = new List<Levels>();
		Random rnd = new Random();
		int amountLevels, positionPlayer, size;

		public Tower(int size)
		{			
			GenerateTower(size);
		}

		public Tower()
		{
			GenerateTower(GenerateRandomSize());
		}

		int GenerateRandomSize()
        {
			return (rnd.Next(1, 6));
		}

		void GenerateTower(int size)
        {
						
            for (int i = 0; i < size; i++)
            {
				tower.Add(null);
            }

			if(size <= 0) throw new Exception("Out of range");
        }

		/*void AssignPlayer()
        {
			positionPlayer = rnd.Next(0, towerPlayer.Count);
            for (int i = 0; i < towerPlayer.Count; i++)
            {
				if (i == positionPlayer) towerPlayer[i].GeneratePlayer();
            }
        }*/


	}
}
