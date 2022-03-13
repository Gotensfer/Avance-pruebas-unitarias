using System;

public class Player : Character
{
	Random rnd = new Random();
	public Player()
	{
		strg = rnd.Next(1, 6);
		if (strg <= 0) throw new Exception("Out of range");
	}
}
