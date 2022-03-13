using System;

namespace AvancePruebasUnitarias
{
	public class Combat
	{
		Player player = new Player();
		TowerEnemy enemy = new TowerEnemy();
		int result = 0;

		public Combat(int attackDir)						//attackDir es la posición de la torre a la cual se va a atacar
		{

		}

		int Fight (int strgPlayer, int strgEnemy, int attackDir)
        {
			
			result = player.str - enemy.tower[attackDir].enemy.str;

			return result;
        }

		void Lose()
        {
			player.life--;
        }

		void Win(int attackDir)
        {
			player.str += enemy.tower[attackDir].enemy.str;
		}
	}
}

