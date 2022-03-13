﻿using System;

namespace AvancePruebasUnitarias
{
	public class TowerPlayer : Tower
	{
		public int positionPlayer;
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

		public void AssignPlayer()												//Genera el jugador
		{
			positionPlayer = rnd.Next(0, tower.Count + 1);
			tower[positionPlayer].GeneratePlayer();

		}
	}
}
