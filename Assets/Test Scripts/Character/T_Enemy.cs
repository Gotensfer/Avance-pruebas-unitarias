using System;

public class T_Enemy: T_Character
{
	Random rnd = new Random();
	public T_Enemy(int force)
	{

		str = force;
	}
}
