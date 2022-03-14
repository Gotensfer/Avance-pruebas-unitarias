using System;

namespace AvancePruebasUnitarias
{
	public class Combat
	{
		Player player = new Player();
		Enemy enemy = new Enemy(0);
		string result;
		
		

		public Combat()						//attackDir es la posición de la torre a la cual se va a atacar
		{

		}

		public string Fight (int strPlayer, int strEnemy)
        {
			if (strPlayer - strEnemy > 0) result = "Win";
			else result = "Lose";

			return result;
        }


	}
}

