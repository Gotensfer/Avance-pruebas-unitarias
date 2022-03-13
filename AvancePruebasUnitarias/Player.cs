using System;

public class Player : Character
{
	Random rnd = new Random();
	public Player()
	{
		strg = rnd.Next(1, 1000);
	}

	void Combat(int streaght, int result)
    {

    }
}
