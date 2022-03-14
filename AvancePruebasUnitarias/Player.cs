using System;

namespace AvancePruebasUnitarias
{
	public class Player : Character
	{
		Random rnd = new Random();
		public int life = 3;

		public Player(int force)
		{
			GenetareStrg(force);
			if (force <= 0) throw new Exception("Out of range");
		}
		public Player()
		{
			str = rnd.Next(1, 6);
			if (str <= 0) throw new Exception("Out of range");
		}

		public void GenetareStrg()
        {
			int force = rnd.Next(1, 15);
			if (force < 0) throw new Exception("Out of range");
			else str = force;
		}

		public void GenetareStrg(int force)
		{
			str = force;
		}
	}
}

