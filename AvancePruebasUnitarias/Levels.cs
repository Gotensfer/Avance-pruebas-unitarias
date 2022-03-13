using System;

namespace AvancePruebasUnitarias
{
	public class Levels
	{
		public Enemy enemy;
		public Player player;
		public Obstacle obs;
		public Levels()
		{

		}

		public void GenerateEnemy()
		{
			enemy = new Enemy();
		}

		public void GeneratePlayer()
		{
			player = new Player();
		}

		public void GenerateObstacle()
        {
			obs = new Obstacle();
        }
	}
}

