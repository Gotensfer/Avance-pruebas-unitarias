using System;

public class Enemy: Character
{
	Random rnd = new Random();
	public Enemy()
	{

		str = rnd.Next(1, 1000);
	}
}
