using System;

namespace AvancePruebasUnitarias
{
	public class Combat
	{
		Player player = new Player();
		Enemy enemy = new Enemy();
		string result;
		
		

		public Combat(int attackDir)						//attackDir es la posición de la torre a la cual se va a atacar
		{

		}

		public string Fight (int strgPlayer, int strgEnemy)
        {
			if (strgPlayer - strgEnemy <= 0) result = "Lose";
			else result = "Win";

			return result;
        }


	}
}

