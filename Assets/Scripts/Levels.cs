﻿using System;

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

		public void GenerateEnemy(int force)
		{
			enemy = new Enemy(force);
		}

		public void GeneratePlayer()
		{
			player = new Player();
			if (player.str < 1) throw new Exception("Out of range");
		}

		public void GenerateObstacle()
        {
			obs = new Obstacle();
        }
	}
}

