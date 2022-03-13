﻿using System;

namespace AvancePruebasUnitarias
{
	public class Player : Character
	{
		Random rnd = new Random();

		public Player(int force)
		{
			GenetareStrg(force);
			if (force <= 0) throw new Exception("Out of range");
		}
		public Player()
		{
			strg = rnd.Next(1, 6);
			if (strg <= 0) throw new Exception("Out of range");
		}

		public void GenetareStrg(int force)
        {
			strg = rnd.Next(1, force);
		}
	}
}

