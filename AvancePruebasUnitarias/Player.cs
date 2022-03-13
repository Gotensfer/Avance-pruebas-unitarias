using System;

public class Player : Character
{
	Random rnd = new Random();
	public Player()
	{
		strg = rnd.Next(1, 1000);
	}
}
