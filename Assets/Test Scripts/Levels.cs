using System;

namespace AvancePruebasUnitarias
{
	public class Levels
	{
		public T_Enemy enemy;
		public T_Player player;
		public T_Obstacle obs;
		public Levels()
		{

		}

		public void GenerateEnemy(int force)
		{
			enemy = new T_Enemy(force);
		}

		public void GeneratePlayer()
		{
			player = new T_Player();
			if (player.str < 1) throw new Exception("Out of range");
		}

		public void GenerateObstacle()
        {
			obs = new T_Obstacle();
        }
	}
}

