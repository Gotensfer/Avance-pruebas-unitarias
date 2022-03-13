using System;

namespace AvancePruebasUnitarias
{
	public class TowerEnemy : Tower
	{
		public TowerEnemy()
		{
			GenerateTower(GenerateRandomSize());
		}

		void AssignEnemy()
        {
            for (int i = 0; i < tower.Count; i++)
            {
				tower[i].GenerateEnemy();
				tower[i].enemy.strg += i;
            }
        }
	}
}
