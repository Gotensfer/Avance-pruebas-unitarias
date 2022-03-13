using System;

namespace AvancePruebasUnitarias
{
	public class TowerEnemy : Tower
	{
		Random rnd = new Random();
		int obs;

		public TowerEnemy(int size)
		{
			GenerateTower(size);
			AssignEnemy();
		}

		public TowerEnemy()
		{
			GenerateTower(GenerateRandomSize());
			AssignEnemy();
		}

		void AssignEnemy()
        {
            for (int i = 0; i < tower.Count; i++)
            {
				obs =rnd.Next(0, 2);
				if(obs == 0)
                {
					tower[i].GenerateEnemy();
					tower[i].enemy.str += i;
				}
                else
                {
					tower[i].GenerateObstacle();
					tower[i].obs.str += i;
				}
				
            }
        }
	}
}
