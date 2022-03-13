﻿using System;

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

		public void GenetareStrg(int force)
        {
			if (force < 0) throw new Exception("Out of range");
			else str = rnd.Next(1, force + 1);

		}
	}
}

