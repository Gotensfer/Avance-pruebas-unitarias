using System;

namespace AvancePruebasUnitarias
{
	public class T_TowerEnemy : T_Tower
	{
		Random rnd = new Random();
		int obs;

		public T_TowerEnemy(int size)
		{
			GenerateTower(size);
			AssignEnemy();
		}

		public T_TowerEnemy()
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
					tower[i].GenerateEnemy(rnd.Next());
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
