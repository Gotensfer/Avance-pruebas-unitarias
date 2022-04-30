﻿using System;

namespace AvancePruebasUnitarias
{
	public class Combat
	{
		T_Player player = new T_Player();
		T_Enemy enemy = new T_Enemy(0);
		string result;
		
		

		public Combat()						//attackDir es la posición de la torre a la cual se va a atacar
		{

		}

		public string Fight (T_Player player, T_Enemy enemy)
        {
			int final;
			Console.WriteLine("Fuerza player  " + player.str);
			Console.WriteLine("Fuerza enemigo  " + enemy.str);
			if (player.str - enemy.str > 0)
			{
				result = "Win";
				final = player.str + enemy.str;
				player.str = final;
			}
			else
			{
				result = "Lose";
				final = player.str + enemy.str;
				enemy.str = final;
			}

			Console.WriteLine("Fuerza player despues de luchar " + player.str);
			Console.WriteLine("Fuerza enemigo despues de luchar  " + enemy.str);
			return result;
		}
		public string Fight(T_Player player, T_Obstacle obs)
		{
			int final;
			Console.WriteLine("Fuerza player  " + player.str);
			Console.WriteLine("Fuerza enemigo  " + obs.str);
			if (player.str - obs.str > 0)
			{
				result = "Win";
				final = player.str + obs.str;
				player.str = final;
			}
			else
			{
				result = "Lose";
				final = player.str + obs.str;
				enemy.str = final;
			}

			Console.WriteLine("Fuerza player despues de luchar " + player.str);
			Console.WriteLine("Fuerza enemigo despues de luchar  " + obs.str);
			return result;
		}
		
		public string Fight(T_Player player, T_Enemy enemy,T_TowerPlayer tPlayer, T_TowerEnemy tEnemy, int attackDir)
		{
			
			Console.WriteLine("Tamaño torre jugador " + tPlayer.tower.Count);
			Console.WriteLine("Tamaño torre enemigo  " + tEnemy.tower.Count);
			Console.WriteLine("Fuerza player  " + player.str);
			Console.WriteLine("Fuerza enemigo  " + enemy.str);
			if (player.str - enemy.str > 0)
			{
				result = "Win";
				tPlayer.tower.Add(new Levels());
				tEnemy.tower.RemoveAt(attackDir);

				Console.WriteLine("Tamaño torre jugador despues de luchar  " + tPlayer.tower.Count);
				Console.WriteLine("Tamaño torre enemigo  despues de luchar  " + tEnemy.tower.Count);
			}
			else
			{
				result = "Lose";
			}

			Console.WriteLine("Fuerza player despues de luchar " + player.str);
			Console.WriteLine("Fuerza enemigo despues de luchar  " + enemy.str);
			return result;
		}
	}
}

