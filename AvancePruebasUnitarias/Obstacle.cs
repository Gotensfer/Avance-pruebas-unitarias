using System;

namespace AvancePruebasUnitarias
{
	public class Obstacle : Character
	{
		Random rnd = new Random();
		public Obstacle(int force)
		{
			if (force <= 0) throw new Exception("Out of range");
		}

		public Obstacle()
		{
			GenetareStrg(GenerateRandomSize());
			if (strg <= 0) throw new Exception("Out of range");
		}

		public int GenerateRandomSize()
		{
			return (rnd.Next(1, 6));
		}

		public void GenetareStrg(int force)
		{
			strg = rnd.Next(1, force);
		}
	}
}

