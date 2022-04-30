using System;

public class Enemy: Character
{
	Random rnd = new Random();
	public Enemy(int force)
	{

		str = force;
	}
}
