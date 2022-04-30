using System;

namespace AvancePruebasUnitarias
{
	public class T_Obstacle : T_Character
	{
		Random rnd = new Random();
		public T_Obstacle(int force)
		{
			if (force <= 0) throw new Exception("Out of range");
		}

		public T_Obstacle()
		{
			GenetareStrg(GenerateRandomSize());
			if (str <= 0) throw new Exception("Out of range");
		}

		public int GenerateRandomSize()
		{
			return (rnd.Next(1, 6));
		}

		public void GenetareStrg(int force)
		{
			str = rnd.Next(1, force);
		}
	}
}

