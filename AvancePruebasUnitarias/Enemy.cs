using System;

public class Enemy: Character
{
	Random rnd = new Random();
	public Enemy()
	{

		strg = rnd.Next(1, 1000);
	}
}
